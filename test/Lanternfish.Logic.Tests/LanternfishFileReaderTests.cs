using NUnit.Framework;
using Lanternfish.Logic;

namespace Lanternfish.Logic.Tests;

public class LanternfishFileReaderTests
{
    [Test]
    public void Test1()
    {
        string filePath = TestContext.CurrentContext.TestDirectory + "\\TestData\\valid_file.txt";
        var lanternfishes = LanternfishFileReader.Read(filePath);

        Assert.IsTrue(lanternfishes.Count == 4);
        Assert.AreEqual(5, lanternfishes[0].ReproductionTime);
        Assert.AreEqual(2, lanternfishes[1].ReproductionTime);
        Assert.AreEqual(6, lanternfishes[2].ReproductionTime);
        Assert.AreEqual(1, lanternfishes[3].ReproductionTime);
    }
}