// Concrete Product B
public class Window : IWindow
{
    public void Close()
    {
        Console.WriteLine("Motif Window closed.");
    }

    public void Open()
    {
        Console.WriteLine("Motif Window opened.");
    }
}