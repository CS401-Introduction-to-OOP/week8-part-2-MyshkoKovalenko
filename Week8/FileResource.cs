class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name) {}

    public override void Open()
    {
        Console.WriteLine($"{Name} is opened");
        IsOpen = true;
    }

    public override void Close()
    {
        Console.WriteLine($"{Name} is closed");
        IsOpen = false;
    }

    public void Dispose()
    {
        Close();
    }
}