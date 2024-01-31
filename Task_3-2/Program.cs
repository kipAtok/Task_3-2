using System;

class Program
{
    public static void Main(string[] args)
    {
        ArrBase[] testBase = new ArrBase[3];

        testBase[0] = new OneDimention(false);
        testBase[1] = new TwoDimention(false);
        testBase[2] = new LadderArr(false);

        for (int i = 0; i < 3; i++)
        {
            testBase[i].PrintArr();
            Console.WriteLine($"Avg: {testBase[i].Avg}");
            testBase[i].FillArr(true);
            testBase[i].PrintArr();
        }
    }
}