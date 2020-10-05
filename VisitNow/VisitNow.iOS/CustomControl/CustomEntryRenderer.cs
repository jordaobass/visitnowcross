using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(VisitNow.CustomControl.CustomEntry), typeof(VisitNow.iOS.CustomControl.CustomEntryRenderer))]
namespace VisitNow.iOS.CustomControl
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

            }
        }
    }
}