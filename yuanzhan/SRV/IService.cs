using BLL.repoistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public interface IUserService
    {
        void SendValiadationEmail(string emailAddress, string validationUrlFormat, DateTime dateTime, int id);


        int GetByAutherId(int id);


        UserModel GetById(int id);


        bool PasswordCorrect(string rpassword, string MD5PassWord);


        UserModel GetUser(string userName);


        UserModel Login(string userName, string passWord);


        bool ValiadationEmail(int id, string code);

    }

}

