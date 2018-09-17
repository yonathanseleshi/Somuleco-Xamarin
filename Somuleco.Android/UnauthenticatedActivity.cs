
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Somuleco.Android.Fragments;

namespace Somuleco.Android
{
    [Activity(Label = "UnauthenticatedActivity")]
    public class UnauthenticatedActivity : FragmentActivity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.unauthenticated_main_activity);

            var fragments = new Fragment[]{

                new LandingFragment(),
                new UnauthExploreFragment(),
                new UnauthLibraryFragment()


            };

            var titles = CharSequence.ArrayFromStringArray(new[] { "Landing", "Explore", "Library" });

            ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.unauth_viewPager);
            var tabLayout = FindViewById<TabLayout>(Resource.Id.tabLayout);

            var adapter = new UnauthenticatedAdapter(SupportFragmentManager, fragments, titles);

            viewPager.Adapter = adapter;

            tabLayout.SetupWithViewPager(viewPager);


        }

     
    }
}
