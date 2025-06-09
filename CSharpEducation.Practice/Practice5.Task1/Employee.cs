using System;

namespace Practice5.Task1A
{
    internal class Employee
    {
        string _name;
        double _salary;
        public string Name
        {
            get { return _name; }
            set 
            {
                if ((value == "") || (value is null))
                    throw new ArgumentNullException("Укажите имя сотрудника!");
                _name = value;
            }
        }
        public double Salary
        {
            get { return _salary; }
            set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Оклад не может быть отрицательным!");
                _salary = value;
            }
        }
        public virtual double CalculateBonus()
        {
            return Salary * 0.1;
        }
    }
    internal class Manager : Employee
    {
        public new double CalculateBonus()
        {
            return Salary * 0.2;
        }
    }
}
