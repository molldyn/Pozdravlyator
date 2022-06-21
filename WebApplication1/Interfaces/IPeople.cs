using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IPeople
    {
        IEnumerable<Person> People { get; }
        IEnumerable<Person> getBdNow { get; }
        IEnumerable<Person> getBdSoon { get; }
        Person getObjectPerson(int personId);
    }
}
