using System;


namespace Lab_3;

class faculty
{
    int id;
    string name;
    int age;
    int weigth;
    int height;

   public void getDetails()
    {
        Console.WriteLine("Enter Id:");
        id = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Name:");
        name = Console.ReadLine();

         Console.WriteLine("Enter Age:");
         age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Weight:");
        weigth = Convert.ToInt32( Console.ReadLine());

        Console.WriteLine("Enter height:");
        height = Convert.ToInt32(Console.ReadLine());

    }
    
    public void displayDetails()
    {
        Console.WriteLine("Id: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weigth);
        Console.WriteLine("Height: " + height);
    }

}