using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployeePolymorphism.Domain
{
    class Manager : Employee
    {
        private double _hra;
        private double _ta;
        private double _da;
        private int _basicSalary;
        public Manager(int  id, string name, double basicSalary) : base(id, name, basicSalary) 
        {
            _hra = .50 * _basicSalary;
            _ta = .40 * _basicSalary;
            _da = .30 * _basicSalary;
        
        }
        public override double CalculateTotalSalary()
        {
            throw new NotImplementedException();
        }

        public override string Role()
        {
            return "Manager";
        }
    }
}
