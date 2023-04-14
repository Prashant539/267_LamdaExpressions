using System;
namespace LamdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Student data Management");
            Student student1 = new Student();  

            List<Student> list = new List<Student>()
            {
                new Student() { Id = 1, Name = "Prashant", PhoneNumber = 9820899968, Address = "Gorakhpur", Age = 25, TotalMarks=95},
                new Student() { Id = 2, Name = "Rupesh", PhoneNumber = 7746039890, Address = "Pune", Age = 27, TotalMarks=50},
                new Student() { Id = 3, Name = "Vishnu", PhoneNumber = 7756039898, Address = "Kerla", Age = 30, TotalMarks=105},
                new Student() { Id = 4, Name = "Akhil", PhoneNumber = 9983084421, Address = "Ashok Nagar", Age = 35, TotalMarks=100},

            };
            DisplayStudentDetails(list);
            Console.ReadLine();
        }
        public static void DisplayStudentDetails(List<Student> list)
        {
            Console.WriteLine("Displaying All Students");
            foreach (Student student in list)
            {
                Console.WriteLine("ID :" + student.Id + "  " + "Name :" + student.Name + "  " + "Phone Number :" + student.PhoneNumber + "  " + "Address :" + student.Address + "  " + "Age :" + student.Age + " " + "TotalMarks : " + student.TotalMarks);

            }
        }
    }
}

           
        

