using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class Patient
    {
        int ID;
        string Name;
        int Age;
        string Disease;


        public Patient(int ID, string Name, int Age, string Disease)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
            this.Disease = Disease;
        }

        public void displayPatientDetails()
        {
            Console.WriteLine($"Patient ID: {ID}, Name: {Name}, Age: {Age}, Disease: {Disease}");
        }
    }
}
