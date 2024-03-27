namespace OOPSconcepts.Encapsulation
{
    public class Encapsulation
    {
        private string _firstName = string.Empty;
        private string _middleName = string.Empty;
        private string _lastName = string.Empty;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName()
        {
            return string.Format($"{FirstName} {MiddleName} {LastName}");
        }
    }

    public class AccessUser
    {
        public string Details()
        {
            Encapsulation user = new()
            {
                FirstName = "Livhuwani",
                MiddleName = "Khathutshelo",
                LastName = "Masindi"
            };

            return user.FullName();
        }
    }
}