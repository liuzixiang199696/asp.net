using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repoistory
{
    public class UserRepoistory
    {
        private static IList<User> _users;
        private static int _idCouunter;
        public User Save(User user)
        {
            _users = _users ?? new List<User>();
            _idCouunter++;
            user.Id = _idCouunter;
            _users.Add(user);
            return user;
        }

        public User GetByName(string userName)
        {
            return _users.Where(u => u.Name == userName).SingleOrDefault();
        }
    }
}
