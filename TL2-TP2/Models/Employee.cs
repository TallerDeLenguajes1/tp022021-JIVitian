using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TL2_TP2.Models
{
    public class Employee
    {
        private readonly int id;
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

        public int Id { get => id;}
        public string LastName { get => lastName; set => lastName = value; }
        public string Name { get => name; set => name = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public DateTime EntryDate { get => entryDate; set => entryDate = value; }
        public int Antiquity { get => antiquity; set => antiquity = value; }
        public float BasicSalary { get => basicSalary; set => basicSalary = value; }
        public float Additional { get => additional; set => additional = value; }
        public float Discount { get => discount; set => discount = value; }
        public float Salary { get => salary; set => salary = value; }

        public Employee(int id, string lastName, string name, string dni, DateTime birthDay, string address, DateTime entryDate, float basicSalary)
        {
            this.id = id;
            this.LastName = lastName;
            this.Name = name;
            this.Dni = dni;
            this.BirthDay = birthDay;
            this.Address = address;
            this.EntryDate = entryDate;
            this.BasicSalary = basicSalary;
            this.Age = (DateTime.Now - birthDay).Days / 365;
            this.Antiquity = (DateTime.Now - entryDate).Days / 365;
            this.Additional = Antiquity > 20 ? basicSalary * (float) 0.25 : basicSalary * Antiquity / 100;
            this.Discount = basicSalary * 15 / 100;
            this.Salary = basicSalary + Additional - Discount;
        }
    }
}
