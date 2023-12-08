using Blazored.LocalStorage;
using IIT.Client.Constants;
using IIT.Shared.ViewModels.Users;

namespace IIT.Client.Services.Storage
{
    public class UserStorageService : StorageService
    {
        public UserStorageService(ILocalStorageService storage) : base(storage)
        {
        }

        public async Task LoginUser(UserViewModel user)
        {
            await AddItem(StorageConstants.LoginedUser, user);
        }

        public async Task ExitUser()
        {
            await RemoveItem(StorageConstants.LoginedUser);
        }

        public async Task<bool> IsUserLoginned()
        {
            var exists = await ItemExists(StorageConstants.LoginedUser);

            return exists;
        }

        public async Task<UserViewModel> GetLoginnedUser()
        {
            var user = await GetItem<UserViewModel>(StorageConstants.LoginedUser);

            return user;
        }

        public async Task UpdateCurrentUserInfo(UserViewModel user)
        {
            await UpdateItem(StorageConstants.LoginedUser, user);
        }
    }
}
