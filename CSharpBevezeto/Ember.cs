namespace CSharpBevezeto;

public class Ember
{
    private double testSuly { get; set; }
    private int testMagassag { get; set; }

    public void Peldany(double suly, int magassag)
    {
        testSuly = suly;
        testMagassag = magassag;
    }

    public override string ToString()
    {
        return $"Test Súly: {testSuly}, Magasság: {testMagassag}";
    }

    public double TestTomegIndex(double suly, int magassag)
    {
        double mgs = magassag / 100.0;
        double tti = suly / (mgs * mgs);
        return Math.Round(tti, 2);
    }

    public bool NormalTTI(double tti)
    {
        if (tti >= 18.5 && tti < 25)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}