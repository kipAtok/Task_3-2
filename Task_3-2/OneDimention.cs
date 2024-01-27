using System;

sealed class OneDimention: BaseArr
{
    private int[] _myArr;

    public OneDimention(int length, bool userFill = false)
    {
        FillArr(length, userFill);
    }

    public int this[int index]
    {
        get {  return _myArr[index]; }
        set { _myArr[index] = value; }
    }

    public override double GetAvg
    {
        get
        {
            int sum = 0;
            foreach (int num in _myArr)
            {
                sum += num;
            }
            return sum / _myArr.Length;
        }
    }

    public override void PrintArr()
    {
        Console.WriteLine("Your array: ");
        foreach (int i in _myArr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public void FillArr(int length, bool userFill = false)
    {
        _myArr = new int[length];
        if (userFill)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter a value of {i + 1} element: ");
                _myArr[i] = int.Parse(Console.ReadLine());
            }
        }
        else
        {
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                _myArr[i] = rnd.Next(1, 10);
            }
        }
    }
}