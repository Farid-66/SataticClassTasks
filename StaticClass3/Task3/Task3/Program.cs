using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            Student student5 = new Student();

            Console.WriteLine(Student.ShowInstanceCount());
        }
    }
}
