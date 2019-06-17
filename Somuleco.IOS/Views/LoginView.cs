using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using SharedLibrary.ViewModels;

using UIKit;

namespace Somuleco.IOS.Views
{
    public partial class LoginView : MvxViewController
    {
        public LoginView() : base("LoginView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<LoginView, LoginViewModel>();
            set.Bind(LoginEmail).To(vm => vm.Email);
            set.Bind(LoginPassword).To(vm => vm.Password);
            set.Bind(LoginBtn).To(vm => vm.LoginCommand);
            set.Bind(SignupBtn).To(vm => vm.GoToSignupCommand);
            set.Bind(LoginBtn).To(vm => vm.CancelCommand);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

