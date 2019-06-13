using System;
namespace SharedLibrary.Services.Interfaces
{
    public interface IAuthenticationService
    {

        void login(string password, string email);

        void checkAuth();

        void signup(string fName, string lName, string userName, string displayName, string email, string password);



    }
}
