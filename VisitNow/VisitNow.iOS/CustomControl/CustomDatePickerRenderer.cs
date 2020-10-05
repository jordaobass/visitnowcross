using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(VisitNow.CustomControl.CustomDatePicker), typeof(VisitNow.iOS.CustomControl.CustomDatePickerRenderer))]
namespace VisitNow.iOS.CustomControl
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

            }
        }
    }
}