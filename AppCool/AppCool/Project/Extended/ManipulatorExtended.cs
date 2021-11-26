using AppCool.Project.Skills;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace AppCool.Project.Extended
{
    public static class ManipulatorExtended
    {
        public static void SwitchToOtherPage<T>(this object oldPage, T newPage)
            where T : Page
        {
            if (oldPage == null)
                throw new Exception();

            var frame = (Frame)oldPage;
            if (frame is Frame)
            {
                frame.Content = newPage;
                return;
            }

            var page = (Page)oldPage;
            if (page is Page)
            {
                page.Content = newPage;
                return;
            }
        }

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
