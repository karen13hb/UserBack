using CapaEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Services
{
    public interface IUserService
    {
        Task<List<User>> getUsersAsync();
        Task<bool> deleteUserAsync(decimal id);
    }
}
