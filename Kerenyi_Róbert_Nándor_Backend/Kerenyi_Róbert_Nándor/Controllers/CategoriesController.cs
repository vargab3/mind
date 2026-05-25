using Kerenyi_Róbert_Nándor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kerenyi_Róbert_Nándor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetCategories()
        {
            try
            {
                using (var cx=new LibrarydbContext())
                {
                    var response=cx.Categories.Select(x=>new {x.CategoryId,x.CategoryName,books=x.Books.ToList()}).ToList();
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
