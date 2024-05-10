﻿namespace GroupGenerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class ImportForm : Form
    {
        private BindingList<Student> students = new BindingList<Student>();
        private MainForm mainForm;
        private int displayMode;

        public ImportForm(MainForm mainForm, int displayMode)
        {
            this.InitializeComponent();
            this.mainForm = mainForm;
            this.displayMode = displayMode;
        }

        private void ImportAndCloseButton_CLick(object sender, EventArgs e)
        {
            string[] names = this.importTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            this.mainForm.studentListBox.Items.Clear();

            foreach (string name in names)
            {
                Student tmpStudent = new Student(name);
                this.students.Add(tmpStudent);
            }

            this.mainForm.AddFormatDisplay(this.students, this.displayMode);
            this.mainForm.Students = this.students;
            this.Close();
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            if (this.mainForm.studentListBox.Items != null)
            {
                foreach (Student student in this.mainForm.Students)
                {
                    student.DisplayMode = 2;
                    this.importTextBox.Text += student.Name.ToString() + "\r\n";
                }
            }
        }
    }
}
