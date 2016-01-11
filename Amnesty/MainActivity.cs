using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;
using Android.Views;
using Android.Views.InputMethods;
using System.Collections.Generic;

namespace Amnesty
{
	[Activity (Label = "Amnesty", Icon = "@mipmap/icon", Theme = "@android:style/Theme.Material.Light.NoActionBar.Fullscreen")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			Button buttonNext = FindViewById<Button> (Resource.Id.ButtonNext);		
			buttonNext.Click += (object sender, EventArgs e) => {
				// Get all data & collect in an array
				Bundle data = new Bundle();

				EditText Name = FindViewById<EditText> (Resource.Id.editTextName);
				EditText Email = FindViewById<EditText> (Resource.Id.editTextEmail);
				EditText Street1 = FindViewById<EditText> (Resource.Id.editTextStreet1);
				EditText Street2 = FindViewById<EditText> (Resource.Id.editTextStreet2);
				EditText PostalCode = FindViewById<EditText> (Resource.Id.editTextPostalcode);
				EditText City = FindViewById<EditText> (Resource.Id.editTextCity);

				data.PutString("name", Name.Text);
				data.PutString("email", Email.Text);
				data.PutString("street1", Street1.Text);
				data.PutString("street2", Street2.Text);
				data.PutString("postalcode", PostalCode.Text);
				data.PutString("city", City.Text);

				var intent = new Intent (this, typeof(SecondActivity));
				// Send all data with intent
				intent.PutExtras (data);
				StartActivity (intent);
			};
		}
	}
}