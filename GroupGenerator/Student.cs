﻿namespace GroupGenerator
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
        // In the description of the task:  Create student groups in different sizes !randomly!
        // Task 7. Research how to use a BindingList with a ListBox. ( we need to make those two work togeter)
        // Task 8. Organize your instances of the Student class in a BindingList for easier management with a ListBox.
        //         -That is what you send to the teacher: Display all the imported users - BindingList with a ListBox.
        // Commenting our code
        // Finishing the UML (my part)

        public const int DisplayModeFullNameWithId = 2;
        private string id = string.Empty;
        private int displayMode;
        private char[] delim = { ',', '(' };

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
                    throw new Exception("You cannot have an empty ID nor characters other than numbers.");
                }
            }
        }

        public override string Name
        {
            get
            {
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
                    // Catch error when there is no comma or open parenthesis.
                    string[] splitComma = value.Split(this.delim[0]);
                    string[] splitParenthesis = splitComma[1].Split(this.delim[1]);

                    this.LastName = splitComma[0];
                    this.FirstName = splitParenthesis[0].Trim();
                    this.Id = splitParenthesis[1].TrimEnd(')');
                }
                catch (Exception ex)
                {
                    if (!value.Contains(',') || !value.Contains('('))
                    {
                        if (!value.Contains(','))
                        {
                            MessageBox.Show("There is no comma in your text format.");
                        }

                        if (!value.Contains('('))
                        {
                            MessageBox.Show("The ID number format is invalid. This error is most likely caused if there is no open parenthesis before the ID.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

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

        public bool Validate(string value)
        {
            // Matches any string consisting entirely of one or more digits
            Regex regex = new Regex(@"^\d+$");
            return regex.IsMatch(value);
        }
    }
}
