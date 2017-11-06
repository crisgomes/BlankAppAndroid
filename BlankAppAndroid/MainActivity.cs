using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace BlankAppAndroid
{
    [Activity(Label = "BlankAppAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            MobileCenter.Start("054072dd-117a-45b4-85cc-7a3595c1d8ac",
                   typeof(Analytics), typeof(Crashes));

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

