using Lanternfish.Logic;

namespace Lanternfish.App;

public class Program
{
    public static void Main()
    {
        var fishes = LanternfishFileReader.Read(@"C:\Temp\data.txt");

        foreach (var fish in fishes)
        {
            System.Console.WriteLine(fish);
        }
    }
}