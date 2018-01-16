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

namespace Android_App
{
    [Activity(Label = "RegisterActivity")]
    public class SignUpActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            this.RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.SignUp);
        }
    }
}