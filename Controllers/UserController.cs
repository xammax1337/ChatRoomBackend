using Admix.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Admix.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }



        //Method for adding friends, will be working on later.
        [HttpPost("add")]
        public async Task<IActionResult> AddFriend(string username)
        {
            //Looks for the current user logged in
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return Unauthorized();
            }

            var friendUser = await _userManager.FindByNameAsync(username);
            if (friendUser == null)
            {
                return BadRequest("User not found");
            }

            return Ok("Friend added successfully");
        }
    }
}
