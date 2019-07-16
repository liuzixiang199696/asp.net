using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using BLL;
using BLL.Repoistory;

namespace SRV
{
    public class UserService
    {
        private UserRepoistory _userRepoistory;


        public void SendValiadationEmail(string emailAddress, string validationUrlFormat)
        {
            Email email = new Email { Address = emailAddress };
            _userRepoistory = new UserRepoistory();
            _userRepoistory.Save(email);
            string validationUrl = string.Format(validationUrlFormat, email.Id, email.ValidationCode);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("q123922261@163.com");
            mail.To.Add(emailAddress);
            mail.Subject = "一起帮注册验证";
            mail.Body = validationUrl+"不验证，打屁股！";

            SmtpClient SmtpServer = new SmtpClient("smtp.163.com");
            SmtpServer.Port = 465;
            SmtpServer.Credentials = new System.Net.NetworkCredential("q123922261@163.com","q199609066");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);


        }

        public bool ValiadationEmail(int id, string code)
        {
            Email email = _userRepoistory.GetEmailById(id);
            email.Validate();
            _userRepoistory.Flush();
            return email.ValidationCode == code;
        }
    }
}
