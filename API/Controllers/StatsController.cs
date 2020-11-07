using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {

        private readonly AppDBContext _context;

        public StatsController(AppDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ItemData[]>> GetStats()
        {
            List<ItemData> itemData = new List<ItemData>();


            List<string> tags = _context.ClothingItems.Select(x => x.Tag).Distinct().ToList();

            foreach (string tag in tags)
            {
                int count = _context.ClothingItems.Where(x => x.Tag.ToLower() == tag).Count();

                itemData.Add(new ItemData(count, tag));
            }

            return itemData.ToArray();


        }

        public class ItemData
        {
            public ItemData(int count, string tag)
            {
                this.Count = count;
                this.Tag = tag;
            }
            public int Count { get; set; }

            public string Tag { get; set; }
        }
    }


}