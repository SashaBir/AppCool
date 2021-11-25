using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AppCool.Project.Extended
{
    public static partial class Extended
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
    }
}
