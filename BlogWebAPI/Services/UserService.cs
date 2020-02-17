using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWebAPI.Repositories;
using BlogWebAPI.Models;

namespace BlogWebAPI.Services
{
    public class UserService
    {
        private UserRepository _blogRepository;

        public UserService(UserRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public List<UserModel> GetUsers()
        {
            return _blogRepository.GetUsers();
        }

        public string AddUser(UserModel user) 
        {
            return _blogRepository.AddUser(user);
        }

        public string EditUser(int id, UserModel user)
        {
            return _blogRepository.EditUser(id, user);
        }

        public string DeleteUser(int id)
        {
            return _blogRepository.DeleteUser(id);
        }
    }
}
