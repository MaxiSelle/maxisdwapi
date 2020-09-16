using API.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
        public class ClothingItemContext : DbContext
        {
            public ClothingItemContext(DbContextOptions<ClothingItemContext> options)
                : base(options)
            {
            }

            public DbSet<ClothingItem> ClothingItems { get; set; }

            public DbSet<Picture> Pictures { get; set; }


            
        }
    }
