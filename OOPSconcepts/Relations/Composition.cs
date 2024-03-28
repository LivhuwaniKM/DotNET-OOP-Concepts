namespace OOPSconcepts.Relations
{
    public class Composition
    {
        public string Main()
        {
            var vehicle = GetVehicle();
            var description = GetVehicleAndDescription();

            var displayOutput = (
                $"==============================\n" +
                $"Class Relations: Composition\n" +
                $"==============================\n\n" +
                $"Vehicle\n" +
                $"------------------------------\n" +
                $"Vin: {vehicle.Vin}\n" +
                $"Model: {vehicle.Model}\n" +
                $"Make: {vehicle.Make}\n" +
                $"Code: {vehicle.Code}\n" +
                $"Year: {vehicle.Year}\n" +
                $"Fuel: {vehicle.FuelType}\n" +
                $"\nVehicle Details\n" +
                $"------------------------------\n" +
                $"Color: {description.Description.Color}\n" +
                $"Tyre Size: {description.Description.TyreSize}\n" +
                $"Transmission: {description.Description.Transmission}\n" +
                $"Turbo: {description.Description.Turbo}"
            );
            return displayOutput;
        }

        public Vehicle GetVehicle()
        {
            return new()
            {
                Vin = "ABC123456789",
                Model = "200E",
                Make = "Mecredes Benz",
                Code = "W201",
                Year = DateTime.Now,
                FuelType = "Petrol"
            };
        }

        public Vehicle GetVehicleAndDescription()
        {
            var vehicle = GetVehicle();

            vehicle.Description = new()
            {
                Vin = vehicle.Vin,
                Color = "Candy apple blue",
                TyreSize = "145/50 R15",
                Transmission = "Manual",
                Turbo = true
            };
            return vehicle;
        }
    }

    public class Vehicle
    {
        public string Vin { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Make { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public DateTime Year { get; set; }
        public string FuelType { get; set; } = string.Empty;

        public Description? Description;
    }

    public class Description
    {
        public string Vin { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string TyreSize { get; set; } = string.Empty;
        public string Transmission { get; set; } = string.Empty;
        public bool Turbo { get; set; } = false;
    }
}