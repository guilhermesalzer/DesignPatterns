// Concrete Product B
public class WindowPm : IWindow
{
    public void Close()
    {
        Console.WriteLine("Pm Window closed.");
    }

    public void Open()
    {
        Console.WriteLine("Pm Window opened.");
    }
}