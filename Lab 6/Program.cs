//1.Develop a menu - driven console application to manage student records using List.
//Implement Add, Display, Search, Update, and Delete functionalities.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_6
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            int ch = 0;

            do
            {
                Console.WriteLine("1.Add"); 
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Search");
                Console.WriteLine("4.Update");
                Console.WriteLine("5.Delete");
                Console.WriteLine("6.Exit");

                Console.WriteLine("Enter your choice: ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        AddStudent();
                        break;

                    case 2:
                        DisplayStudent();
                        break;

                    case 3:
                        SearchStudent();
                        break;

                    case 4:
                        UpdateStudent();
                        break;

                    case 5:
                        DeleteStudent();
                        break;
                   

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
            while (true);
        }

        static void AddStudent()
        {
            Console.WriteLine("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());


            students.Add(new Student(id, name, age));
            Console.WriteLine("Added Successfully");
        }

        static void DisplayStudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No records found.");
            }
            else
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"id:{student.id},name:{student.name} age:{student.age}");
                }
            }
        }

        static void SearchStudent()
        {
            Console.WriteLine("Enter id:");
            int id = Convert.ToInt32(Console.ReadLine());

            var Student = students.Find(s => s.id == id);
            if (Student != null)
            {
                Console.WriteLine($"id:{Student.id},name:{Student.name} age:{Student.age}");

            }
            else
            {
                Console.WriteLine("Record not found.");
            }
        }

            static void UpdateStudent()
            {
                Console.WriteLine("Enter id:");
                int id = Convert.ToInt32(Console.ReadLine());

                var Student = students.Find(s => s.id == id);
                if (Student != null)
                {

                    Console.WriteLine("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Not Updated");
                }

            }
        

            public static void DeleteStudent()
            {
                Console.WriteLine("Enter id:");
                int id = Convert.ToInt32(Console.ReadLine());

                var Student = students.Find(s => s.id == id);
                if (Student != null)
                {
                    students.Remove(Student);
                    Console.WriteLine("Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Record not found.");
                }
            }
        }

    }
