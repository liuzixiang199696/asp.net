using System;
using System.Collections.Generic;
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



        }

        public bool ValiadationEmail(int id, string code)
        {
            Email email = _userRepoistory.GetEmailById(id);
            return email.ValidationCode==code;
        }
    }
}
