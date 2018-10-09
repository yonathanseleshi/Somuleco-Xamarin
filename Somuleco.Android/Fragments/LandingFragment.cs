using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Somuleco.Droid.Resources;

namespace Somuleco.Droid.Fragments
{
    public class LandingFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return inflater.Inflate(Resource.Layout.unauthenticated_landing_fragment, container, savedInstanceState);
        }
    }
}
