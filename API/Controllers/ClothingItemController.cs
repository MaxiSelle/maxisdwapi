using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClothingItemController : Controller
    {

        private readonly ClothingItemContext _context;

        public ClothingItemController(ClothingItemContext context)
        {
            _context = context;
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<ClothingItem>> GetTodoItem(int id)
        {
            if (this._context.ClothingItems.Find(id) == null)
                return NotFound(id);

            ClothingItem itemToReturn = this._context.ClothingItems.Where(x=>x.ClothingItemId==id).Include(x=>x.Pictures).First();
            return itemToReturn;
        }

        [HttpPost]
        public async Task<ActionResult<ClothingItem>> AddNewItem(ClothingItem item)
        {
            if (item.ClothingItemId != 0)
                return BadRequest();

            _context.ClothingItems.Add(item);
            
            await _context.SaveChangesAsync();

            return item;
        }

        [HttpGet("department/{tag}")]
        public async Task<ActionResult<ClothingItem[]>> GetItemsByDepartment(string tag)
        {
            if (this._context.ClothingItems.Where(x => x.Tag == tag).Count() == 0)
                return new ClothingItem[0];
                //return NotFound("No Items with Tag: \""+tag+"\" found");

            ClothingItem[] itemsToReturn = this._context.ClothingItems.Where(x => x.Tag == tag).Include(x => x.Pictures).ToArray();
            return itemsToReturn;
        }

        [HttpGet("all")]
        public async Task<ActionResult<ClothingItem[]>> GetAllItems()
        {
            return this._context.ClothingItems.Include(x=>x.Pictures).ToArray();
        }

    }
}
