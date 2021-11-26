using AppCool.Project.Extended;
using AppCool.Project.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCool.Project.Users
{
    public class UserCollecter
    {
        private readonly SortedDictionary<uint, User> _users;

        public UserCollecter()
        {
            _users = new SortedDictionary<uint, User>();
        }

        public IEnumerable<User> Users => _users.GetIEnumerable();

        public void Add(User user)
        {
            if (_users.ContainsKey(user.Id) == true)
                throw new Exception($"{user.Id} That user has been added");

            _users.Add(user.Id, user);
        }

        public void Remove(User user)
        {
            if (_users.ContainsKey(user.Id) == false)
                throw new Exception($"{user.Id} That user has been not added");

            _users.Remove(user.Id);
        }
    }
}
