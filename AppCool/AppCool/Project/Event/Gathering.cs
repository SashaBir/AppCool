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
        private readonly User _user;
        private readonly Information _information;

        private Gathering(User user, Information information)
        {
            (_user, _information) = (user, information);
        }
    }
}