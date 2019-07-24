using System;
using BLL;
using BLL.repoistory;

namespace SRV
{
    public class RegisterService
    {
        public void Register(string username, string password)
        {
            MYUser user = new MYUser
            {
                Name = username,
                Password = password
            };
            user.Register(user);
            new UserRepoistory().Save(user);

        }

        public bool HasExist(string userName)
        {
            return new UserRepoistory().GetByName(userName) != null;
        }
    }
}

