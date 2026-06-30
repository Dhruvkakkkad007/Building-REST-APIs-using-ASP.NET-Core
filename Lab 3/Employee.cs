using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
     class Employee
    {
        int Emp_Id;
        string Emp_Name;
        string dept;
        string designation;
        int salary;


        public void getEmpDetails()
        {
            Console.WriteLine("Enter Employee Id:");
            Emp_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            Emp_Name = Console.ReadLine();
            Console.WriteLine("Enter Department:");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Designation:");
            designation = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }

       public  void EmpdisplayDetails()
        {
            Console.WriteLine($"Employee Id: {Emp_Id},Emp_name:{Emp_Name},Department:{dept},Designation:{designation},salary:{salary}");
        }
    }
}
