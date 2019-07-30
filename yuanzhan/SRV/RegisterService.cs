using System;
using BLL;
using BLL.repoistory;

namespace SRV
{
    public class RegisterService: BaseService
    {
        UserRepoistory _userRepoistory;
        public RegisterService(UserRepoistory userRepoistory)
        {
            _userRepoistory = userRepoistory;
        }
        public void Register(string username, string password)
        {
            MYUser user = new MYUser
            {
                Name = username,
                Password = password
            };
            user.Register(user);
            _userRepoistory.Save(user);

        }

        public bool HasExist(string userName)
        {
            return _userRepoistory.GetByName(userName) != null;
        }
    }
}

