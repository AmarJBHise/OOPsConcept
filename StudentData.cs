using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concept
{
    internal class StudentData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Marks { get; set; }

        public void GetStudentData()
        {
            Console.WriteLine("Please Enter the id for  student");
            this.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Name of student");
            this.Name = Console.ReadLine();

            Console.WriteLine("Please Enter the Mark of student");
            this.Marks = Console.ReadLine();

        }
        public void PutStudentData()
        {
            Console.WriteLine("Student Id= " + this.Id);
            Console.WriteLine("Student Name= " + this.Name);
            Console.WriteLine("Marks of the Student= " + this.Marks);
        }
    }
   
}
