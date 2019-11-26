using System;

using Android.App;
using Android.OS;

namespace PosiChange
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        public void OpenScanner (object sender, EventArgs e )
        {
            
        }
    }
}