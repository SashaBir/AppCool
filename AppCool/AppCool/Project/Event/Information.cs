using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCool.Project.Event
{
    public class Information
    {
        private Information(string title, string description)
        {
            (Title, Description) = (title, description);
        }

        public string Title { private set; get; }
        public string Description { private set; get; } // описание мероприятия

    }
}
