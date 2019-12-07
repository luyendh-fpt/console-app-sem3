using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Student
    {
        public string RollNumber { get; set; }
        public string Email { get; set; }

        public string FullName { get; set; }

        public DateTime Birthday { get; set; }
        public DateTime CreatedAt { get; set; }
        public StudentStatus Status { get; set; }

        public bool IsNewStudent()
        {
            return (DateTime.Now - this.CreatedAt).TotalDays <= 60;
        }

        public bool IsDeactive()
        {
            return this.Status == StudentStatus.Deactive;
        }
    }

    public enum StudentStatus
    {
        Active = 1, Deactive = 0
    }
}
