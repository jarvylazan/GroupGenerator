namespace GroupGenerator
{
    public partial class MainForm : Form
    {
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
    }
}