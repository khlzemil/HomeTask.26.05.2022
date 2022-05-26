using System;

namespace HomeTask._26._05
{
    class Program
    {
        public static void Main()
        {
            Student student1 = new Student();
            student1.Grades = new[] { 1, 2, 3, 4, 5, 6 };


            foreach (var item in student1.Grades)
            {
                Console.WriteLine(item);
            }       
        }      
    }   
}
