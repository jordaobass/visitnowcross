using Xamarin.Forms;
using Android.Content;
using Xamarin.Forms.Platform.Android;
using Android.Views;

[assembly: ExportRenderer(typeof(VisitNow.CustomControl.CustomEntry), typeof(VisitNow.Droid.CustomControl.CustomEntryRenderer))]
namespace VisitNow.Droid.CustomControl
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
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