using Xamarin.Forms;
using Android.Content;
using Xamarin.Forms.Platform.Android;
using Android.Views;

[assembly: ExportRenderer(typeof(VisitNowHoteleiro.CustomControl.CustomTimePicker), typeof(VisitNowHoteleiro.Droid.CustomControl.CustomTimePickerRenderer))]
namespace VisitNowHoteleiro.Droid.CustomControl
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