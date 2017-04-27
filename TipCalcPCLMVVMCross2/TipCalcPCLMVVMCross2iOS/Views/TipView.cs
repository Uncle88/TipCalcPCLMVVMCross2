using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using TipCalcPCLMVVMCross2.ViewModels;
using UIKit;

namespace TipCalcPCLMVVMCross2iOS.Views
{
    public partial class TipView : MvxViewController
    {
        public new TipViewModel ViewModel
        {
            get { return (TipViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public TipView() : base("TipView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.CreateBinding(TipLabel).To((TipViewModel vm) => vm.Tip).Apply();
            this.CreateBinding(SubTotalTextField).To((TipViewModel vm) => vm.SubTotal).Apply();
            this.CreateBinding(GenerositySlider).To((TipViewModel vm) => vm.Generosity).Apply();
        }
    }
}

