using System;
using Realms;

namespace SharedLibrary.ModelsRealm
{
    public class FacebookUser : RealmObject
    {

        [PrimaryKey]
        public String UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Email { get; set; }
        public String AccessToken { get; set; }
        public String ProfilePic { get; set; }

        public FacebookUser()
        {

        }
    }
}
