using System;
using Ninject.Modules;

namespace XamarinNinjectExample.iOS
{
    public class IosModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICompass>().To<IosCompass>().InSingletonScope();
        }
    }
}