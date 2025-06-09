using System;

namespace Practice5.Task1B
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
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public virtual double CalculateBonus()
        {
            return Salary * 0.1;
        }
    }
    internal class Manager : Employee
    {
        int _teamsize;
        public int TeamSize
        {
            get { return _teamsize; }
            set 
            {
                if ((value < 0) || (value == 0))
                    throw new ArgumentOutOfRangeException("Размер команды не может быть отрицательным и равным нулю!");
                _teamsize = value;
            }
        }
        public Manager(string name, double salary, int teamSize) : base(name, salary)
        { 
            Name = name;
            Salary = salary;
            TeamSize = teamSize;
        }
        public new double CalculateBonus()
        {
            int minSizeTeamForBonus = 5;
            return (TeamSize > minSizeTeamForBonus) ? Salary * 0.25 : Salary * 0.2;
        }
    }
}
