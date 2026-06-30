//4.A car dealership wants to display details of premium sports cars. 
//Create a Car object with Make, Model, Year, FuelType and Horsepower details (use constructor).


using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Car
    {
        string Make;
        string Model;
        int year;
        string FuelType;
        int Horsepower;
    


    public Car(string Make, String Model, int year, String FuelType, int Horsepower)
        {
            this.Make = Make;
            this.Model = Model;
            this.year = year;
            this.FuelType = FuelType;
            this.Horsepower = Horsepower;
        }

        public void displayCarDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {year}, Fuel Type: {FuelType}, Horsepower: {Horsepower}");
        }
    }
}
