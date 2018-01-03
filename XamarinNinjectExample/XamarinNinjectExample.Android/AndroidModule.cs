using Ninject.Modules;

namespace XamarinNinjectExample.Droid
{
    public class AndroidModule : NinjectModule
    {
        public override void Load()
        {
            Bind<AppContextWrapper>().ToSelf().InSingletonScope();
            Bind<ICompass>().To<AndroidCompass>().InSingletonScope();
        }
    }
}