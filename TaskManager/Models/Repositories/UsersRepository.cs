using Microsoft.EntityFrameworkCore;
using Models.DbModels;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly TaskManagerContext _context;

        public UsersRepository(TaskManagerContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            User user = _context.Users.SingleAsync(u => u.Id == userId).Result;
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void EditUser(User user)
        {
            _context.Users.SingleAsync(u => u.Id == user.Id).Result.Name = user.Name;
            _context.Users.SingleAsync(u => u.Id == user.Id).Result.Password = user.Password;
            _context.Users.SingleAsync(u => u.Id == user.Id).Result.Email = user.Email;
            _context.SaveChanges();
        }
    }
}
