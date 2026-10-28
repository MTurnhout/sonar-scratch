namespace Lib;

public static class Orders
{
    // S107 (too many parameters): its maximum, 7 by default, is a rule parameter a quality profile can change
    public static int Total(int a, int b, int c, int d, int e, int f, int g, int h) => a + b + c + d + e + f + g + h;

    // S2068 (hard-coded credentials): a security hotspot, reviewed on the server rather than suppressed in the code
    private const string ConnectionString = "Server=localhost;User Id=scratch;Password=not-a-secret";

    public static int Length => ConnectionString.Length;

    public static string Classify(int quantity)
    {
        if (quantity > 0)
        {
            if (quantity > 10)
            {
                if (quantity > 100)
                {
                    if (quantity > 1000)
                    {
                        return "huge";
                    }

                    return "large";
                }

                return "medium";
            }

            return "small";
        }

        return "none";
    }
}
