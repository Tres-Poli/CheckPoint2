using System;

namespace CheckPoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();

            Console.WriteLine(student.ToShortString());

            Console.WriteLine(student[Education.Bachelor]);
            Console.WriteLine(student[Education.Specialist]);
            Console.WriteLine(student[Education.SecondEducation]);

            var exams = new Exam[] { new Exam("M1", 5, DateTime.Now), new Exam("M2", 5, DateTime.Now) }; 
            student.Person = new Person("Svyatoslav", "Ladonin", new DateTime(2000, 1, 1));
            student.Education = Education.Bachelor;
            student.GroupNumber = 123;
            student.Exams = exams;

            Console.WriteLine(student.ToString());

            student.AddExam(new Exam("C#", 5, DateTime.Now), new Exam("SC101", 5, DateTime.Now));
            Console.WriteLine(student.ToString());

            Console.ReadKey();
        }
    }
}
