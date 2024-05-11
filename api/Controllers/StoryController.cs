using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route ("api/story")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StoryController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll(){
            var stories = _context.Story.ToList();
            return Ok(stories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) {
            var story = _context.Story.Find(id);
            if (story == null){
                return NotFound();
            }
            return Ok(story);
        }
    }
}