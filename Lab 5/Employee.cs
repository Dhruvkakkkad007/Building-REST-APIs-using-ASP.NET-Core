//5.Write a program to create a base class Employee and a derived class Manager.
//Use a custom exception to handle cases where the salary entered is negative.

class InvalidSalaryException : Exception
{
    public InvalidSalaryException(string message) : base(message)
    {

    }
}
namespace Lab_5
{
     class Employee
    {
        string name;
        int id;


        public Employee(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public void displayEmployeeDetails()
        {
            Console.WriteLine($"Name: {name} ID:{id}");
          
        }

    }

    class Manager : Employee
    {
        public int salary;

        public Manager(string name, int id, int salary) : base(name, id)
        {
            this.salary = salary;
        }

       public void getSalary(int salary)
        {
            if(salary < 0)
            {
                throw new InvalidSalaryException("Invalid salary: Salary cannot be negative.");
            }

            Console.WriteLine($"Salary: {salary}");
        }
    }
}
