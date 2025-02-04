namespace CSharpBevezeto;

class Program
{
    static void Main(string[] args)
    {
        Ember ember = new Ember();
        
        Random rnd = new Random();
        int magassag = rnd.Next(150, 190);
        double suly = rnd.Next(40, 100);
        ember.Peldany(suly, magassag);

        Console.WriteLine(ember.ToString());
        double tti = ember.TestTomegIndex(suly, magassag);
        Console.WriteLine(tti);
        Console.WriteLine(ember.NormalTTI(tti));
    }
}