using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCorePostgresDemo.Data;
using EfCorePostgresDemo.Models;

namespace EfCorePostgresDemo.Repositories
{
    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository()
        {
            _context = new AppDbContext();
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}