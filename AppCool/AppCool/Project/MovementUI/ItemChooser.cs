using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCool.Project.MovementUI
{
    public static class ItemChooser
    { 
        public static T Choose<T>()
            where T : new()
        {
            return new T();
        }
    }
}
