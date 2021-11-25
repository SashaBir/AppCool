﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCool.Project.Users
{
    public class FIO
    {
        public FIO(string name, string subName, string middleName)
        {
            (Name, SubName, MiddleName) = (name, subName, middleName);
        }

        public string Name { private set; get; } // имя
        public string SubName { private set; get; } // фамилия
        public string MiddleName { private set; get; } // отчество

        public override string ToString()
        {
            return $"{SubName} {Name} {MiddleName}";
        }
    }
}
