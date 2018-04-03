using Models.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public interface IUsersRepository
    {
        void AddUser(User user);
        void DeleteUser(int userId);
        void EditUser(User user);
    }
}
