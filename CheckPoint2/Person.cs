using System;
using System.Text;

namespace CheckPoint2
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;

        public Person()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthDate = DateTime.Now;
        }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

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
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public int BirstYear
        {
            get { return _birthDate.Year; }
            set { _birthDate = new DateTime(_birthDate.Day, _birthDate.Month, value); }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First name - {FirstName}");
            sb.AppendLine($"Last name - {LastName}");
            sb.AppendLine($"Date of birth - {BirthDate.ToString()}");

            return sb.ToString();
        }

        public virtual string ToShortString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
