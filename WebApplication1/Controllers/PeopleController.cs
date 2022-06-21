using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeople _allPeople;
        private readonly ICategory _allCategories;

        public PeopleController(IPeople iPeople, ICategory iCategory)
        {
            _allPeople = iPeople;
            _allCategories = iCategory;
        }
        [Route("People/List")]
        [Route("People/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Person> people= null;
            string currCategory = "";
            var now = DateTime.Now;
            if (string.IsNullOrEmpty(category))
            {

                people = _allPeople.People.OrderBy(i=>IsBeforeNow(now,i.date)).ThenBy(i => i.date.Month).ThenBy(i => i.date.Day);

            }
                       
            else
            {   
                if (string.Equals("Друзья", category, StringComparison.OrdinalIgnoreCase)) {
                    people = _allPeople.People.Where(i => i.Category.categoryName.Equals("Друзья")).OrderBy(i => IsBeforeNow(now, i.date)).ThenBy(i => i.date.Month).ThenBy(i => i.date.Day);
                }
                else if (string.Equals("Знакомые", category, StringComparison.OrdinalIgnoreCase))
                {
                    people = _allPeople.People.Where(i => i.Category.categoryName.Equals("Знакомые")).OrderBy(i => IsBeforeNow(now, i.date)).ThenBy(i => i.date.Month).ThenBy(i => i.date.Day);
                }
                else if (string.Equals("Сотрудники", category, StringComparison.OrdinalIgnoreCase))
                {
                    people = _allPeople.People.Where(i => i.Category.categoryName.Equals("Сотрудники")).OrderBy(i => IsBeforeNow(now, i.date)).ThenBy(i => i.date.Month).ThenBy(i => i.date.Day);
                }
                currCategory = _category;

            }
            var personObj = new PeopleListViewModel
            {
                allPeople = people,
                currCategory = currCategory };


            return View(personObj);
        }
        private static bool IsBeforeNow(DateTime now, DateTime dateTime)
        {
            return dateTime.Month < now.Month
                || (dateTime.Month == now.Month && dateTime.Day < now.Day);
        }
        

    }

}
