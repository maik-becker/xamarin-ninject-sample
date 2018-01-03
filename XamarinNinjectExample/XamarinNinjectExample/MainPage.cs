using Ninject;
using Xamarin.Forms;

namespace XamarinNinjectExample
{
    public class MainPage : ContentPage
    {
        private readonly ICompass _compass;

        [Inject]
        public MainPage(ICompass compass)
        {
            _compass = compass;

            var content = new Label();
            _compass.CompassUpdated += degrees => content.Text = degrees.ToString();
            Content = content;
        }
    }
}