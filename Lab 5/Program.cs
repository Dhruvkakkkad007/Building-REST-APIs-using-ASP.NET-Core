

namespace Lab_5
{
     class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program to perform division of two numbers entered by the user
            //Use exception handling to catch and display an appropriate message when the denominator is zero.

            //try
            //{
            //    Console.WriteLine("Enter num1:");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter num2:");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    int res = num1 / num2;

            //    Console.WriteLine("Result:" + res);
            //}
            //catch (DivideByZeroException)
            //{
            //        Console.WriteLine("Denominator cannot be zero.");
            //}
            //finally
            //{
            //    Console.WriteLine("End of program.");
            //}




            //2.Write a program to accept a numeric value from the user.
            //Use exception handling to detect and handle invalid input when non-numeric data is entered.

            //try
            //{
            //    Console.WriteLine("Enter Number:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Result:" + num);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Inavlid , Enter a numeric value.");
            //}
            //finally
            //{
            //    Console.WriteLine("End of program.");
            //}



            //BankAccount b = new BankAccount(1,10000);
            //Console.WriteLine("Enter amount to withdraw:");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //b.withdraw(amount);



            //Console.WriteLine("Name:");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter marks:");
            //int marks = Convert.ToInt32(Console.ReadLine());
            //Student s = new Student(name,marks);

            //s.setmarks(marks);



            //Console.WriteLine("Enter name:");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter id:");
            //int id = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter salary:");
            //int salary = Convert.ToInt32(Console.ReadLine());


            //Manager m = new Manager(name, id, salary);
            //m.displayEmployeeDetails();
            //m.getSalary(salary);




            //Console.WriteLine("Enter vid:");
            //int vid = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Speed:");
            //int speed = Convert.ToInt32(Console.ReadLine());

            //Car c = new Car(vid, speed);

            //c.displayVehicleDetails();
            //c.getSpeed(speed);



            //Console.WriteLine("Enter Balance for Deposit:");
            //double balance = Convert.ToDouble(Console.ReadLine());
            //BannkAccount b = new BannkAccount(balance);
            //b.deposit(balance);
            //Console.WriteLine("Enter Balance for withdraw:");
            // balance = Convert.ToDouble(Console.ReadLine());
            //b.withdraw(balance);



            CreditCArdPayment c = new CreditCArdPayment();
            Console.WriteLine("Enter amount to pay:");
            double amount = Convert.ToDouble(Console.ReadLine());
            c.proceesPayment(amount);

        }
    }
}
