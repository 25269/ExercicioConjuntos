using Conjuntos.Entities;

namespace Conjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codeStudent;
            int follow;

            HashSet<Course> studentsCourses = new HashSet<Course>();

            Console.Write("To enter the system, type 1: ");
            follow = int.Parse(Console.ReadLine());

            while (follow == 1)
            {
                Console.Write("Which course do you want to enroll students in? ");
                string enrolledCourse = Console.ReadLine();

                switch (enrolledCourse)
                {
                    case "A":
                        Console.Write("How many students for course A? ");
                        int totalStudentsA = int.Parse(Console.ReadLine());

                        for (int i = 0; i < totalStudentsA; i++)
                        {
                            codeStudent = int.Parse((Console.ReadLine()));
                                                        
                            studentsCourses.Add(new Course{ NameCourse = enrolledCourse, CodeStudentEnrolled = codeStudent});
                        }
                        Console.WriteLine();
                        break;

                    case "B":
                        Console.Write("How many students for course B? ");
                        int totalStudentsB = int.Parse(Console.ReadLine());

                        for (int i = 0; i < totalStudentsB; i++)
                        {
                            codeStudent = int.Parse((Console.ReadLine()));

                            studentsCourses.Add(new Course { NameCourse = enrolledCourse, CodeStudentEnrolled = codeStudent });
                        }
                        Console.WriteLine();
                        break;

                    case "C":
                        Console.Write("How many students for course C? ");
                        int totalStudentsC = int.Parse(Console.ReadLine());

                        for (int i = 0; i < totalStudentsC; i++)
                        {
                            codeStudent = int.Parse((Console.ReadLine()));

                            studentsCourses.Add(new Course { NameCourse = enrolledCourse, CodeStudentEnrolled = codeStudent });
                        }
                        Console.WriteLine();
                        break;
                }

                follow = 0;

                Console.Write("To continue in the system, type 1. If you want to exit, type 0: ");
                follow = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Total students: " + studentsCourses.Count);
            Console.WriteLine();
        }
    }
}

