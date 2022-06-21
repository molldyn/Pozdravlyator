using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person
    {
        public int id { set; get; }
        public string name { set; get; }
      
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}",
            ApplyFormatInEditMode = true)]
        public DateTime date { get; set; }
        public string img { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
