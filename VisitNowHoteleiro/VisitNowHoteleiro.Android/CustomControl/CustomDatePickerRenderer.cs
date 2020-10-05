using Xamarin.Forms;
using Android.Content;
using Xamarin.Forms.Platform.Android;
using Android.Views;

[assembly: ExportRenderer(typeof(VisitNowHoteleiro.CustomControl.CustomDatePicker), typeof(VisitNowHoteleiro.Droid.CustomControl.CustomDatePickerRenderer))]
namespace VisitNowHoteleiro.Droid.CustomControl
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        public CustomDatePickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
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