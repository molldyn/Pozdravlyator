using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class PeopleListViewModel
    {
        public IEnumerable<Person> allPeople { get; set; }
        public string currCategory { get; set; }
    }
}
