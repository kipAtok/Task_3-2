using System;

abstract class ArrBase
{
    public abstract double Avg { get; }

    public abstract void PrintArr();

    public abstract void FillArr(bool userFill = false);

    protected abstract void ManualFill();

    protected abstract void AutoFill();
}
