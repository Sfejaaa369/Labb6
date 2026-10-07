using System;
using System.Collections.Generic;
using System.Text;

namespace Labb6
{
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        //konstruktor
        public Employee(string id, string name, string gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

    }
}
