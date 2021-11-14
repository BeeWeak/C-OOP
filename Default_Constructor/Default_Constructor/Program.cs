using System;

namespace Default_Constructor
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string College { get; set; }
        //default constructor
        public Student()
        {
            College = "South dartmoor";



        }
        //parameterized constructor
        public Student(int studentID, string name, string college)
        {
            this.StudentID = studentID;
            this.Name = name;
            this.College = college;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student st = new Student();
            //Console.WriteLine("StudentID: {0}, Name: {1}, College: {2}", st.StudentID, st.Name, st.College);



            Student st = new Student(1, "Harry", "South Dartmoor");
            Console.WriteLine("StudentID: {0}, Name: {1}, College: {2}", st.StudentID, st.Name, st.College);
            Console.ReadKey();
        }
    }
}
