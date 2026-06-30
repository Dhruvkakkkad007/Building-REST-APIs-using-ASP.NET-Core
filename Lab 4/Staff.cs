using System;

namespace Lab_4
{
    class Staff
    {
        public string name;
        public int basicpay;

        public Staff(string name, int basicpay)
        {
            this.name = name;
            this.basicpay = basicpay;
        }

        public virtual double CalculateSalary()
        {
            return basicpay;
        }

        public virtual void displaySalary()
        {
            Console.WriteLine($"Name:{name}, Salary:{basicpay}");
        }
    }

    class Doctor : Staff
    {
        public int DA;

        public Doctor(string name, int basicpay, int DA)
            : base(name, basicpay)
        {
            this.DA = DA;
        }

        public override double CalculateSalary()
        {
            return basicpay + DA;
        }

        public override void displaySalary()
        {
            Console.WriteLine($"Name:{name}, Salary:{CalculateSalary()}");
        }
    }
}