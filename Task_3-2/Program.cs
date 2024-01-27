using System;

class Program
{
    public void Main(string[] args)
    {
        var odTest = new OneDimention(5, false);
        
        odTest.PrintArr();
        odTest[3] = 69;
        odTest.PrintArr();
        Console.WriteLine($"Avg: {odTest.GetAvg}");
        odTest.FillArr(4, true);
        odTest.PrintArr();

        Console.WriteLine("---------------");

        var tdTest = new TwoDimention(5, 3, false);

        tdTest.PrintArr();
        tdTest[3, 0] = 69;
        tdTest.PrintArr();
        Console.WriteLine($"Avg: {tdTest.GetAvg}");
        tdTest.FillArr(4, 2, true);
        tdTest.PrintArr();

        Console.WriteLine("---------------");

        var ldTest = new LadderArr(5, false);

        ldTest.PrintArr();
        ldTest[3, 0] = 69;
        ldTest.PrintArr();
        Console.WriteLine($"Avg: {ldTest.GetAvg}");
        ldTest.FillArr(4, true);
        ldTest.PrintArr();
    }
}