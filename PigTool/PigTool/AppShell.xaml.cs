using PigTool.ViewModels;
using PigTool.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PigTool
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AddDataPage), typeof(AddDataPage));
            Routing.RegisterRoute(nameof(ManageDataPage), typeof(ManageDataPage));
        }

    }
}
