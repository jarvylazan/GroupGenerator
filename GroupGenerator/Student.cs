namespace GroupGenerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Design;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Student : Person, IDisplayConfig
    {
        private const int DisplayModeFullNameWithId = 2;
        private string id;
        private string name;
        private int displayMode = DisplayModeFirstLastName;
        char[] delim = { ',', '(' };

        public Student(string name)
            : base(name)
        {
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
                switch (Person.DisplayMode)
                {
                    case Person.DisplayModeFirstLastName:
                        return this.FirstName + " " + this.LastName;
                    case Person.DisplayModeLastCommaFirstName:
                        return this.FirstName + " " + this.LastName[0] + ".";
                    case DisplayModeFullNameWithId:
                        return this.LastName + "," + this.FirstName + "(" + this.Id + ")";
                    default:
                        return "Invalid display mode!";
                }
            }

            set
            {
                if (value.Contains(','))
                {
                    string[] nameParts = value.Trim().Split(',');
                    this.FirstName = nameParts[1].Trim();
                    string firstNameAndID = nameParts[1].Trim();
                    string[] tokensComma = firstNameAndID.Split(this.delim[1]);
                    this.LastName = nameParts[0].Trim();
                    this.id = nameParts[1].Trim(); // should be index 2
                }
                else
                {
                    try
                    {
                        string[] splitComma = value.Split(this.delim[0]);
                        string[] splitParenthesis = splitComma[1].Split(this.delim[1]);

                        this.LastName = splitComma[0];
                        this.FirstName = splitParenthesis[0];
                        this.id = splitParenthesis[1].TrimEnd(')');
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public int DisplayMode
        {
            get
            {
                return this.displayMode;
            }

            set
            {
                if (value < 0 || value > 2)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                this.displayMode = value;
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
