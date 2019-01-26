
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

namespace Somuleco.Droid
{
    [Activity(Label = "AuthActivity")]
    public class AuthActivity : Activity
    {

        //AuthActivity
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.authentication_main_activity);
        }
    }
}
