using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCool.Project.Skills
{
    public static class SkillManipulatorExtended
    {
        public static uint Sum(this IEnumerable<Skill> skills)
        {
            uint sum = 0;
            foreach (var skill in skills)
                sum += skill.CountPoints;

            return sum;
        }
    }
}
