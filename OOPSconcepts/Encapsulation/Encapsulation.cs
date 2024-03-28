namespace OOPSconcepts.Encapsulation
{
    public class Encapsulation
    {
        public string Main()
        {
            UserDetails user = new()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            string output =
                $"==========================\n" +
                $"Encapsulation Demo\n" +
                $"==========================\n" +
                $"Full Name: {user.FirstName} {user.LastName}";

            return output;
        }
    }

    public class UserDetails
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName()
        {
            return string.Format($"{FirstName} {LastName}");
        }
    }
}