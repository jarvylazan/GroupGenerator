﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupGenerator
{
    public partial class ImportForm : Form
    {
        private List<Student> students = new List<Student>();
        private MainForm mainForm;

        public ImportForm(MainForm mainForm)
        {
            this.InitializeComponent();
            this.mainForm = mainForm;
        }

        private void ImportAndCloseButton_CLick(object sender, EventArgs e)
        {
            string[] names = this.importTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in names)
            {
                Student tmpStudent = new Student(name);
                this.students.Add(tmpStudent);
                this.mainForm.studentListBox.Items.Add(name);
            }

            this.mainForm.Students = this.students;
            this.Close();
        }
    }
}
