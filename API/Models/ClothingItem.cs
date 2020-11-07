using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ClothingItem
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public int ClothingItemId { get; set; }
        public string Size { get; set; }


        public List<Picture> Pictures { get; set; }

    }

}
