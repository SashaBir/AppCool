using AppCool.Project.Extended;
using System;
using System.Collections.Generic;

namespace AppCool.Project.Event
{
    public class GatheringCollecter
    {
        private readonly SortedDictionary<uint, Gathering> _gatherings;

        public GatheringCollecter()
        {
            _gatherings = new SortedDictionary<uint, Gathering>();
        }

        public IEnumerable<Gathering> Users => _gatherings.GetIEnumerable();

        public void Add(Gathering gathering)
        {
            if (_gatherings.ContainsKey(gathering.Information.Id) == true)
                throw new Exception($"{gathering.Information.Id} That gathering has been added");

            _gatherings.Add(gathering.Information.Id, gathering);
        }
    }
}
