using Lanternfish.Logic.Model;

namespace Lanternfish.Logic;

public static class LanternfishFileReader
{
    public static List<LanternfishModel> Read(string filePath)
    {
        var lanternfishes = new List<LanternfishModel>();

        string fileContent = File.ReadAllText(filePath);
        foreach (var split in fileContent.Split(','))
        {
            lanternfishes.Add(new LanternfishModel(Convert.ToInt32(split.Trim())));
        }

        return lanternfishes;
    }
}