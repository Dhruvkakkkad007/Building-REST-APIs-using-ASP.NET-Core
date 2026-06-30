//6.Write a program to create a base class Vehicle and a derived class Car.
//Use exception handling to display an error message when the speed entered exceeds the permitted limit.

class SpeedException : Exception
{
    public SpeedException(string message) : base(message)
    {

    }
}

namespace Lab_5
{
     class Vehicle
    {
        public int vid;

        public Vehicle(int vid)
        {
            this.vid = vid;
        }

        public void displayVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {vid}");
        }
    }
    class Car : Vehicle
    {
        public int speed;

        public Car(int vid ,int speed) : base(vid)
        {
            this.speed = speed;
        }

        public void getSpeed(int speed)
        {
            if(speed > 135)
            {
                throw new SpeedException("Speed limit exceeded: Speed cannot be greater than 135.");
            }

            Console.WriteLine("Speed is Valid");
        }

    }
}
