using System;
using MvvmCross.Core.ViewModels;
using SharedLibrary.Services.Interfaces;


namespace SharedLibrary.ViewModels
{
    public class SignupViewModel : MvxViewModel
    {

        readonly IAuthenticationService _authService;

        public SignupViewModel(IAuthenticationService authService)
        {
            _authService = authService;

        }



        private string fName;
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
                RaisePropertyChanged(() => FName);
            }
        }



        private string lName;
        public string LName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
                RaisePropertyChanged(() => LName);
            }
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


        private string userName;
        public string Username
        {
            get
            {
                return userName;
            }
            set
            {


                userName = value;
                RaisePropertyChanged(() => Username);
            }
        }

        private string displayName;
        public string DisplayName
        {
            get
            {
                return displayName;
            }
            set
            {


                displayName = value;
                RaisePropertyChanged(() => DisplayName);
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


        void signup()
        {



            _authService.signup(FName, LName, Username,DisplayName, Email, Password);
        }


    }
}
