using System.Diagnostics.CodeAnalysis;
using Lib;

namespace App;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Describe(3, "unused"));
        Console.WriteLine(Scale(2));;
        Console.WriteLine(Names.Greet("Sonar"));
        Console.WriteLine(Orders.Total(1, 2, 3, 4, 5, 6, 7, 8));
        // TODO: read the count from the command line
    }

#pragma warning disable S1144 // Unused private types or members should be removed
    private static void NeverCalled()
    {
    }
#pragma warning restore S1144

    [SuppressMessage("Major Code Smell", "S1172:Unused method parameters should be removed", Justification = "Kept for callers")]
    private static string Describe(int count, string unused) => $"{count} items";

    private static int Scale(int value)
    {
#pragma warning disable S109 // Magic numbers should not be used
        return value * 42;
#pragma warning restore S109
    }

    private static void AlsoNeverCalled()
    {
    }

    private static int Ignore(int value, int other) => value;
}
