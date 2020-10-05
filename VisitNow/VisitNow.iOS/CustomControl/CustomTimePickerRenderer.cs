using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(VisitNow.CustomControl.CustomTimePicker), typeof(VisitNow.iOS.CustomControl.CustomTimePickerRenderer))]
namespace VisitNow.iOS.CustomControl
{
    class CustomTimePickerRenderer : TimePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

            }
        }
    }
}