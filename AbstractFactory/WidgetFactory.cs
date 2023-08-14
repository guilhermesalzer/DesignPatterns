// Abstract factory
namespace WidgetFactory {
    public interface IWidgetFactory {

        // Abstract Factory provides an interface to create abstract products.
        abstract IScrollBar CreateScrollBar();
        abstract IWindow CreateWindows();
    }
}