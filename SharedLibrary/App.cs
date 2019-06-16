using System;
using MvvmCross;

using SharedLibrary.ViewModels;
using SharedLibrary.Services;
using SharedLibrary.Services.Interfaces;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace SharedLibrary
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {

            CreatableTypes()
               .EndingWith("Service")
               .AsInterfaces()
               .RegisterAsLazySingleton();

         
        }
    }
}
