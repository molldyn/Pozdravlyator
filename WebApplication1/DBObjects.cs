using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Person.Any())
            {
                
                content.AddRange(
                    new Person { name = "Адалинда Кино", date = new DateTime(1990,08,10),  img = "/img/Адалинда Кино.jfif", Category = Categories["Друзья"] },
                    new Person { name = "Ай Орлова", date = new DateTime(1992, 09, 12),  img = "/img/Ай Орлова.jfif", Category = Categories["Сотрудники"] },
                    new Person { name = "Амайя Соро", date = new DateTime(1993, 01, 21), img = "/img/Амайя Соро.jfif", Category = Categories["Знакомые"] },
                    new Person { name = "Атия Симон", date = new DateTime(1969, 08, 19), img = "/img/Атия Симон.jfif", Category = Categories["Друзья"] },
                    new Person { name = "Ахей Элерс", date = new DateTime(1994, 07, 23),  img = "/img/Ахей Элерс.jfif", Category = Categories["Сотрудники"] },
                    new Person { name = "Белослава Шёнберг", date = new DateTime(1972, 05, 09),  img = "/img/Белослава Шёнберг.jfif", Category = Categories["Друзья"] },
                    new Person { name = "Братислав Лавлейс", date = new DateTime(2006, 10, 28),  img = "/img/Братислав Лавлейс.jfif", Category = Categories["Знакомые"] },
                    new Person { name = "Герман Влах", date = new DateTime(1971, 01, 23),  img = "/img/Герман Влах.jfif", Category = Categories["Сотрудники"] },
                    new Person { name = "Дарья Жергонн", date = new DateTime(1985, 01, 06),  img = "/img/Дарья Жергонн.jfif", Category = Categories["Знакомые"] },
                    new Person { name = "Марина Коулман", date = new DateTime(1960, 03, 07),  img = "/img/Марина Коулман.jfif", Category = Categories["Друзья"] },
                    new Person { name = "Мария Щукина", date = new DateTime(1969, 06, 12),  img = "/img/Мария Щукина.jfif", Category = Categories["Знакомые"] },
                    new Person { name = "Никита Александров", date = new DateTime(1985, 01, 25),  img = "/img/Никита Александров.jfif",Category= Categories["Друзья"] },
                    new Person { name = "Пенелей Видал", date = new DateTime(1969, 07, 19),  img = "/img/Пенелей Видал.jfif", Category = Categories["Друзья"] },
                    new Person { name = "Платон Сергеев", date = new DateTime(1962, 02, 01), img = "/img/Платон Сергеев.jfif", Category = Categories["Сотрудники"] },
                    new Person { name = "Рэйчел Лакс", date = new DateTime(1971, 01, 20),  img = "/img/Рэйчел Лакс.jfif", Category = Categories["Друзья"] },
                    new Person { name = "Сэмвел Скотт", date = new DateTime(1987, 12, 30), img = "/img/Сэмвел Скотт.jfif", Category = Categories["Друзья"] },
                    new Person { name = "Ульяна Петрова", date = new DateTime(1969, 03, 29),  img = "/img/Ульяна Петрова.jfif", Category = Categories["Друзья"] },
                    new Person { name = "Фестер Джексон", date = new DateTime(1999, 10, 23), img = "/img/Фестер Джексон.jfif", Category = Categories["Знакомые"] },
                    new Person { name = "Хикару Миямото", date = new DateTime(1969, 07, 18), img = "/img/Хикару Миямото.jfif", Category = Categories["Знакомые"] },
                    new Person { name = "Хью Стюарт", date = new DateTime(2019, 08, 19), img = "/img/Хью Стюарт.jfif", Category = Categories["Знакомые"] }
                    );
            }

            content.SaveChanges();
        }
        private static Dictionary<string, Category> caterogy;
        public static Dictionary<string,Category> Categories
        {
            get {
                if (caterogy == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName ="Друзья"},
                        new Category{ categoryName ="Знакомые"},
                        new Category{ categoryName ="Сотрудники"}
                    };
                    caterogy = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        caterogy.Add(el.categoryName, el);
                }
                return caterogy;
            }
        }
    }
}
