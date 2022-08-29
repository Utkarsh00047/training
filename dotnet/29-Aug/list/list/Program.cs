using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student>  stu = new List<Student>() {
                new Student{ Id = 1, Name="Bill" },
                new Student{ Id = 2, Name="Steve" },
                new Student{ Id = 3, Name="Ram" },
                new Student{ Id = 4, Name="Abdul" },
                new Student{ Id = 5, Name="Bill" }
        };
            foreach (Student stus in stu)
            {
                Console.WriteLine(stus.Id + ", " + stus.Name);
            }
        }
    }
}
