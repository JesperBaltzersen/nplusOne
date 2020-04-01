using System;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using NPlusOneMvvmCross.Core.ViewModels;

namespace NPlusOneMvvmCross.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TodayViewModel>();
        }
    }
}
