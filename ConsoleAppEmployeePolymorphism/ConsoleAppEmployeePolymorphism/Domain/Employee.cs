using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployeePolymorphism.Domain
{
    abstract class Employee
    {
        private int _id;
        private string _name;
        private double _basicSalary;
        private double _pa;

        public Employee(int id, string name, double basicSalary, double pa)
        {
            _id = id;
            _name = name;
            _basicSalary = basicSalary;
            _pa = pa;
        }

        public abstract double CalculateTotalSalary();
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double basicSalary { get { return _basicSalary; } }

        public abstract string Role {  get; }      
    }
}
}
