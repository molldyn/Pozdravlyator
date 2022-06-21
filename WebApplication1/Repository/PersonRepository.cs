using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class PersonRepository : IPeople

    {
        private readonly AppDBContent appDBContent;

        public PersonRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Person> People => appDBContent.Person.Include(c=>c.Category);

        public IEnumerable<Person> getBdNow => appDBContent.Person.Where(p => p.date.Month==DateTime.Now.Month & p.date.Day == DateTime.Now.Day).Include(c => c.Category);
        public IEnumerable<Person> getBdSoon => appDBContent.Person.Where(p => (p.date.Day>DateTime.Now.Day & p.date.Month==DateTime.Now.Month) || p.date.Month == DateTime.Now.Month+1).Include(c => c.Category).OrderBy(i => i.date.Month).ThenBy(i => i.date.Day);

        public Person getObjectPerson(int personId) => appDBContent.Person.FirstOrDefault(p => p.id==personId);
        
    }
}
