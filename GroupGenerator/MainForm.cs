using System;

namespace GroupGenerator
{
    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>(); // Not sure if I keep it private ...
        private List<Student>[] formGroups;

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void ImportStudentsTextBoxButton_Click(object sender, EventArgs e)
        {
            string importedStudentsList = this.addStudentsTextBox.Text;
            char[] delim = { ',', '(' };
            var reader = new StringReader(importedStudentsList);
            string nameLine = reader.ReadLine();

            int count = 0;
            for (int i = 0; nameLine != null; i++)
            {
                Student entry = new Student(nameLine);
                count++;
            }

            try
            {
                string line = reader.ReadLine();
                string[] tokensComma = line.Split(delim[0]);
                string[] tokenFull = tokensComma[1].Split(delim[1]);

                string idComplete = tokenFull[1].Substring(1, tokenFull[1].Length - 2);

                Student entry = new Student(line);

                if (this.fullNameRadioButton.Checked)
                {
                    foreach (var item in tokenFull)
                    {

                    }

                    this.studentListBox.Items.Add(entry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateGroupsButton_Click(object sender, EventArgs e)
        {
            int nbrGroups;

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

            for (int i = 0; i < nbrGroups; i++)
            {
                this.formGroups[i] = new List<Student>(); // Initialize each group list
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