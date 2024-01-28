using System;

class Program
{
    public static void Main(string[] args)
    {
        var odTest = new OneDimention(false);

        odTest.PrintArr();
        odTest[2] = 69;
        odTest.PrintArr();
        Console.WriteLine($"Avg: {odTest.Avg}");
        odTest.FillArr(true);
        odTest.PrintArr();

        Console.WriteLine("---------------");

        var tdTest = new TwoDimention(false);

        tdTest.PrintArr();
        tdTest[2, 0] = 69;
        tdTest.PrintArr();
        Console.WriteLine($"Avg: {tdTest.Avg}");
        tdTest.FillArr(true);
        tdTest.PrintArr();

        Console.WriteLine("---------------");

        var ldTest = new LadderArr(false);

        ldTest.PrintArr();
        ldTest[2, 0] = 69;
        ldTest.PrintArr();
        Console.WriteLine($"Avg: {ldTest.Avg}");
        ldTest.FillArr(true);
        ldTest.PrintArr();
    }
}