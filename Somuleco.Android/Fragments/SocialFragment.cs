using Android.OS;
using Android.Views;
using Somuleco.Droid.Resources;
using Fragment = Android.Support.V4.App.Fragment;

namespace Somuleco.Droid.Fragments
{
    public class SocialFragment : Fragment
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

            return inflater.Inflate(Resource.Layout.social_fragment, container, savedInstanceState);
        }
    }
}
