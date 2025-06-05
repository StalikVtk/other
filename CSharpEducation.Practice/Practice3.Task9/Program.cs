using System;

namespace Practice3.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Арсений", 22);

            Student.UpdateNameStudent(student);
        }
    }
}
