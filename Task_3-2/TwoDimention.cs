using System;

sealed class TwoDimention: BaseArr
{
    private int[,] _myArr;

    public TwoDimention(bool userFill = false)
    {
        FillArr(userFill);
    }

    public int this[int index1, int index2]
    {
        get
        {
            return _myArr[index1, index2];
        }
        set
        {
            _myArr[index1, index2] = value;
        }
    }

    public override double Avg
    {
        get
        {
            int sum = 0;
            for (int i = 0; i < _myArr.GetLength(0); i++)
            {
                for (int j = 0; j < _myArr.GetLength(1); j++)
                {
                    sum += _myArr[i, j];
                }
            }
            return sum / (double) _myArr.Length;
        }
    }

    public override void PrintArr()
    {
        Console.WriteLine("Your two dimention array: ");
        for (int i = 0; i < _myArr.GetLength(0); i++)
        {
            for (int j = 0; j < _myArr.GetLength(1); j++)
            {
                Console.Write(_myArr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public override void FillArr(bool userFill = false)
    {
        if (userFill)
        {
            Console.Write("Enter the depth of the array: ");
            int depth = int.Parse(Console.ReadLine());
            Console.Write("Enter the length of every nested array: ");
            int length = int.Parse(Console.ReadLine());
            _myArr = new int[depth, length];
            for (int i = 0; i < depth; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write($"Enter a value of {j + 1} element of {i + 1} line: ");
                    _myArr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        else
        {
            Random rnd = new Random();
            int depth = rnd.Next(3, 10);
            int length = rnd.Next(3, 10);
            _myArr = new int[depth, length];
            for (int i = 0; i < depth; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    _myArr[i, j] = rnd.Next(1, 10);
                }
            }
        }
    }
}
