using System;
using System.Collections.Generic;

namespace AppCool.Project.Event
{
    public class GatheringInventory
    {
        private readonly SortedDictionary<uint, Information> _gatherings;

        public GatheringInventory()
        {
            _gatherings = new SortedDictionary<uint, Information>();
        }

        public uint Count { private set; get; }

        public void Add(Information information)
        {
            if (_gatherings.ContainsKey(information.Id) == true)
                throw new Exception($"{information.Id} that gathering hass already been added.");

            _gatherings.Add(information.Id, information);
            Count++;
        }
    }
}
