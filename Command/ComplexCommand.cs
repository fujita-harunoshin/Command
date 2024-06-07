namespace Command;

internal class ComplexCommand(Receiver receiver, string a, string b) : ICommand
{
    private Receiver _receiver = receiver;

    private string _a = a;

    private string _b = b;

    /// <summary>
    /// 引数でパラメータを受け取らない。パラメータはインスタンスで持つ。
    /// </summary>
    public void Excute()
    {
        Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
        _receiver.DoSomething(_a);
        _receiver.DoSomethingElse(_b);
    }
}
