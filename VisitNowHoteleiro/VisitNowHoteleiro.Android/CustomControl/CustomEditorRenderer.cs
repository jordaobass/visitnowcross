using Xamarin.Forms;
using Android.Content;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(VisitNowHoteleiro.CustomControl.CustomEditor), typeof(VisitNowHoteleiro.Droid.CustomControl.CustomEditorRenderer))]
namespace VisitNowHoteleiro.Droid.CustomControl
{
    public class CustomEditorRenderer : EditorRenderer
    {
        public CustomEditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.edit_text_selector);
                //Control.Gravity = GravityFlags.CenterVertical;
            }
        }
    }
}