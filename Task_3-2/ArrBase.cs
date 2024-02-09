using System;

abstract class ArrBase
{
    public abstract double Avg { get; }

    public abstract void PrintArr();

    public virtual void FillArr(bool userFill)
    {
        if (userFill)
        {
            ManualFill();
        }
        else
        {
            AutoFill();
        }
    }

    protected abstract void ManualFill();

    protected abstract void AutoFill();
}
