using CapaDatos;
using CapaEntidades.Models;
using CapaNegocio.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: api/<UserController>

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            try
            {
                var users = await _userService.getUsersAsync();
                if (users == null || !users.Any())
                {
                    return NotFound();
                }
                return Ok(users);
            }
            catch (Exception ex)
            {
              
                return StatusCode(500, $"Error al obtener los usuarios: {ex.Message}");
            }
        }


        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(decimal id)
        {
            try
            {
                await _userService.deleteUserAsync(id);
                return NoContent(); 
            }
            catch (Exception ex)
            {
               
                return StatusCode(500, $"Error al eliminar usuario: {ex.Message}");
            }
        }
    }
}
