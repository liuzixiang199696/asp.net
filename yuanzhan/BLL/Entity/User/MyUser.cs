using BLL.entity;
using DAL;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace BLL
{
    public class MYUser:Entity
    {
        static MYUser()
        {
            _UserHelper = new UserHelper();
        }
        private static UserHelper _UserHelper;
        public String Name { get; set; }
        public string Password { get; set; }
        public MYUser InvitedBy { get; set; }
        public Email Email { get; set; }


        public static bool IsNameDuplicated(string name)
        {
            return _UserHelper.GetByName(name) != null;
        }
        public bool IsPasswordValid()
        {
            return Password.Length >= 4;
        }

        public void Register(MYUser user)
        {
            _UserHelper.Save(user.Name, user.Password);
            Password = GetMD5Hash(Password);
        }
        public static string GetMD5Hash(string input)
        {
            const string _salt = "*-%zx96";
            using (MD5 md5Hash = MD5.Create())
            {                

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

