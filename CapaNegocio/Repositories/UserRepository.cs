using CapaDatos;
using CapaEntidades.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PruebaSDContext _context;

        public UserRepository(PruebaSDContext context)
        {
            _context = context;
        }
        public async Task<List<User>> getUsersAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<bool> deleteUserAsync(User user)
        {
            _context.Usuarios.Remove(user);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<User> getUserIdAsync(decimal id)
        {
            var user = await _context.Usuarios.FindAsync(id);
            
            return user;

        }



    }
}
