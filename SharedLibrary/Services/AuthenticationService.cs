using System;
using System;
using SharedLibrary.DAOs;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reactive.Subjects;
using System.Reactive.Linq;
using SharedLibrary.Models;
using SharedLibrary.ModelsRealm;
using SharedLibrary.Services.Interfaces;

namespace SharedLibrary.Services
{
    public class AuthenticationService : IAuthenticationService
    {

        private HttpClient _client;
        public BehaviorSubject<bool> isAuthenticated;
        public IObservable<bool> authStatus;
        public FacebookUser fbUser;
        public GoogleUser googleUser;
        private User user;

        public BehaviorSubject<User> userObj;
        public IObservable<User> currentUser;

        public BehaviorSubject<FacebookUser> fbUserObj;
        public IObservable<FacebookUser> currentFbUser;

        public BehaviorSubject<GoogleUser> googleUserObj;
        public IObservable<GoogleUser> currentGoogleUser;


        public AuthenticationService()
        {


            _client = new HttpClient();


            isAuthenticated = new BehaviorSubject<bool>(false);
            authStatus = isAuthenticated.AsObservable<bool>();



            userObj = new BehaviorSubject<User>(new User());

            currentUser = userObj.AsObservable<User>();

            fbUserObj = new BehaviorSubject<FacebookUser>(new FacebookUser());
            currentFbUser = fbUserObj.AsObservable<FacebookUser>();

            googleUserObj = new BehaviorSubject<GoogleUser>(new GoogleUser());
            currentGoogleUser = googleUserObj.AsObservable<GoogleUser>();



            checkAuth();

        }


        public void checkAuth()
        {




        }

        public void login(string password, string email)
        {

        }

        public void signup(string fName, string lName, string displayName, string userName, string email, string password)
        {
            
        }
    }
}
