using System;

namespace GroupGenerator
{
    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>();
        private List<Student>[] formGroups;

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void ImportStudentsTextBoxButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateGroupsButton_Click(object sender, EventArgs e)
        {
            int nbrGroups;
            try
            {
                if (this.membersInAGroupRadioButton.Checked)
                {
                    nbrGroups = this.studentListBox.Items.Count / this.UserInputSize();
                    GroupResultsForm groupResultsFrom = new GroupResultsForm(this.NbrOfGroup(nbrGroups, this.students));
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

        private List<Student>[] NbrOfGroup(int nbrGroups, List<Student> stud)
        {
            this.formGroups = new List<Student>[nbrGroups];

            // Initialize each group list
            for (int i = 0; i < nbrGroups; i++)
            {
                this.formGroups[i] = new List<Student>(); 
            }

            int index = 0;

            foreach (Student student in stud)
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
    }
}