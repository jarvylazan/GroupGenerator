using System;
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
    public partial class GroupResultsForm : Form
    {
        private List<string>[] groups;

        public GroupResultsForm(List<string>[] group)
        {
            this.InitializeComponent();
            this.groups = group;
        }

        private void GroupResultsForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.groups.Length; i++)
            {
                this.GroupsListView.Items.Add("Group " + (i + 1) + ":");
                foreach (string student in this.groups[i])
                {
                    this.GroupsListView.Items.Add(student);
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
