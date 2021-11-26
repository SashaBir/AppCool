using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCool.Project.Skills;

namespace AppCool.Project.Event
{
    public class SkillsKeeper
    {
        private readonly Dictionary<SkillType, Skill> _skills;

        public SkillsKeeper(IReadOnlyCollection<Skill> skills)
        {
            _skills = new Dictionary<SkillType, Skill>(skills.Count);

            foreach (var skill in skills)
            {
                if (_skills.ContainsKey(skill.Type) == true)
                    throw new Exception($"{skill.Type} has already been added.");

                _skills.Add(skill.Type, skill);
            }
        }

        public IEnumerable<Skill> Skills => (IEnumerable<Skill>)_skills;
    }
}
