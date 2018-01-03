using Ninject;
using Xamarin.Forms;

namespace XamarinNinjectExample
{
    public class NinjectExampleApp : Application
    {
        [Inject]
        public NinjectExampleApp(MainPage mainPage)
        {
            MainPage = mainPage;
        }
    }
}