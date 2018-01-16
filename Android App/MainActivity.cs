using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Android_App
{
    [Activity(Label = "Android_App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.RequestWindowFeature(WindowFeatures.NoTitle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button_SignIn = FindViewById<Button>(Resource.Id.button_SignIn);
            Button button_Register = FindViewById<Button>(Resource.Id.button_Register);

            button_SignIn.Click += delegate { button_SignIn.Text = string.Format("{0} clicks!", count++); };
            button_Register.Click += (s, e) =>
            {
                Intent registerActivity = new Intent(this, typeof(SignUpActivity));
                StartActivity(registerActivity);
            };
        }

        
    }
}

