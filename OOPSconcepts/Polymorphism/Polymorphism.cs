namespace OOPSconcepts.polymorphism
{
    public class Polymorphism
    {
        public string Main()
        {
            SalaryModel salaryModel = CreateSalaryModel();

            var historyOfCoding = Print(1950);

            var calcualteSalary = Print(salaryModel);

            var codingQuote = Print(
                "Bjarne Stroustrup",
                "C makes it easy to shoot yourself in the foot; C++ makes it harder, but when you do, it blows away your whole leg."
                );

            var output =
                $"==============================\n" +
                $"Polymorphism Demo\n" +
                $"==============================\n\n" +
                $"{historyOfCoding}\n\n\n" +
                $"{calcualteSalary}\n\n\n" +
                $"{codingQuote}";

            return output;
        }

        public SalaryModel CreateSalaryModel()
        {
            return new()
            {
                Salary = 30000,
                Rate = 22.44,
                Overtime = 15
            };
        }

        public string Print(int year)
        {
            return $"Example 1:\n\n" +
                $"The history of programming dates back to the early 19th century when mathematician Ada Lovelace created an algorithm for Charles Babbage's Analytical Engine, which is considered the first computer. However, the first actual programming language was developed in the {year}s, called FORTRAN.";
        }

        public string Print(SalaryModel obj)
        {
            return $"Example 2:\n\n" +
                $"Salary: {obj.Salary}\n" +
                $"Rate: {obj.Rate}\n" +
                $"Overtime: {obj.Overtime}\n" +
                $"----------------\n" +
                $"Total: R {obj.GetWage()}";
        }

        public string Print(string author, string quote)
        {
            return
                $"Example 3:\n\n" +
                $"{quote}\n" +
                $"- {author}";
        }
    }

    public class SalaryModel
    {
        public double Salary { get; set; }
        public double Rate { get; set; }
        public int Overtime { get; set; }

        public double GetWage() =>
            Salary + Rate * Overtime;
    }
}
