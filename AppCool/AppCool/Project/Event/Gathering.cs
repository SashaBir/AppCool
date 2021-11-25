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
        public readonly Information InformationAboutIt;

        private readonly Teacher _creator;
        private readonly UserCollecter _collecter;

        public event Action<Information> OnStarted = delegate { };

        public Gathering(Teacher creator, Information information)
        {
            (_creator, InformationAboutIt) = (creator, information);
        }

        public void Start()
        {
            OnStarted.Invoke(InformationAboutIt);
        }

        public void Follow(User user)
        {
            _collecter.Add(user);
        }

        public void Unfollow(User user)
        {
            _collecter.Add(user);
        }
    }
}