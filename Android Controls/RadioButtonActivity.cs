using Android.App;
using Android.OS;

namespace Android_Controls
{
    [Activity(Label = "RadioButton")]
    public class RadioButtonActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.RadioButton);
        }
    }
}