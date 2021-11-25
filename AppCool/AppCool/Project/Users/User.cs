﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCool.Project.Users
{
    public class User
    {
        public readonly FIO FullName;

        public User(FIO fio)
        {
            FullName = fio;
        }

        public uint Id { private set; get; }
    }
}
