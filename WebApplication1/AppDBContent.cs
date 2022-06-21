using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class AppDBContent : DbContext
    {
         public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {

        }
        
        public DbSet<Person> Person { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
