using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWebAPI.Models;

namespace BlogWebAPI.Repositories
{
    public class UserRepository
    {
        private List<UserModel> Users = new List<UserModel>()
        {
          new UserModel { Id = 1, Name = "Kevin", Email="kramirez@sciodev.com", Password="qwerty123", Date = DateTime.Now},
          new UserModel { Id = 2, Name = "Pedro", Email="pdiaz@sciodev.com", Password="123456789", Date = DateTime.Now},
          new UserModel { Id = 3, Name = "Rosa", Email="rrios@sciodev.com", Password="abc123", Date = DateTime.Now},
          new UserModel { Id = 4, Name = "Joaquin", Email="jlopez@sciodev.com", Password="polioplk", Date = DateTime.Now},
          new UserModel { Id = 5, Name = "Petra", Email="pmorales@sciodev.com", Password="frepol1223", Date = DateTime.Now},
        };

        public List<UserModel> GetUsers()
        {
            return Users;
        }

        public string AddUser(UserModel user)
        {
            Users.Add(user);
            return "User registered correctly";
        }

        public string EditUser(int id, UserModel user)
        {
            Users[id] = user;
            return "User edited correctly";
        }

        public string DeleteUser(int id)
        {
            Users.RemoveAt(id - 1);
            return "User deleted correctly";
        }
    }
}
