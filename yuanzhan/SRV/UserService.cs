using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using BLL;
using BLL.repoistory;

namespace SRV
{
    public class UserService:IUserService
    {
        private UserRepoistory _userRepoistory;

        public UserService()
        {
            _userRepoistory = new UserRepoistory();
        }

        public void SendValiadationEmail(string emailAddress, string validationUrlFormat)
        {
            Email email = new Email { Address = emailAddress };
            email.MakeValidationCode();
            _userRepoistory = new UserRepoistory();
            _userRepoistory.Save(email);

            string validationUrl = string.Format(validationUrlFormat, email.ValidationCode, email.Id);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("q123922261@163.com");
            mail.To.Add(emailAddress);
            mail.Subject = "一起帮注册验证";
            mail.Body = validationUrl;

            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Port = 25;
            SmtpServer.Host = "smtp.163.com";
            SmtpServer.Credentials = new System.Net.NetworkCredential("q123922261", "q199696");
            SmtpServer.EnableSsl = false;

            SmtpServer.Send(mail);

        }

        public UserModel GetById(int id)
        {
          MYUser user =  _userRepoistory.GetById(id);
            if (user==null)
            {
                return null;
            }
            else
            {
                UserModel model = new UserModel
                {
                    Id = user.Id,
                    Name = user.Name,
                    MD5Password = user.Password
                };
                return model;
            }

        }

        public bool PasswordCorrect(string rpassword, string MD5PassWord)
        {
            return MYUser.GetMD5Hash(rpassword) == MD5PassWord;
        }

        public UserModel GetUser(string userName)
        {
            MYUser user = _userRepoistory.GetByName(userName);
            if (user==null)
            {
                return null;
            }
            else
            {
                UserModel userModel = new UserModel();
                userModel.Id = user.Id;
                userModel.MD5Password = user.Password;
                return userModel;
            }
        }

        //public UserModel Login(string userName, string passWord)
        //{
           
        //    User user = _userRepoistory.GetByName(userName);
        //    if (user == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        UserModel userModel = new UserModel();
        //        if (user.GetMD5Hash(passWord) == user.Password)
        //        {

        //        }
        //        else { }
        //        userModel.Id = user.Id;
        //        userModel.MD5Password = user.Password;
        //        return userModel;
        //    }
           
        //}

        public bool ValiadationEmail(int id, string code)
        {
            Email email = _userRepoistory.GetEmailById(id);
            email.Validate();
            _userRepoistory.Flush();
            return email.ValidationCode == code;
        }
    }
   
}
