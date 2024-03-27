namespace OOPSconcepts.SolidPrinciples._3_LSP
{
    // Liskov Substitution Responsibility
    public class LSP
    {
        // main project hub
        public static void Main()
        {
            Car car = new();

            Garage garage = new();

            garage.OperateVehicle(car);
        }
    }

    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Engine stop");
        }
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }

    public class Garage
    {
        public void OperateVehicle(Vehicle vehicle)
        {
            vehicle.StartEngine();

            vehicle.StopEngine();
        }
    }
}
