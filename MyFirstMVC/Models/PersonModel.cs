using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVC.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Isalive { get; set; } = true;
        public int Age { get; set; } = 0;

    }
}