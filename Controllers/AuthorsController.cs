using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Data; 
using LibraryManagement.Models; 
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase 
    {
        private readonly ApplicationDbContext _context;

        public AuthorsController(ApplicationDbContext context) 
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors() 
        {

            var author = await _context.Authors.ToListAsync();

            if (author == null || author.Count == 0)
            {
                return NotFound();
            }

            return Ok(author);
        }


    }
}