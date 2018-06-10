
using Android.App;
using Android.OS;
using Android.Views;

namespace com.datacoper.appprodutor.Activities
{
    public class BaseActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.IndeterminateProgress);

        }
    }
}