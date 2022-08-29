using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio13
{
    internal class Employee
    {
        public int Id { get; set; }
        string Name;
        public double Salary { get; private set; }


        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
