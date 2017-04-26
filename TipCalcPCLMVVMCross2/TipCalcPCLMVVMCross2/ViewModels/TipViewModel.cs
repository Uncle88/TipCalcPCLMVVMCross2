using MvvmCross.Core.ViewModels;
using TipCalcPCLMVVMCross2.Services;


namespace TipCalcPCLMVVMCross2.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        private readonly ICalculation _calculation;
        public TipViewModel(ICalculation calculation)
        {
            _calculation = calculation;
        }

        public override void Start()
        {
            _subTotal = 100;
            _generosity = 10;
            Recalculate();
            base.Start();
        }

        private double _subTotal;
        private int _generosity;
        private double _tip;

        public double SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; RaisePropertyChanged(() => SubTotal); Recalculate(); }
        }

        public int Generosity
        {
            get { return _generosity; }
            set { _generosity = value; RaisePropertyChanged(() => Generosity); Recalculate(); }
        }

        public double Tip
        {
            get { return _tip; }
            private set { _tip = value; RaisePropertyChanged(() => Tip); }
        }

        private void Recalculate()
        {
            Tip = _calculation.TipAmount(SubTotal, Generosity);
        }
    }
}
