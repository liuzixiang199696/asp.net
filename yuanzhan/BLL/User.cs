using DAL;
using System;
using System.Collections.Generic;
using System.Text;


namespace BLL
{
    public class User
    {
        static User() {

            _userHelper =  new UserHelper();
        }
        private static UserHelper _userHelper;
        public int Id { get; set; }
        public String Name { get; set; }
        public string Password { get; set; }

        public static bool IsNameDuplicated(string name)
        {
            return _userHelper.GetByName(name)!=null;
        }
        public bool IsPasswordValid()
        {
            return Password.Length >= 4;
        }

        public static void Register(User user)
        {
            _userHelper.Save(user.Name, user.Password);
        }

    }
}
