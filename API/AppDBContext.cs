using API.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
        public class AppDBContext : DbContext
        {
            public AppDBContext(DbContextOptions<AppDBContext> options)
                : base(options)
            {
            }

            public DbSet<ClothingItem> ClothingItems { get; set; }

            public DbSet<Picture> Pictures { get; set; }
          
        }
    }
