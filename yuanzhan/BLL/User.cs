using DAL;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace BLL
{
    public class User
    {
        static User()
        {

            _UserHelper = new UserHelper();
        }

        private static UserHelper _UserHelper;
        public int Id { get; set; }
        public String Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }


        public static bool IsNameDuplicated(string name)
        {
            return _UserHelper.GetByName(name) != null;
        }
        public bool IsPasswordValid()
        {
            return Password.Length >= 4;
        }

        public void Register(User user)
        {
            _UserHelper.Save(user.Name, user.Password);
            Password = GetMD5Hash(Password);
        }
        public static string GetMD5Hash(string input)
        {
            const string _salt = "*-%zx96";
            using (MD5 md5Hash = MD5.Create())
            {
                Password = GetMD5Hash(Password);

                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input + _salt));
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}

