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
                        // Catch error when there is no comma or open parenthesis.
                        string[] splitComma = value.Split(delim[0]);
                        string[] splitParenthesis = splitComma[1].Split(delim[1]);

                        LastName = splitComma[0];
                        FirstName = splitParenthesis[0].Trim();
                        id = splitParenthesis[1].TrimEnd(')');

                        Console.WriteLine(LastName);
                        Console.WriteLine(FirstName);
                        Console.WriteLine(id);
                    }
                    catch (Exception ex)
                    {
                        if (!value.Contains(',') || !value.Contains('('))
                        {
                            if (!value.Contains(','))
                            {
                                Console.WriteLine("There is no comma in your text format.");
                            }

                            if (!value.Contains('('))
                            {
                                Console.WriteLine("The ID number format is invalid. This error is most likely caused if there is no open parenthesis before the ID.");
                            }
                        }
                        else
                        {
                            Console.WriteLine(ex.Message);
                        }
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
