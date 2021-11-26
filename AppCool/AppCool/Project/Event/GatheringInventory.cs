using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCool.Project.Event
{
    public class GatheringInventory
    {
        public readonly SortedDictionary<uint, Information> _gathering;

        public GatheringInventory()
        {
            _gathering = new SortedDictionary<uint, Information>();
        }

        public uint Count { private set; get; }

        public void Add(Information information)
        {
            if (_gathering.ContainsKey(information.Id) == true)
                throw new Exception($"{information.Id} that gathering hass already been added.");

            _gathering.Add(information.Id, information);
            Count++;
        }
    }
}
