using WidgetFactory;

namespace PmWidgetFactory {
    public class PmWidgetFactory : IWidgetFactory
    {        
        IScrollBar IWidgetFactory.CreateScrollBar()
        {
            return new ScrollBarPm();
        }

        IWindow IWidgetFactory.CreateWindows()
        {
            return new WindowPm();
        }
    }
}