using System;
using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using SharedLibrary;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Android.Widget;
using Android.Views;
using Android.Content;
using Android.OS;

namespace Somuleco.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class SplashScreen : MvxSplashScreenAppCompatActivity<MvxAppCompatSetup<App>, App>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.main_activity);

            AppCenter.Start("ad0903eb-1715-4872-94e6-1d5c3477a0d3",
                   typeof(Analytics), typeof(Crashes));


            Button onBoard = FindViewById<Button>(Resource.Id.onBoardingBtn);

            Button authenticated = FindViewById<Button>(Resource.Id.authenticatedBtn);
            Button unauth = FindViewById<Button>(Resource.Id.unauthenticatedBtn);
            Button auth = FindViewById<Button>(Resource.Id.authenticateBtn);



            onBoard.Click += (sender, e) =>
            {

                Intent intent = new Intent(this, typeof(OnboardingActivity));
                StartActivity(intent);

            };

            authenticated.Click += (sender, e) =>
            {

                Intent intent = new Intent(this, typeof(AuthenticatedActivity));
                StartActivity(intent);

            };

            unauth.Click += (sender, e) =>
            {

                Intent intent = new Intent(this, typeof(UnauthenticatedActivity));
                StartActivity(intent);

            };

            auth.Click += (sender, e) =>
            {

                Intent intent = new Intent(this, typeof(AuthActivity));
                StartActivity(intent);

            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}
