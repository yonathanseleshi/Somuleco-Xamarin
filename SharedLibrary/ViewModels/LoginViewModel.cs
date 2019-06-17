using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using SharedLibrary.Services.Interfaces;


namespace SharedLibrary.ViewModels
{
    public class LoginViewModel: MvxViewModel
    {

        readonly IAuthenticationService _authService;
        private readonly IMvxNavigationService _navigationService;
        public SignupViewModel signupViewModel;

        public LoginViewModel(IAuthenticationService authService, IMvxNavigationService navigationService)
        {


            _authService = authService;
            _navigationService = navigationService;
            

        }




        public IMvxCommand LoginCommand => new MvxCommand(Login);
        public IMvxCommand GoToSignupCommand => new MvxCommand(GoToSignup);
        public IMvxCommand CancelCommand => new MvxCommand(CancelLogin);

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                SetProperty(ref email, value);
            }
        }



        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                SetProperty(ref password, value);
            }
        }








        private void Login()
        {

      
            _authService.login(Email, Password);

        }




        public void GoToSignup()
        {

            _navigationService.Navigate<SignupViewModel>();
           

        }



        private void CancelLogin()
        {


            

        }


    }
}
