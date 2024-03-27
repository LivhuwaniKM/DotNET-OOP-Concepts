namespace OOPSconcepts.Inheritance
{
    public class Inheritance
    {
        public string EmployeeDetails()
        {
            Employee employee = new();
            string output = string.Format($"Inheritance Demo\n" +
                $"=============================\n" +
                $"First Name: {employee.FirstName}\n" +
                $"Last Name: {employee.LastName}\n" +
                $"Employee ID: {employee.EmployeeId}\n" +
                $"Company Name: {employee.CompanyName}");
            return output;
        }
    }

    // base/parent class
    class Person
    {
        public string FirstName { get; set; } = "Livhu";
        public string LastName { get; set; } = "Masindi";
    }

    // derived/child class
    class Employee : Person
    {
        public int EmployeeId { get; set; } = 123;
        public string CompanyName { get; set; } = "ABC123";
    }
}
