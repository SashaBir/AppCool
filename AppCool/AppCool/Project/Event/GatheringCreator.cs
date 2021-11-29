using AppCool.Project.Skills;
using AppCool.Project.Users;
using System;
using System.Collections.Generic;

namespace AppCool.Project.Event
{
    public class GatheringCreator
    {
        public event Action<Gathering> OnCreated = delegate { };

        public readonly GatheringCollecter _collecter;

        public GatheringCreator()
        {
            _collecter = new GatheringCollecter();
        }

        public Gathering Creat(Teacher teacher, Information information, IReadOnlyCollection<Skill> skills)
        {
            Gathering gathering =  new Gathering(teacher, information, skills);
            _collecter.Add(gathering);

            OnCreated.Invoke(gathering);

            return gathering;
        }
    }
}
