using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Repositories
{
    public class UserRepository
    {
        private List<UserModel> _Users = new List<UserModel>();
        public List<UserModel> GetUsers()
        {
            return _Users;
        }

        public void AddUser(UserModel user)
        {
            _Users.Add(user);
        }

        public void deleteUser(int id )
        {
            _Users.Remove(seeanUser(id));
        }

        public void updateUser(int id, UserModel newUser)
        {
            var oldUser = seeanUser(id);
            oldUser.FirstName = newUser.FirstName;
            oldUser.LastName = newUser.LastName;
            

        }
        public UserModel seeanUser(int numero) {
           
            return _Users.Find(e=> e.Id.Equals(numero) );
        }
    }
}
