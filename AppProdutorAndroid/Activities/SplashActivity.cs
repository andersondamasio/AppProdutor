
using Android.App;
using Android.Content;
using Android.OS;
using com.datacoper.appprodutor.Activities.Login;

namespace com.datacoper.appprodutor.Activities
{
    [Activity(Label = "App do Produtor", MainLauncher = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Splash);

            Intent intent = new Intent(this, typeof(LoginActivity));
            intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
            StartActivity(intent);
            Finish();
        }
    }
}