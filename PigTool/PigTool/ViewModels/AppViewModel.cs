using PigTool.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using SQLLiteDbContext;
using Microsoft.EntityFrameworkCore;

namespace PigTool.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        private bool showRegister;

        public bool ShowRegister { get => showRegister; set => SetProperty(ref showRegister, value); }
        public AppViewModel()
        {
            GetUsers();
            
        }

        private async void GetUsers()
        {
            using (DbSQLLiteContext db = new DbSQLLiteContext())
            {
                ShowRegister = await db.UserInfos.CountAsync() > 0 ? false : true;
            }
        }
    }
}
