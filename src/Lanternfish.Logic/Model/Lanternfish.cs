namespace Lanternfish.Logic;
public class Lanternfish
{
    public int Age { get; set; }
    public int ReproductionTime { get; set; }

    public Lanternfish(int reproductionTime)
    {
        Age = 0;
        ReproductionTime = reproductionTime;
    }
}
