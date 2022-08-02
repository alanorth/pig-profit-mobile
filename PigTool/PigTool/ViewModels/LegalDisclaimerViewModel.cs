using PigTool.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PigTool.ViewModels
{
    public class LegalDisclaimerViewModel : BaseViewModel
    {
        INavigation _Nav;
        public bool ButtonEnable { get; set; }

        public Command ProceedClicked { get; }


        public LegalDisclaimerViewModel(INavigation Nav)
        {
            _Nav = Nav;
            ButtonEnable = false;
            ProceedClicked = new Command(ProceedClickAsync);
        }
        public void DisclaimerAcknowlegde()
        {
            ButtonEnable = !ButtonEnable;
        }

        private void ProceedClickAsync()
        {
            _Nav.PushModalAsync(new AppShell());
        }
    }
}
