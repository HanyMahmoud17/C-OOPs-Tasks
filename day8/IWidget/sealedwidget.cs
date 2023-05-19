
namespace IWidgetTaskTwo
{
    public sealed class SealedWidget : IWidget
    {
        void IWidget.First()
        {
            Console.WriteLine("SealedWidget First method");
        }

        void IWidget.Second()
        {
            Console.WriteLine("SealedWidget Second method");
        }
    }
}