using System;
using Realms;

namespace SharedLibrary.ModelsRealm
{
    public class GoogleUser: RealmObject
    {
        [PrimaryKey]
        public String UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Email { get; set; }
        public String IdToken { get; set; }
        public String ProfilePic { get; set; }

        public GoogleUser()
        {
        }
    }
}
