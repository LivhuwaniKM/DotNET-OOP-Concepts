namespace OOPSconcepts.polymorphism
{
    public class Polymorphism
    {
        public class CalculateSalary
        {
            public double Salary { get; set; }
            public double Rate { get; set; }
            public int Overtime { get; set; }

            public double GetWage()
            {
                return Salary + Rate * Overtime;
            }
        }

        public string StructureOutput()
        {
            var output = $"Polymorphism Demo\n" +
                $"=========================\n";
            return output;
        }
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }

        public string Print()
        {
            CalculateSalary cs = new()
            {
                Salary = 30000,
                Rate = 8,
                Overtime = 15
            };

            var output = StructureOutput();

            output += $"Salary: {cs.Salary}\n" +
                $"Rate: {cs.Rate}\n" +
                $"Overtime: {cs.Overtime}\n" +
                $"=========================\n" +
                $"Calculated Salary: {cs.GetWage()}";

            return output;
        }

        public string Print(string str1, string str2)
        {
            var output = StructureOutput();
            output += $"First Name: {str1}\n" +
                $"Last Name: {str2}";

            return output;
        }

        public string Print(string str1, string str2, string str3)
        {
            string output = StructureOutput();

            output += $"First Name: {str1}\nMiddle Name: {str2}\nLast Name: {str3}";

            return output;
        }

        public void Print(int a, string str)
        {
            Console.WriteLine($"{a}, {str}");
        }

        public void Print(string str, int a)
        {
            Console.WriteLine($"{a}, {str}");
        }
    }
}
