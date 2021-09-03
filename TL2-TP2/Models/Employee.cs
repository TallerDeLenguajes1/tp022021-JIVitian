using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TL2_TP2.Models
{
    public class Employee
    {
        private int id;
        private string lastName;
        private string name;
        private string dni;
        private DateTime birthDay;
        private int age;
        private string address;
        private DateTime entryDate;
        private int antiquity;
        private float basicSalary;
        private float additional;
        private float discount;
        private float salary;

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

        public Employee(int id, string lastName, string name, string dni, DateTime birthDay, string address, DateTime entryDate, float basicSalary)
        {
            this.id = id;
            this.lastName = lastName;
            this.name = name;
            this.dni = dni;
            this.birthDay = birthDay;
            this.address = address;
            this.entryDate = entryDate;
            this.basicSalary = basicSalary;
            this.age = (DateTime.Now - birthDay).Days / 365;
            this.antiquity = (DateTime.Now - entryDate).Days / 365;
            this.additional = basicSalary / 100 * antiquity;
            this.discount = basicSalary * 15 / 100;
            this.basicSalary = basicSalary + additional - discount;
        }
    }
}
