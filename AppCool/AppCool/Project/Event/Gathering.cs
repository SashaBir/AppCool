using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCool.Project.Users;

namespace AppCool.Project.Event
{
    // Gathering - мероприятие 
    public class Gathering
    {
        private readonly Teacher _creator;
        private readonly Information _information;
        private readonly UserCollecter _collecter;

        private Gathering(Teacher creator, Information information)
        {
            (_creator, _information) = (creator, information);
        }

        public void Follow(User user)
        {
            _collecter.Add(user);
        }

        public void Unfollow(User user)
        {
            _collecter.Add(user);
        }

        public string GetDirector() 
        {
            return _creator.FullName.ToString();
        }
    }
}