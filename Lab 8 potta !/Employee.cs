using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_potta__
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public double Salary { get; set; }

        public Employee(int id, string name, string gender, double salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nGender: {Gender}\nSalary: {Salary}");
        }
    }
}
