
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

namespace Amnesty
{
	[Activity (Label = "ThirdActivity", Theme = "@android:style/Theme.Material.Light.NoActionBar.Fullscreen")]			
	public class ThirdActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Third);

			Bundle b = Intent.Extras;

			Button buttonPrev = FindViewById<Button> (Resource.Id.ButtonPrev);		
			buttonPrev.Click += (object sender, EventArgs e) => {
				var intent = new Intent (this, typeof(SecondActivity));
//				intent.PutExtras(b);
				StartActivity (intent);
			};

			Button buttonNext = FindViewById<Button> (Resource.Id.ButtonNext);		
			buttonNext.Click += (object sender, EventArgs e) => {
				var intent = new Intent (this, typeof(FourthActivity));
				// Add current views' data to bundle
				CheckBox confirm = FindViewById<CheckBox> (Resource.Id.CheckBox1);

				b.PutBoolean("confirm", confirm.Checked);

				intent.PutExtras(b);
				StartActivity (intent);
			};

//			CheckBox chb = (CheckBox)FindViewById(Resource.Id.CheckBox1);
//			chb.setOnCheckedChangeListener(new OnCheckedChangeListener()
//				{
//					public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
//						if (isChecked) {
//							buttonNext.SetEnabled(true);
//						} else {
//							buttonNext.SetEnabled(false);
//						}
//					}
//				});
//			}
		}
	}
}