using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;


namespace Somuleco.Droid
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_main);

            Button onBoard = FindViewById<Button>(Resource.Id.onBoardingBtn);
            
            Button authenticated = FindViewById<Button>(Resource.Id.authenticateBtn);
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

