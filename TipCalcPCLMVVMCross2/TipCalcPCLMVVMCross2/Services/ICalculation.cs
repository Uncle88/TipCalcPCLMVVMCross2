using System;
namespace TipCalcPCLMVVMCross2.Services
{
    public interface ICalculation
    {
        double TipAmount(double subTotal, int generosity);
    }
}
