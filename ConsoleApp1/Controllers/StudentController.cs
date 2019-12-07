using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1.Controllers
{
    class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            Console.WriteLine("{0, 20} | {1, 20} | {2,20} | {3,20}", "STT", "Rollnumber", "Name", "Status");
            for (var i = 0; i < students.Count; i++)
            {
                if (students[i].IsDeactive()) { continue;}
                Console.WriteLine("{0, 20} | {1, 20} | {2,20} | {3,20}",  i + 1, students[i].RollNumber, students[i].FullName, students[i].IsNewStudent() ? "New" : "Active");
            }
            Console.ReadLine();
        }

        public Student CreateStudent()
        {
            Console.WriteLine("Vui lòng nhập mã sv:");
            var rollNumber = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập tên sv:");
            var name = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập ngày nhập học:");
            var createdAt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Vui lòng nhập trạng thái (1 - Active / 0 - Deactive):");

            var status = Convert.ToInt32(Console.ReadLine()) == 1 ? StudentStatus.Active : StudentStatus.Deactive;

            return new Student
            {
                RollNumber = rollNumber,
                FullName = name,
                CreatedAt = createdAt,
                Status = status
            };
        }
    }
}
