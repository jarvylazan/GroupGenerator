namespace GroupGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    internal class Student : Person, IDisplayConfig
    {
        private const int DisplayModeFullNameWithId = 2;
        private string id;
        private string name;

        public Student(string name, string id)
            : base(name)
        {
            this.Id = id;
        }

        public Student(string firstName, string lastName, string id)
            : base(firstName, lastName)
        {
            this.Id = id;
        }

        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (this.Validate(value))
                {
                    this.id = value;
                }
                else
                {
                    throw new Exception("You cannot have other things than numbers in your ID");
                }
            }
        }

        // public int DisplayModeFullNameWithId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Name
        {
            get
            {
                switch (Person.DisplayMode) // Need to see if we can extend the class to be able to have a third choice.
                {
                    case Person.DisplayModeFirstLastName:
                        return this.FirstName + " " + this.LastName;
                    case Person.DisplayModeLastCommaFirstName:
                        return this.LastName + ", " + this.FirstName;
                    case Student.DisplayModeFullNameWithId:
                        return this.Name; // Not the good return. need to look up.
                    default:
                        return "Invalid display mode!";
                }
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Validate(string value)
        {
            // Matches any string consisting entirely of one or more digits
            Regex regex = new Regex(@"^\d+$");
            return regex.IsMatch(value);
        }
    }
}
