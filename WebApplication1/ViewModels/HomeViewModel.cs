﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Person> bdNow { get; set; }
        public IEnumerable<Person> bdSoon { get; set; }
    }
}
