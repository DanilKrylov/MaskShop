using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Models
{
    public class User
    {
        [Key]
        public string Login { get; set; }

        public string Password { get; set; }
        public ShopCart ShopCart { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
