using System;

namespace ClassAndObject
{


    class Student
    {
        //fields
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        //methods
        public void ShowDetails()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("StudentID : {0}, Name {1}, Address: {2}", StudentID, Name, Address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //object/instance
            Console.WriteLine("Hello World!");
            Student st = new Student();
            st.StudentID = 1;
            st.Name = "Stuff";
            st.Address = "world";

            st.ShowDetails();
            Console.ReadKey();

        }
    }
}
