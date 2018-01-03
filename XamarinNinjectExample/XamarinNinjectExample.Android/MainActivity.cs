using Android.App;
using Android.Content.PM;
using Android.OS;
using Ninject;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace XamarinNinjectExample.Droid
{
    [Activity(Label = "XamarinNinjectExample", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        private readonly StandardKernel _kernel = new StandardKernel(
            new CommonModule(),
            new AndroidModule()
        );

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            _kernel.Get<AppContextWrapper>().UseContext(this);

            LoadApplication(_kernel.Get<NinjectExampleApp>());
        }

        protected override void OnPause()
        {
            base.OnPause();

            _kernel.Get<ICompass>().Pause();
        }

        protected override void OnResume()
        {
            base.OnResume();

            _kernel.Get<ICompass>().Resume();
        }
    }
}