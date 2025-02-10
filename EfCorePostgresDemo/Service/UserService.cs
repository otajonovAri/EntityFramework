using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCorePostgresDemo.Models;
using EfCorePostgresDemo.Repositories;

namespace EfCorePostgresDemo.Service
{
    public class UserService
    {
        private readonly UserRepository userRepo;

        public UserService()
        {
            userRepo = new UserRepository();
        }

        public void RegisterUser(string name)
        {
            var user = new User{
                Name = name
            };
            userRepo.AddUser(user);
            System.Console.WriteLine($"User Added: {user.Name}");
        }

        public void ShowAllUsers()
        {
            var users = userRepo.GetAllUsers();
            System.Console.WriteLine("Users in Database: ");
            foreach(var item in users)
                System.Console.WriteLine($"Id: {item.Id} - Name: {item.Name}");
        }
    }
}