namespace Command;

internal class SimpleCommand(string payload) : ICommand
{
    private string _payload = payload;

    public void Excute()
    {
        Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({_payload})");
    }
}
