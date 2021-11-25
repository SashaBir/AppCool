using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCool.Project.Users
{
    public class User
    {
        public readonly FIO FullName;

        private User(FIO fio)
        {
            FullName = fio;
        }
    }
}
