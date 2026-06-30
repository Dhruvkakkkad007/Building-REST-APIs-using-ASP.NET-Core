//4.Write a program to create a Student class with student details and marks.
//Use exception handling to generate an error when marks entered are less than 0 or greater than 100.
namespace Lab_5
{
    class Student
    {
        string name;
        int marks;

      

        public Student(string name, int marks)
        {
            this.name = name;
            this.marks = marks;
        }



        public void setmarks(int marks)
        {
            

            if (marks < 0 || marks  > 100)
            {
                throw new Exception("Enter Valid Marks");
            }


            Console.WriteLine("Student Name:" + name);
            Console.WriteLine("Marks are valid: " + marks);
            
        }
    }
}
