using AppCool.Project.Skills;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCool.Project.Extended
{
    public static class ManipulatorExtended
    {
        public static uint SumSkillPoints(this IEnumerable<Skill> skills)
        {
            uint sum = 0;
            foreach (var skill in skills)
                sum += skill.CountPoints;

            return sum;
        }

        public static IEnumerable<TValue> GetIEnumerable<TKey, TValue>(this IDictionary<TKey, TValue> source)
        {
            TValue[] skills = new TValue[source.Count];

            var keys = source.Keys;
            int index = 0;
            foreach (var key in keys)
            {
                skills[index] = source[key];
                index++;
            }

            return skills;
        }
    }
}
