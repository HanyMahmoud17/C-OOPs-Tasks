using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWidgetTaskTwo
{
    internal class Widget : IWidget
    {
        public virtual void First()
        {
            Console.WriteLine("Widget First method");
        }

        void IWidget.Second()
        {
            Console.WriteLine("Widget Second method");
        }
    }
}
