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
        // Fields
        public const int DisplayModeFullNameWithId = 2;
        private string id = string.Empty;
        private int displayMode;

        // Constructors
        public Student(string name)
            : base(name)
        {
        }

        public Student(string firstName, string lastName, string id)
            : base(firstName, lastName)
        {
            this.Id = id;
        }

        // Id property. It will be validate by the method Validate().
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
                    throw new Exception("You cannot have an empty ID nor characters other than numbers.");
                }
            }
        }

        // Name property. Get have a switch case to display the user choose. Set will split the information
        // in their respective fields and validate each one.
        public override string Name
        {
            get
            {
                // Switch case to return which diplay it will be used. It is using the DisplayMode proprety.
                switch (this.DisplayMode)
                {
                    case Person.DisplayModeFirstLastName:
                        return this.FirstName + " " + this.LastName;
                    case Person.DisplayModeLastCommaFirstName:
                        return this.FirstName + " " + this.LastName[0] + ".";
                    case DisplayModeFullNameWithId:
                        return this.LastName + ", " + this.FirstName + " (" + this.Id + ")";
                    default:
                        return "Invalid display mode!";
                }
            }

            set
            {
                try
                {
                    // Code to split the text.
                    char[] delim = { ',', '(' };
                    string[] splitComma = value.Split(delim[0]);
                    string[] splitParenthesis = splitComma[1].Split(delim[1]);

                    this.LastName = splitComma[0];
                    this.FirstName = splitParenthesis[0].Trim();

                    // Verify if there a closing parenthesis
                    Regex regex = new Regex(@"\)$");
                    if (regex.IsMatch(splitParenthesis[1]))
                    {
                        this.Id = splitParenthesis[1].TrimEnd(')');
                    }
                    else
                    {
                        throw new Exception("There is no closing parenthesis at the end");
                    }
                }

                // Catch errors, then throw the respective message(s) to the class or form that uses this.
                catch (Exception ex)
                {
                    if (!value.Contains(',') || !value.Contains('('))
                    {
                        if (!value.Contains(','))
                        {
                            throw new Exception("There is no comma in your text format.");
                        }

                        if (!value.Contains('('))
                        {
                            throw new Exception("The ID number format is invalid. This error is most likely caused if there is no open parenthesis before the ID.");
                        }
                    }
                    else
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        // DisplayMode Prorety. Validate the choice and if it is inbound
        public new int DisplayMode
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

        // Matches any string consisting entirely of one or more digits
        public bool Validate(string value)
        {
            Regex regex = new Regex(@"^\d+$");
            return regex.IsMatch(value);
        }
    }
}
