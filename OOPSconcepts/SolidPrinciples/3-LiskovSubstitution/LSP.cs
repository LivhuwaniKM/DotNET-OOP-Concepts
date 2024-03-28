namespace OOPSconcepts.SolidPrinciples._3_LSP
{
    public class LSP
    {
        public string Main()
        {
            Vehicle vehicle = new();
            Car car = new();
            Garage garage = new();

            var interchangeableClassOutput = garage.OperateVehicle(car);

            return
                $"============================================\n" +
                $"Liskov Substitution Responsibility\n" +
                $"============================================\n\n" +
                $"{vehicle.StartEngine()} - [from Vehicle class]\n" +
                $"{vehicle.StopEngine()} - [from Vehicle class]\n\n" +
                $"{car.StartEngine()} - [from Car class]\n" +
                $"{car.StopEngine()} - [from Car class]\n\n" +
                $"{interchangeableClassOutput}";
        }
    }

    public class Vehicle
    {
        public virtual string StartEngine()
        {
            return "Engine started";
        }

        public virtual string StopEngine()
        {
            return "Engine stop";
        }
    }

    public class Car : Vehicle
    {
        public override string StartEngine()
        {
            return "Car engine started";
        }

        public override string StopEngine()
        {
            return "Car engine stopped";
        }
    }

    public class Garage
    {
        public string OperateVehicle(Vehicle vehicle)
        {
            return
                $"{vehicle.StartEngine()} - [from Garage class]\n" +
                $"{vehicle.StopEngine()} - [from Garage class]";
        }
    }
}
