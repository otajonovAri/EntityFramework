using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCorePostgresDemo.Service;

namespace EfCorePostgresDemo.Controllers
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public void CreateUser(string name)
        {
            _userService.RegisterUser(name);
        }

        public void ListUser()
        {
            _userService.ShowAllUsers();
        }
    }
}