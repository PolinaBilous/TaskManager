using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DbModels;
using Models.Interfaces;

namespace TaskManager.Controllers
{
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly IUsersRepository _usersRepository;
        
        public UserController(IUsersRepository usersRepository) { _usersRepository = usersRepository; }

        [HttpPost]
        [Route("AddUser")]
        public void AddUser(User user)
        {
            _usersRepository.AddUser(user);
        }

        [HttpPost]
        [Route("DeleteUser")]
        public void DeleteUser(int id)
        {
            _usersRepository.DeleteUser(id);
        }


        [HttpPost]
        [Route("EditUser")]
        public void EditUser(User user)
        {
            _usersRepository.EditUser(user);
        }
    }
}