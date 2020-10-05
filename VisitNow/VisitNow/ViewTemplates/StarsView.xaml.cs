using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNow.ViewTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarsView : ContentView
    {
        #region Bindable Property
        public static readonly BindableProperty RateProperty = BindableProperty.Create(
            "Rate", // the name of the bindable property
            typeof(int), // the bindable property type
            typeof(StarsView), // the parent object type
            null // the default value for the property
        );

        public int Rate
        {
            get => (int)GetValue(RateProperty);
            set => SetValue(RateProperty, value);
        }
        #endregion

        public StarsView()
        {
            InitializeComponent();
        }

        public void DisplayRating(int rate)
        {
            for (int i = 0; i < rate; i++)
            {
                Label currentlabelName = Content.FindByName<Label>(string.Concat("Star", i + 1));
                currentlabelName.TextColor = Color.DarkGoldenrod;
            }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            DisplayRating(Rate);
        }
    }
}