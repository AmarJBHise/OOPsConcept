namespace OOPs_Concept
{
    internal class program
    {
        static void Main()
        {
            // StudentDataObject();


            Console.WriteLine("Student1 object inforation");
            StudentData Student1 = new StudentData();
            Student1.GetStudentData();
            Student1.PutStudentData();


            Console.WriteLine("Student2 object inforation");
            StudentData Student2 = new StudentData();
            Student2.GetStudentData();
            Student2.PutStudentData();


            Console.WriteLine("Student3 object inforation");
            StudentData Student3 = new StudentData();
            Student3.GetStudentData();
            Student3.PutStudentData();

            Console.WriteLine("Student3 object inforation");
            StudentData Student4 = new StudentData();
            Student4.GetStudentData();
            Student4.PutStudentData();



        }
        public static void StudentDataObject()
        {
            StudentData Student1 = new StudentData(); 

            Student1.Id = 1;
            Student1.Name = "Arjun";
            Student1.Marks = "75";


            Console.WriteLine("Student Id= " + Student1.Id);
            Console.WriteLine("Student Name= " + Student1.Name);
            Console.WriteLine("marks of student= " + Student1.Marks);


            StudentData Student2;    
            Student2 = new StudentData(); 


            Student2.Id = 2;
            Student2.Name = "Arvind";
            Student2.Marks = "85";


            
            Console.WriteLine("Student Id= " + Student2.Id);
            Console.WriteLine("Student Name= " + Student2.Name);
            Console.WriteLine("marks of student = " + Student2.Marks);




            StudentData Student3 = new StudentData();
            Console.WriteLine("Please Enter the id for the student");
            Student3.Id = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please Enter the Name of student");
            Student3.Name = Console.ReadLine();

            Console.WriteLine("er thPlease Ente mark of student");
            Student3.Marks = Console.ReadLine();



            Console.WriteLine("Student Id= " + Student3.Id);
            Console.WriteLine("Student Name= " + Student3.Name);
            Console.WriteLine("Marks of the Student= " + Student3.Marks);


            StudentData Student4;   
                Student4 = new StudentData();
            Console.WriteLine("Please Enter the id for Student");
            Student4.Id = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter the Name of Student");
            Student4.Name = Console.ReadLine();

            Console.WriteLine("Please Enter the Marks of Student");
            Student4.Marks = Console.ReadLine();



            Console.WriteLine("Student Id= " + Student4.Id);
            Console.WriteLine("Student Name= " + Student4.Name);
            Console.WriteLine("marks of the Student= " + Student4.Marks);
        }

    }
}