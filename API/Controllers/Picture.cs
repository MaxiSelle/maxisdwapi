using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class Picture
    {
        public string Data { get; set; }

        public int PictureId { get; set; }

        [JsonIgnore]
        public ClothingItem ClothingItem { get; set; }

        public int ClothingItemId { get; set; }

    }
}
