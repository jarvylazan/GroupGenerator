namespace GroupGenerator
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Reflection;
    using System.Reflection.Metadata;

    public partial class MainForm : Form
    {
        private List<string>[] formGroups;
        private BindingList<Student> students = new BindingList<Student>();
        private int displayMode;

        public MainForm()
        {
            this.InitializeComponent();
        }

        public BindingList<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

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

        private void CreateGroupsButton_Click(object sender, EventArgs e)
        {
            int nbrGroups;
            try
            {
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

            foreach (string students in this.studentListBox.Items)
            {
                readyToShuffle.Add(students);
            }

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

        private void ClearStudentsButton_Click(object sender, EventArgs e)
        {
            this.studentListBox.Items.Clear();
            this.importStudentsTextBoxButton.Focus();
            this.students.Clear();
        }

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

        private void HideLastNameRadioButton_Clicked(object sender, EventArgs e)
        {
            this.studentListBox.Items.Clear();
            this.displayMode = Student.DisplayModeLastCommaFirstName;
            this.AddFormatDisplay(this.students, this.displayMode);
        }

        private void FullNameRadioButton_Clicked(object sender, EventArgs e)
        {
            this.studentListBox.Items.Clear();
            this.displayMode = Student.DisplayModeFirstLastName;
            this.AddFormatDisplay(this.students, this.displayMode);
        }

        private void NameWithStudentIdRadioButton_Clicked(object sender, EventArgs e)
        {
            this.studentListBox.Items.Clear();
            this.displayMode = Student.DisplayModeFullNameWithId;
            this.AddFormatDisplay(this.students, this.displayMode);
        }
    }
}