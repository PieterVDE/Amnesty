
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
	[Activity (Label = "FourthActivity", Theme = "@android:style/Theme.Material.Light.NoActionBar.Fullscreen")]			
	public class FourthActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Fourth);

			Bundle b = Intent.Extras;

			TextView sum_name = FindViewById<TextView> (Resource.Id.SummaryName);
			TextView sum_email = FindViewById<TextView> (Resource.Id.SummaryEmail);
			TextView sum_street1 = FindViewById<TextView> (Resource.Id.SummaryStreet1);
			TextView sum_street2 = FindViewById<TextView> (Resource.Id.SummaryStreet2);
			TextView sum_postalcode = FindViewById<TextView> (Resource.Id.SummaryPostalcode);
			TextView sum_city = FindViewById<TextView> (Resource.Id.SummaryCity);
			TextView sum_chb1 = FindViewById<TextView> (Resource.Id.SummaryChb1);
			TextView sum_chb2 = FindViewById<TextView> (Resource.Id.SummaryChb2);
			TextView sum_iban = FindViewById<TextView> (Resource.Id.SummaryIban);
			TextView sum_bic = FindViewById<TextView> (Resource.Id.SummaryBic);
			TextView sum_euro = FindViewById<TextView> (Resource.Id.SummaryEuro);
			TextView sum_chb3 = FindViewById<TextView> (Resource.Id.SummaryChb3);

			sum_name.Text = b.GetString ("name");
			sum_email.Text = b.GetString ("email");
			sum_street1.Text = b.GetString ("street1");
			sum_street2.Text = b.GetString ("street2");
			sum_postalcode.Text = b.GetString ("postalcode");
			sum_city.Text = b.GetString ("city");
			sum_chb1.Text = (b.GetBoolean("chb1") == true? "Aangevinkt" : "Niet aangevinkt");
			sum_chb2.Text = (b.GetBoolean("chb2") == true? "Aangevinkt" : "Niet aangevinkt");
			sum_iban.Text = b.GetString ("iban");
			sum_bic.Text = b.GetString ("bic");
			sum_euro.Text = b.GetString ("euro");
			sum_chb3.Text = (b.GetBoolean("confirm") == true? "Aangevinkt" : "Niet aangevinkt");

			Button buttonPrev = FindViewById<Button> (Resource.Id.ButtonPrev);		
			buttonPrev.Click += (object sender, EventArgs e) => {
				var intent = new Intent (this, typeof(ThirdActivity));
				StartActivity (intent);
			};

			Button buttonNext = FindViewById<Button> (Resource.Id.ButtonNext);		
			buttonNext.Click += (object sender, EventArgs e) => {
//				var intent = new Intent (this, typeof(FourthActivity));
//				StartActivity (intent);
			};
		}
	}
}

