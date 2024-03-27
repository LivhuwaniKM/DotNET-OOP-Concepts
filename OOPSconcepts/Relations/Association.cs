namespace OOPSconcepts.Relations
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public string Make { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public DateTime Year { get; set; }
        public string FuelType { get; set; } = string.Empty;
    }

    public class CarRepository
    {
        public Car GetCar()
        {
            return new()
            {
                Id = 1,
                Model = "300CE",
                Make = "Mercedes Benz",
                Code = "W124",
                Year = DateTime.Parse("1991"),
                FuelType = "Petrol"
            };
        }
        public void SaveCar()
        {
            // Insert any logic for db queries if any
            Console.WriteLine($"Request has been processed succesfully");
        }

        public string DisplayCar()
        {
            var car = GetCar();
            var displayOutput = (
                $"Car Properties\n" +
                $"==================\n" +
                $"Model: {car.Model}\n" +
                $"Make: {car.Make}\n" +
                $"Year: {car.Year}\n" +
                $"Fuel: {car.FuelType}"
            );
            return displayOutput;
        }
    }
}
