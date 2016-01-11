
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
	[Activity (Label = "SecondActivity", Theme = "@android:style/Theme.Material.Light.NoActionBar.Fullscreen")]			
	public class SecondActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Second);

			Bundle b = Intent.Extras;

			Button buttonPrev = FindViewById<Button> (Resource.Id.ButtonPrev);		
			buttonPrev.Click += (object sender, EventArgs e) => {
				var intent = new Intent (this, typeof(MainActivity));
//				intent.PutExtras(b);
				StartActivity (intent);
			};

			Button buttonNext = FindViewById<Button> (Resource.Id.ButtonNext);		
			buttonNext.Click += (object sender, EventArgs e) => {
				var intent = new Intent (this, typeof(ThirdActivity));
				// Add current views' data to bundle
				CheckBox chb1 = FindViewById<CheckBox> (Resource.Id.checkBox1);
				CheckBox chb2 = FindViewById<CheckBox> (Resource.Id.checkBox2);
				EditText iban = FindViewById<EditText> (Resource.Id.editTextIban);
				EditText bic = FindViewById<EditText> (Resource.Id.editTextBic);
				EditText euro = FindViewById<EditText> (Resource.Id.editTextEuro);

				b.PutBoolean("chb1", chb1.Checked);
				b.PutBoolean("chb2", chb2.Checked);
				b.PutString("iban", iban.Text);
				b.PutString("bic", bic.Text);
				b.PutString("euro", euro.Text);

				intent.PutExtras(b);
				StartActivity (intent);
			};
		}
	}
}

