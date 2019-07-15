using System;
using BLL;
using BLL.Repoistory;

namespace SRV
{
    public class RegisterService
    {
        public void Register(string username, string password)
        {
            User user = new User
            {
                Name = username,
                Password = password
            };
            User.Register(user);
            new UserRepoistory().Save(user);

        }

        public bool HasExist(string userName)
        {
            return new UserRepoistory().GetByName(userName) != null;
        }
    }
}

