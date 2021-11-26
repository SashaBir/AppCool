using AppCool.Project.Extended;
using AppCool.Project.Skills;
using System.Collections.Generic;

namespace AppCool.Project.Users
{
    public class SkillsInventory
    {
        private readonly Dictionary<SkillType, Skill> _skills;

        public SkillsInventory()
        {
            _skills = new Dictionary<SkillType, Skill>();
        }

        public IEnumerable<Skill> Skills => _skills.GetIEnumerable();
           
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
