using StructureMap.Configuration.DSL;
using MITSloan.UserAndIdentity.Implementation.Manager.UserProfile;
using MITSloan.UserAndIdentity.Manager.UserProfile;

namespace MITSloan.UserAndIdentity.Implementation.Bootstrapper
{
    public class UserAndIdentityImplementationBootstrapper : Registry
    {
        public UserAndIdentityImplementationBootstrapper()
        {
            //Managers
            this.For<IUserProfileManager>().Use<AspNetIdentityUserProfileManager>();
        }
    }
}
