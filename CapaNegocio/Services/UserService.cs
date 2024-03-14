using CapaDatos;
using CapaEntidades.Models;
using CapaNegocio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            
        }
        public async Task<List<User>> getUsersAsync()
        {
            return await _userRepository.getUsersAsync();
        }


        public async Task<bool> deleteUserAsync(decimal id)
        {
           
            var user = await _userRepository.getUserIdAsync(id);


            if (user == null)
            {
                return false;
            }
            await _userRepository.deleteUserAsync(user);

            return true;
        }

    }
}
