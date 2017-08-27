using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCheckbox.Models
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMonday { get; set; }
        public bool IsTuesday { get; set; }
        public bool IsWednesday { get; set; }
        public bool IsThrusday { get; set; }
        public bool IsFriday { get; set; }
        public bool IsSaturday { get; set; }
        public bool IsSunday { get; set; }

        public static Class1 GetUser()
        {
            var user = new Class1
            {
                Id = 1,
                Name = "Rakesh",
                IsMonday = true,
                IsThrusday = false,
                IsWednesday = false,
                IsTuesday = false,
                IsFriday = true,
                IsSaturday = false,
                IsSunday = false
            };
            return user;
        }


    }
}


