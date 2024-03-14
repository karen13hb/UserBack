using CapaDatos;
using CapaEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> getUsersAsync();
        Task<bool> deleteUserAsync(User user);

        Task<User> getUserIdAsync(decimal id);
    }
}
