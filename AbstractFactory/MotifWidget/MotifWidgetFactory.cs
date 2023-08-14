using WidgetFactory;

namespace MotifWidgetFactory {
    public class MotifWidgetFactory : IWidgetFactory
    {
        IScrollBar IWidgetFactory.CreateScrollBar()
        {
            return new ScrollBar();
        }

        IWindow IWidgetFactory.CreateWindows()
        {
            return new Window();
        }
    }

}