using System;
using MvvmCross;

using SharedLibrary.ViewModels;
using SharedLibrary.Services;
using SharedLibrary.Services.Interfaces;
using MvvmCross.Platform;
using MvvmCross.Core.ViewModels;

namespace SharedLibrary
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {


            Mvx.RegisterType<IAuthenticationService, AuthenticationService>();

         
        }
    }
}
