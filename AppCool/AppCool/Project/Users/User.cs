﻿using AppCool.Project.Event;
using AppCool.Project.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCool.Project.Users
{
    public class User
    {
        public readonly uint Id;
        public readonly FIO FullName;
        public readonly Notification Notification;
        public readonly SkillsInventory SkillInventory;
        public readonly GatheringInventory GatheringInventory;

        public User(uint id, FIO fio)
        {
            (Id, FullName) = (id, fio);

            Notification = new Notification();
            SkillInventory = new SkillsInventory();
            GatheringInventory = new GatheringInventory();
        }
    }
}
