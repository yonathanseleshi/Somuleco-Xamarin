
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.OS;

using Android.Views;


namespace Somuleco.Droid
{
    public class LandingFragment : Android.Support.V4.App.Fragment
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
           

            return inflater.Inflate(Resource.Layout.unauthenticated_landing_fragment, container, true);
        }
    }
}
