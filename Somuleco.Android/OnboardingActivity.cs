using Android.App;
using Android.OS;
using Somuleco.Droid.Resources;

namespace Somuleco.Droid
{
    [Activity(Label = "OnboardingActivity")]
    public class OnboardingActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.onboarding_main_activity);

            // Create your application here
        }
    }
}
