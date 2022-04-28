using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaskShop.DataBase;
using MaskShop.Models;
using MaskShop.Services.ServiceInterfaces;
using MaskShop.ViewModels;

namespace MaskShop.Services.ServiceRealisations
{
    public class UserRepositoryService : IUserRepositoryService
    {
        private readonly DataBaseContext _dataBase;

        public UserRepositoryService(DataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }

        public void AddUser(RegistrationViewModel registrationViewModel)
        {
            _dataBase.Users.Add(new User(registrationViewModel.Login, registrationViewModel.Password));
            _dataBase.SaveChanges();
            _dataBase.Dispose();
        }

        public bool TryLoggin(string login, string password)
        {
            var checkingUser = _dataBase.Users.FirstOrDefault(c => c.Login == login);

            if (checkingUser is null || checkingUser.Password != password)
            {
                return false;
            }
            return true;
        }

        public bool UserIsRegistered(string login)
        {
            var user = _dataBase.Users.FirstOrDefault(c => c.Login == login);

            if (user is null)
            {
                return false;
            }

            return true;
        }
    }
}
