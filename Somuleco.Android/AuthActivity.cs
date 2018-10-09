using Android.App;
using Android.OS;
using Somuleco.Droid.Resources;

namespace Somuleco.Droid
{
    [Activity(Label = "AuthActivity")]
    public class AuthActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.authentication_main_activity);
        }
    }
}
