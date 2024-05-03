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
        private string id;
        private string name;
        private int displayModeFullNameWithId;

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

        public int DisplayModeFullNameWithId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private bool Validate(string value)
        {
            Regex regex = new Regex(@"^\d+$"); // Matches any string consisting entirely of one or more digits
            return regex.IsMatch(value);
        }
    }
}
