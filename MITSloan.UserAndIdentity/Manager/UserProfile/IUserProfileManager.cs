using MITSloan.UserAndIdentity.Manager.UserProfile.Entity;

namespace MITSloan.UserAndIdentity.Manager.UserProfile
{
    public interface IUserProfileManager
    {
        bool TryGetProfileForCurrentUser(out IUserProfile profile);
    }
}
