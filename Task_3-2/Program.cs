using System;

class Program
{
    public static void Main(string[] args)
    {
        ArrBase[] testBase = new ArrBase[3];

        testBase[0] = new OneDimention(false);
        testBase[1] = new TwoDimention(false);
        testBase[2] = new LadderArr(false);

        foreach (var array in testBase)
        {
            odTest.PrintArr();
            Console.WriteLine($"Avg: {odTest.Avg}");
            odTest.FillArr(true);
            odTest.PrintArr();
        }
    }
}