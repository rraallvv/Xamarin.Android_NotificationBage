using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Com.Nex3z.Notificationbadge;

namespace test
{
	[Activity(Label = "test", MainLauncher = true, Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
	public class MainActivity : AppCompatActivity
	{
		NotificationBadge mBadge;
		int count = 0;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			mBadge = FindViewById<NotificationBadge>(Resource.Id.badge);
			FindViewById<Button>(Resource.Id.btnIncrease).Click += delegate {
				mBadge.SetNumber(++count);
			};
			FindViewById<Button>(Resource.Id.btnMany).Click += delegate {
				mBadge.SetNumber(99);
			};
			FindViewById<Button>(Resource.Id.btnClear).Click += delegate {
				mBadge.SetNumber(0);
			};
		}
	}
}

