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

        public void SendValiadationEmail(string emailAddress, string validationUrlFormat,DateTime dateTime,int id)
        {
            dateTime = DateTime.Now;
            Email email = new Email { Address = emailAddress,EmailHasValidated=dateTime,OwnerId=id};
            email.MakeValidationCode();
            _userRepoistory = new UserRepoistory();
            _userRepoistory.Save(email);

            string validationUrl = string.Format(validationUrlFormat, email.ValidationCode, email.id);
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
        public int GetByAutherId(int id)
        {
            Email email = _userRepoistory.GetEmailById(id);
            if (email.OwnerId!=0)
            {
                return id;
            }
            else
            {
                return 0;
            }

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
                    Id = user.id,
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
                userModel.Id = user.id;
                userModel.MD5Password = user.Password;
                return userModel;
            }
        }

        public UserModel Login(string userName, string passWord)
        {

            MYUser user = _userRepoistory.GetByName(userName);
            if (user == null)
            {
                return null;
            }
            else
            {
                UserModel userModel = new UserModel();
                //if (user.GetMD5Hash(passWord) == user.Password)
                //{

                //}
                //else { }
                userModel.Id = user.id;
                userModel.MD5Password = user.Password;
                return userModel;
            }

        }

        public bool ValiadationEmail(int id, string code)
        {
            Email email = _userRepoistory.GetEmailById(id);
            _userRepoistory.Flush();
            return email.ValidationCode == code;
        }
    }
   
}
