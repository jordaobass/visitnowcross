using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisitNow.ViewTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingView : ContentView
    {
        public LoadingView()
        {
            InitializeComponent();
        }
    }
}