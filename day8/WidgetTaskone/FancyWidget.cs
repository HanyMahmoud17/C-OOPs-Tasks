using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetTaskone
{
    public class FancyWidget : widget
    {
        public override void First()
        {
            base.First();
        }
        public new void Second()
        {
            //base.Second();
            Console.WriteLine("new project by this class not the old by using keyword new");
        }
    }
}
