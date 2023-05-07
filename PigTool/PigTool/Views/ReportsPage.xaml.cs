using PigTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PigTool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportsPage : TabbedPage
    {
        public ReportsPage()
        {
            try { 
            InitializeComponent();
                //BindingContext = new LegalDisclaimerViewModel(Navigation);
            }
            catch(Exception ex) 
            { 
            }
        }
    }
}