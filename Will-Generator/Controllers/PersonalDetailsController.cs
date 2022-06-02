using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Will_Generator.Data;
using Will_Generator.Models;

namespace Will_Generator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDetailsController : ControllerBase
    {
        private readonly DataContext _context;

        public PersonalDetailsController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<string>> AddUser(PersonalDetail personalDetail)
        {
            /*Adding Personal Details to DB*/

            _context.PersonalDetails.Add(personalDetail);
            await _context.SaveChangesAsync();

            return Ok("You have been successfully registered");
        }
    }
}
