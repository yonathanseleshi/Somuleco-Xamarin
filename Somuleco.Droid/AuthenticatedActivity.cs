
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;


namespace Somuleco.Droid
{
    [Activity(Label = "AuthenticatedActivity")]
    public class AuthenticatedActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.authenticated_main_activity);

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.authToolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Somuleco";
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu_white_24dp);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            var menu = FindViewById<Android.Support.Design.Widget.NavigationView>(Resource.Id.drawerNavMenu);
            menu.NavigationItemSelected += OnMenuItemSelected;

            Navigate(new LessonsFragment());
        }


        


        public override bool OnOptionsItemSelected(IMenuItem item){

            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    var drawerLayout = FindViewById<Android.Support.V4.Widget.DrawerLayout>(Resource.Id.authenticatedDrawer);
                    drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
                    break;
            }
            return true;

        }


        void OnMenuItemSelected(object sender, Android.Support.Design.Widget.NavigationView.NavigationItemSelectedEventArgs e)
        {
            switch (e.MenuItem.ItemId)
            {
                case Resource.Id.lessonsFeed: Navigate(new LessonsFragment()); break;
                case Resource.Id.socialFeed: Navigate(new SocialFragment()); break;
                case Resource.Id.library: Navigate(new AuthLibraryFragment()); break;
                case Resource.Id.wallet: Navigate(new WalletFragment()); break;
                case Resource.Id.learningProfile: Navigate(new LearningProfileFragment()); break;
            }

            e.MenuItem.SetChecked(true);

            var drawerLayout = FindViewById<Android.Support.V4.Widget.DrawerLayout>(Resource.Id.authenticatedDrawer);
            drawerLayout.CloseDrawer(Android.Support.V4.View.GravityCompat.Start);
        }

        void Navigate(Android.Support.V4.App.Fragment fragment)
        {
            var transaction = base.SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.drawerContent, fragment);
            transaction.Commit();
        }
    }
}
