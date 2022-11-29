using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views.Popups
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoadingOverlay : PopupPage
	{
		public LoadingOverlay()
		{
			InitializeComponent ();
			CloseWhenBackgroundIsClicked = false;
		}

		protected override bool OnBackButtonPressed()
		{
			return true; // Disable back button
		}
	}
}