﻿using System;

sealed class TwoDimention: BaseArr
{
    private int[,] _myArr;

    public TwoDimention(int depth, int length, bool userFill = false)
    {
        FillArr(depth, length, userFill);
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

    public override double GetAvg
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
            return sum / _myArr.Length;
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

    public void FillArr(int depth, int length, bool userFill = false)
    {
        _myArr = new int[depth, length];
        if (userFill)
        {
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
