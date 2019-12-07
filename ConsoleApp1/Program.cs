using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Controllers;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            GenerateMenu();
        }

        private static void GenerateMenu()
        {
            var list = new List<Student>();
            var controller = new StudentController();
            while (true)
            {
                Console.WriteLine("\t Menu");
                Console.WriteLine("1. Thêm mới.");
                Console.WriteLine("2. Hiển thị danh sách.");
                Console.WriteLine("0. Exist.");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Thêm mới sinh viên");
                        var student = controller.CreateStudent();
                        list.Add(student);
                        break;
                    case 2:
                        Console.WriteLine("Danh sách sinh viên");
                        controller.PrintListStudent(list);
                        break;
                    case 0:
                        Console.WriteLine("Goodbye.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                if (choice == 0)
                {
                    break;;
                }
            }
            Console.ReadLine();
        }

    }
}
