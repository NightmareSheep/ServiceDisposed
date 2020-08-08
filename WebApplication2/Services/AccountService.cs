using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace WolfDen.Services
{
    public class AccountService : IAccountService
    {
        private UserManager<IdentityUser> _userManager;

        public AccountService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async void DeleteInactiveUserData()
        {
            var toBeDeletedUsers = _userManager.Users.ToList();
            
            foreach (var user in toBeDeletedUsers)
                await _userManager.DeleteAsync(user);
        }
    }
}
