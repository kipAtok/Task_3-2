using System;

abstract class BaseArr
{
    public abstract double Avg { get; }

    public abstract void PrintArr();

    public abstract void FillArr(bool userFill = false);
}
