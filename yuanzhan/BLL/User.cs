using DAL;
using System;
using System.Collections.Generic;
using System.Text;


namespace BLL
{
    public class User
    {
        static User() {

            _UserHelper =  new UserHelper();
        }
        private static UserHelper _UserHelper;
        public int Id { get; set; }
        public String Name { get; set; }
        public string Password { get; set; }
       


        public static bool IsNameDuplicated(string name)
        {
            return _UserHelper.GetByName(name)!=null;
        }
        public bool IsPasswordValid()
        {
            return Password.Length >= 4;
        }

        public static void Register(User user)
        {
            _UserHelper.Save(user.Name, user.Password);
        }

    }
}
