using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;
using WebApplication8.Repositories;

namespace WebApplication8.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserModel> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public void AddUser(UserModel user)
        {
            _userRepository.AddUser(user);
        }

        public UserModel SeeUser(int numero) {
            return _userRepository.seeanUser(numero);

        }
        public void updateUser(int id, UserModel newUser) => _userRepository.updateUser(id, newUser);

        public void removeUser(int id) {
            _userRepository.deleteUser(id);
                }
    }
}
