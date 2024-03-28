namespace OOPSconcepts.Relations
{
    public class Association
    {
        public string Main()
        {
            Car car = GetCar();
            var carDescription = CreateDisplayForCar(car);

            var output =
                $"==============================\n" +
                $"Class Relations: Association\n" +
                $"==============================\n" +
                $"\n{carDescription}";

            return output;
        }

        public Car GetCar()
        {
            return new()
            {
                Id = 1,
                Model = "300CE",
                Make = "Mercedes Benz",
                Code = "W124",
                Year = DateTime.Now,
                FuelType = "Petrol"
            };
        }

        public string CreateDisplayForCar(Car car)
        {
            var displayOutput = (
                $"Car Properties\n" +
                $"------------------------------\n" +
                $"Model: {car.Model}\n" +
                $"Make: {car.Make}\n" +
                $"Year: {car.Year}\n" +
                $"Fuel: {car.FuelType}"
            );
            return displayOutput;
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public string Make { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public DateTime Year { get; set; }
        public string FuelType { get; set; } = string.Empty;
    }
}
