using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            if (ButtonEnable)
            {
                //_Nav.PushAsync(new RegistrationPage("Token", "Email"));
                _Nav.PushAsync(new WebAuthenticatorPage());
            }

            if (1 == 2)
            {
                _Nav.PushAsync(new WebAuthenticatorPage());
                
            }
        }
    }
}
