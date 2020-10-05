using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(VisitNow.CustomControl.CustomPicker), typeof(VisitNow.iOS.CustomControl.CustomPickerRenderer))]
namespace VisitNow.iOS.CustomControl
{
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

            }
        }
    }
}