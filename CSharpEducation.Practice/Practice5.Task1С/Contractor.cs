using Practice5.Task1C;
using System;

namespace Practice5.Task1С
{
    internal class Contractor : Employee
    {
        double _hourlyRate;
        public Contractor(string name, double hourlyRate) : base(name, 0)
        {
            Name = name;
            HourlyRate = hourlyRate;
        }
        public double HourlyRate
        {
            get { return _hourlyRate; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Часовая ставка не может быть меньше 1 руб.");
                _hourlyRate = value;
            }
        }
        public new double CalculateBonus(int hoursWorked)
        {
            return HourlyRate * hoursWorked * 0.3;
        }
    }
}
