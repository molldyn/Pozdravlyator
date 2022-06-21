using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public List<Person> people { set; get; }
    }
}
