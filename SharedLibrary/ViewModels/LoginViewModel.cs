using System;
using MvvmCross.Core.ViewModels;
using SharedLibrary.Services.Interfaces;


namespace SharedLibrary.ViewModels
{
    public class LoginViewModel: MvxViewModel
    {

        readonly IAuthenticationService _authService;

        public LoginViewModel(IAuthenticationService authService)
        {


            _authService = authService;

        }


        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                RaisePropertyChanged(() => Email);
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
                RaisePropertyChanged(() => Password);
            }
        }








        private void Login()
        {

      
            _authService.login(Email, Password);

        }





    }
}
