using MvvmCross.Platforms.Ios.Core;
using NPlusOneMvvmCross.Core;

namespace NPlusOneMvvmCross.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
        }

        protected override void InitializeSingletonCache()
        {
            base.InitializeSingletonCache();
        }


        //protected override void InitializeFirstChance()
        //{
        //    base.InitializeFirstChance();

        //    Mvx.IoCProvider.RegisterType<IUrlOpener, UrlOpener>();
        //    Mvx.IoCProvider.RegisterType<ISettingsOpener, SettingsOpener>();
        //}

        //protected override void InitializeSingletonCache()
        //{
        //    base.InitializeSingletonCache();

        //    // Call static initializers first
        //    ReSoundSDKIOSSetup.InitializeSingletonCache(Runtime.Arch == Arch.DEVICE, false);

        //    // Services that needs to be created now in order to run throughout the app
        //    Mvx.IoCProvider.ConstructAndRegisterSingleton<IReSoundSDKService, ReSoundSDKService>();
        //}

        //protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        //{
        //    base.FillTargetFactories(registry);
        //    registry.RegisterUIButtonBindingFactory();
        //}
    }
}