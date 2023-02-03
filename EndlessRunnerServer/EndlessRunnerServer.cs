using CloudCode.Authoring.Modules;

namespace EndlessRunnerServer;

public class EndlessRunnerServer
{
    [CloudCodeFunction("HelloWorld")]
    public string HelloWorld()
    {
        return "Hello world!";
    }
}