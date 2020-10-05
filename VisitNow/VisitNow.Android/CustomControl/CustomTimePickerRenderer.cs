using Xamarin.Forms;
using Android.Content;
using Xamarin.Forms.Platform.Android;
using Android.Views;

[assembly: ExportRenderer(typeof(VisitNow.CustomControl.CustomTimePicker), typeof(VisitNow.Droid.CustomControl.CustomTimePickerRenderer))]
namespace VisitNow.Droid.CustomControl
{
    public class CustomTimePickerRenderer : TimePickerRenderer
    {
        public CustomTimePickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.edit_text_selector);
                Control.Gravity = GravityFlags.CenterVertical;
            }
        }
    }
}