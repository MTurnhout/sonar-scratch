namespace Lib;

public static class Names
{
    public static string Greet(string name)
    {
        var text = "Hello, " + name;;
        return text;
    }

#pragma warning disable S1144 // Unused private types or members should be removed
    private static void NeverCalled()
    {
    }
#pragma warning restore S1144
}
