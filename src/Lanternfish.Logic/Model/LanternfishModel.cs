namespace Lanternfish.Logic.Model;

public class LanternfishModel
{
    public int Age { get; set; }
    public int ReproductionTime { get; set; }

    public LanternfishModel(int reproductionTime)
    {
        Age = 0;
        ReproductionTime = reproductionTime;
    }

    public override string ToString()
    {
        return $"Age: {Age}, Reproduction Time: {ReproductionTime}";
    }
}
