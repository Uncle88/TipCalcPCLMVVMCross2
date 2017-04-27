// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TipCalcPCLMVVMCross2iOS.Views
{
	[Register ("TipView")]
	partial class TipView
	{
		[Outlet]
		UIKit.UISlider GenerositySlider { get; set; }

		[Outlet]
		UIKit.UITextField SubTotalTextField { get; set; }

		[Outlet]
		UIKit.UILabel TipLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SubTotalTextField != null) {
				SubTotalTextField.Dispose ();
				SubTotalTextField = null;
			}

			if (GenerositySlider != null) {
				GenerositySlider.Dispose ();
				GenerositySlider = null;
			}

			if (TipLabel != null) {
				TipLabel.Dispose ();
				TipLabel = null;
			}
		}
	}
}
