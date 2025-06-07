using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static bool XOLinq(string input)
    {
        var oS = input.Count(x => char.ToLower(x) == 'o');
        var xS = input.Count(x => char.ToLower(x) == 'x');
        return oS == xS;
    }
    public static bool XO(string input)
    {
        var oS = 0;
        var xS = 0;
        foreach (var x in input)
        {
            GetOsAndXs(ref oS, ref xS, x);
        }
        return oS == xS;
    }

    private static void GetOsAndXs(ref int oS, ref int xS, char x)
    {
        switch (char.ToLower(x))
        {
            case 'o':
                oS++;
                break;
            case 'x':
                xS++;
                break;
        }
    }
}