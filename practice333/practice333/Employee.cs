using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice333
{
    public class Employee
    {
        private string _fullName;
        private int _depatment;
        private double _salary;
        public int _id;
        static public int _count = 1;

        public Employee(string fullName, int depatment, double salary)
        {
            _fullName = fullName;
            _depatment = depatment;
            _salary = salary;
            _id = _count++;
        }


        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }

        public int Department
        {
            get => _depatment;
            set => _depatment = value;
        }

        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }
    }
}
