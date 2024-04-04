using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using AndroidX.AppCompat.App;

namespace PigTool.Droid
{
    [Activity(Label = "SplashActivity", Theme = "@style/MyTheme.Splash", MainLauncher = false, NoHistory = true)]
    public class SplashActivity2 : Activity
    {
        static readonly string TAG = "X:" + typeof(SplashActivity).Name;

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.splash_screen);
        }

        // Launches the startup task
        /*protected override void OnResume()
        {
            base.OnResume();
           
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        // Simulates background work that happens behind the splash screen
        /* async void SimulateStartup()
        {
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }*/
    }
}