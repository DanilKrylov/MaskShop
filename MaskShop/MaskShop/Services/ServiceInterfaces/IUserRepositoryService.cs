using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaskShop.Models;
using MaskShop.ViewModels;

namespace MaskShop.Services.ServiceInterfaces
{
    public interface IUserRepositoryService
    {
        public void AddUser(RegistrationViewModel registrationViewModel);

        public bool UserIsRegistered(string login);

        public bool TryLoggin(string login, string password);
    }
}
