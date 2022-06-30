using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly DataContext _context;
        public UsersController(DataContext Context)
        {
            _context = Context; 
            
    }
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _context.Users.ToList();
           

        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            return _context.Users.Find(id);
            
        }
    }
}
