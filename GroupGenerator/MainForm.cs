using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace GroupGenerator
{
    public partial class MainForm : Form
    {
        private List<string>[] formGroups; // Should we initate it ?
        private BindingList<Student> students = new BindingList<Student>(); // BIDDING LIST ??? it s a requirement.
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

        private void ImportStudentsTextBoxButton_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(this, this.displayMode);
            importForm.ShowDialog();
            //TODO Display current list to import textbox.
        }

        private void CreateGroupsButton_Click(object sender, EventArgs e)
        {
            int nbrGroups;
            try
            {
                if (this.membersInAGroupRadioButton.Checked)
                {
                    nbrGroups = this.studentListBox.Items.Count / this.UserInputSize();
                    if (nbrGroups >= 1)
                    {
                        GroupResultsForm groupResultsFrom = new GroupResultsForm(this.NbrOfGroup(nbrGroups, this.students));
                        groupResultsFrom.ShowDialog();
                    }
                    else
                    {
                        throw new InvalidDataException($"There fewer students than the numbers of students in a group. You have {this.studentListBox.Items.Count} students.");
                    }
                }

                if (this.numberOfGroupsRadioButton.Checked)
                {
                    GroupResultsForm groupResultsForm = new GroupResultsForm(this.NbrOfGroup(this.UserInputSize(), this.students));
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

        private List<string>[] NbrOfGroup(int nbrGroups, BindingList<Student> stud)
        {
            this.formGroups = new List<string>[nbrGroups];

            // Initialize each group list
            for (int i = 0; i < nbrGroups; i++)
            {
                this.formGroups[i] = new List<string>();
            }

            int index = 0;

            foreach (string student in this.studentListBox.Items)
            {
                if (index < nbrGroups)
                {
                    this.formGroups[index].Add(student);
                    index++;
                }
                else
                {
                    index = 0;
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