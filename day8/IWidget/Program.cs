

namespace IWidgetTaskTwo
{
    public class Program
    {
        static int Main ()
        {
            Widget myWidget = new Widget();
            IWidget myIWidget = myWidget;
            myIWidget.Second();
            myIWidget.First();

            Console.WriteLine();

            SealedWidget Myw = new SealedWidget();
            IWidget myI = Myw;
            myI.Second();

            return 0;
        }
    }

}