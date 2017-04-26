using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using TipCalcPCLMVVMCross2.Services;
using TipCalcPCLMVVMCross2.ViewModels;

namespace TipCalcPCLMVVMCross2
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculation, Calculation>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
        }
    }
}
