using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TL2_TP2.Models
{
    public class Employee
    {
        public int Id { get; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Dni { get; set; }
        public DateTime BirthDay { get; set; }
        public int Age { get; }
        public string Address { get; set; }
        public DateTime EntryDate { get; set; }
        public int Antiquity { get; }
        public float BasicSalary { get; set;  }
        public float Additional { get; }
        public float Discount { get; }
        public float Salary { get; }

    }
}
