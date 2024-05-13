namespace GroupGenerator
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Reflection;
    using System.Reflection.Metadata;

    public partial class MainForm : Form
    {
        // Fields
        private List<string>[] formGroups;
        private BindingList<Student> students = new BindingList<Student>();
        private int displayMode;

        // Constructor
        public MainForm()
        {
            this.InitializeComponent();
        }

        // Students proprety and throw and exception if the value if null.
        public BindingList<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Students list cannot be null.");
                }

                this.students = value;
            }
        }

        // AddFormatDisplay() Method. It takes to parameters one is a BindingList of Student
        // and the other one is an in which it the display mode.
        public void AddFormatDisplay(BindingList<Student> students, int displaymode)
        {
            foreach (Student student in students)
            {
                student.DisplayMode = displaymode;
                this.studentListBox.Items.Add(student.Name);
            }
        }

        // Button that loads in the form for importing the students.
        private void ImportStudentsTextBoxButton_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(this, this.displayMode);
            importForm.ShowDialog();
        }

        // Button that is creating the groups in the groupResultsForm
        private void CreateGroupsButton_Click(object sender, EventArgs e)
        {
            int nbrGroups;
            try
            {
                // If the RadioButton of creating groups with members is check it will use this part of the code to display in the GroupResultsForm.
                if (this.membersInAGroupRadioButton.Checked)
                {
                    nbrGroups = this.studentListBox.Items.Count / this.UserInputSize();

                    // Add an extra group if the number of students is not divisible by
                    // the number of members in a group the user desires.
                    if (this.studentListBox.Items.Count % this.UserInputSize() != 0)
                    {
                        nbrGroups++;
                    }

                    if (nbrGroups >= 1)
                    {
                        GroupResultsForm groupResultsFrom = new GroupResultsForm(this.NbrOfGroup(nbrGroups));
                        groupResultsFrom.ShowDialog();
                    }
                    else
                    {
                        throw new InvalidDataException($"There are fewer students than the numbers of students in a group. You have {this.studentListBox.Items.Count} students.");
                    }
                }

                // If the Number of group RadioButton is selected. It will use this part of the code to display in the GroupResultsForm.
                else if (this.numberOfGroupsRadioButton.Checked)
                {
                    GroupResultsForm groupResultsForm = new GroupResultsForm(this.NbrOfGroup(this.UserInputSize()));
                    groupResultsForm.ShowDialog();
                }
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This is a method take the user input from the TextBox and validate it and send it back as a int.
        private int UserInputSize()
        {
            int sizeGroups;
            if (int.TryParse(this.groupSizeTextBox.Text, out sizeGroups) && sizeGroups > 0)
            {
                return sizeGroups;
            }
            else
            {
                throw new InvalidDataException("You need to enter a int number above 0.");
            }
        }

        // This method gets the user input and creates an array of Students lists.
        private List<string>[] NbrOfGroup(int nbrGroups)
        {
            Random random = new Random();
            this.formGroups = new List<string>[nbrGroups];
            List<string> readyToShuffle = new List<string>();

            // Initialize each group list
            for (int i = 0; i < nbrGroups; i++)
            {
                this.formGroups[i] = new List<string>();
            }

            // Creating a list that we be use to get the shuffling
            foreach (string students in this.studentListBox.Items)
            {
                readyToShuffle.Add(students);
            }

            // If the Member in a group is selected it will create the array list accordingly.
            if (this.membersInAGroupRadioButton.Checked)
            {
                // The currentGroupSize variable ensures that there is a proper amount of students in a group.
                int index = 0;
                int currentGroupSize = 0;

                while (readyToShuffle.Count > 0)
                {
                    int picker = random.Next(0, readyToShuffle.Count);
                    if (currentGroupSize >= this.UserInputSize())
                    {
                        index = (index + 1) % nbrGroups;
                        currentGroupSize = 0;
                    }

                    this.formGroups[index].Add(readyToShuffle[picker]);
                    readyToShuffle.RemoveAt(picker);
                    currentGroupSize++;
                }
            }

            // IF the Number of group RadioButton is selected it will create the array of list accordingly.
            else if (this.numberOfGroupsRadioButton.Checked)
            {
                int index = 0;
                while (readyToShuffle.Count > 0)
                {
                    int picker = random.Next(0, readyToShuffle.Count);
                    this.formGroups[index].Add(readyToShuffle[picker]);
                    index = (index + 1) % nbrGroups;
                    readyToShuffle.RemoveAt(picker);
                }
            }

            return this.formGroups;
        }

        // It will clear all the student from the ListBox and also the student BidningList. Also set Focus to the Import Button.
        private void ClearStudentsButton_Click(object sender, EventArgs e)
        {
            this.studentListBox.Items.Clear();
            this.importStudentsTextBoxButton.Focus();
            this.students.Clear();
        }

        // It will delete a student from the ListBox and also from the index of the BindingList.
        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.studentListBox.SelectedIndex != -1)
                {
                    this.students.RemoveAt(this.studentListBox.SelectedIndex);
                    this.studentListBox.Items.RemoveAt(this.studentListBox.SelectedIndex);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("You did not select any student in the list to be deleted.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Display the Full Name without the ID in the StudentsListBox.
        private void HideLastNameRadioButton_Clicked(object sender, EventArgs e)
        {
            this.studentListBox.Items.Clear();
            this.displayMode = Student.DisplayModeLastCommaFirstName;
            this.AddFormatDisplay(this.students, this.displayMode);
        }

        // Display the FirstName and LastName first letter in this order without the Id in the StudentsListBox.
        private void FullNameRadioButton_Clicked(object sender, EventArgs e)
        {
            this.studentListBox.Items.Clear();
            this.displayMode = Student.DisplayModeFirstLastName;
            this.AddFormatDisplay(this.students, this.displayMode);
        }

        // Display the Last Name, FirstName and the Id in this order in the StudentsListBox.
        private void NameWithStudentIdRadioButton_Clicked(object sender, EventArgs e)
        {
            this.studentListBox.Items.Clear();
            this.displayMode = Student.DisplayModeFullNameWithId;
            this.AddFormatDisplay(this.students, this.displayMode);
        }
    }
}