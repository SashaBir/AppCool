using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCool.Project.Skills;

namespace AppCool.Project.Users
{
    public class SkillsInventory
    {
        private readonly Dictionary<SkillType, Skill> _skills;

        public SkillsInventory()
        {
            _skills = new Dictionary<SkillType, Skill>();
        }

        public IEnumerable<Skill> Skill => (IEnumerable<Skill>)_skills;

        public void Add(IEnumerable<Skill> skills)
        {
            foreach (var skill in skills)
            {
                if (_skills.ContainsKey(skill.Type) == false)
                    _skills.Add(skill.Type, skill);

                _skills[skill.Type].AddPoints(skill.CountPoints);
            }
        }
    }
}
