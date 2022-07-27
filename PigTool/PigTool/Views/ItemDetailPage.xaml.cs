using PigTool.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PigTool.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}