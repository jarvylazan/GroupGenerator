namespace GroupGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentListBox = new ListBox();
            nameFormatSelectionGroupBox = new GroupBox();
            nameWithStudentIdRadioButton = new RadioButton();
            fullNameRadioButton = new RadioButton();
            hideLastNameRadioButton = new RadioButton();
            label1 = new Label();
            importStudentsTextBoxButton = new Button();
            deleteStudentButton = new Button();
            clearStudentsButton = new Button();
            groupingGroupBox = new GroupBox();
            numberOfGroupsRadioButton = new RadioButton();
            membersInAGroupRadioButton = new RadioButton();
            groupSizeLabel = new Label();
            groupSizeTextBox = new TextBox();
            createGroupsButton = new Button();
            nameFormatSelectionGroupBox.SuspendLayout();
            groupingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 15;
            studentListBox.Location = new Point(6, 6);
            studentListBox.Margin = new Padding(2, 1, 2, 1);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(231, 469);
            studentListBox.TabIndex = 0;
            // 
            // nameFormatSelectionGroupBox
            // 
            nameFormatSelectionGroupBox.Controls.Add(nameWithStudentIdRadioButton);
            nameFormatSelectionGroupBox.Controls.Add(fullNameRadioButton);
            nameFormatSelectionGroupBox.Controls.Add(hideLastNameRadioButton);
            nameFormatSelectionGroupBox.Location = new Point(259, 101);
            nameFormatSelectionGroupBox.Margin = new Padding(2, 1, 2, 1);
            nameFormatSelectionGroupBox.Name = "nameFormatSelectionGroupBox";
            nameFormatSelectionGroupBox.Padding = new Padding(2, 1, 2, 1);
            nameFormatSelectionGroupBox.Size = new Size(215, 86);
            nameFormatSelectionGroupBox.TabIndex = 1;
            nameFormatSelectionGroupBox.TabStop = false;
            nameFormatSelectionGroupBox.Text = "Choose your name format";
            // 
            // nameWithStudentIdRadioButton
            // 
            nameWithStudentIdRadioButton.AutoSize = true;
            nameWithStudentIdRadioButton.Location = new Point(11, 57);
            nameWithStudentIdRadioButton.Margin = new Padding(2, 1, 2, 1);
            nameWithStudentIdRadioButton.Name = "nameWithStudentIdRadioButton";
            nameWithStudentIdRadioButton.Size = new Size(163, 19);
            nameWithStudentIdRadioButton.TabIndex = 2;
            nameWithStudentIdRadioButton.Text = "Full Name with Student ID";
            nameWithStudentIdRadioButton.UseVisualStyleBackColor = true;
            nameWithStudentIdRadioButton.Click += NameWithStudentIdRadioButton_Clicked;
            // 
            // fullNameRadioButton
            // 
            fullNameRadioButton.AutoSize = true;
            fullNameRadioButton.Checked = true;
            fullNameRadioButton.Location = new Point(11, 15);
            fullNameRadioButton.Margin = new Padding(2, 1, 2, 1);
            fullNameRadioButton.Name = "fullNameRadioButton";
            fullNameRadioButton.Size = new Size(79, 19);
            fullNameRadioButton.TabIndex = 1;
            fullNameRadioButton.TabStop = true;
            fullNameRadioButton.Text = "Full Name";
            fullNameRadioButton.UseVisualStyleBackColor = true;
            fullNameRadioButton.Click += FullNameRadioButton_Clicked;
            // 
            // hideLastNameRadioButton
            // 
            hideLastNameRadioButton.AutoSize = true;
            hideLastNameRadioButton.Location = new Point(11, 36);
            hideLastNameRadioButton.Margin = new Padding(2, 1, 2, 1);
            hideLastNameRadioButton.Name = "hideLastNameRadioButton";
            hideLastNameRadioButton.Size = new Size(132, 19);
            hideLastNameRadioButton.TabIndex = 0;
            hideLastNameRadioButton.Text = "Last Name as Initials";
            hideLastNameRadioButton.UseVisualStyleBackColor = true;
            hideLastNameRadioButton.Click += HideLastNameRadioButton_Clicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(259, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 2;
            label1.Text = "Upload your list first:";
            // 
            // importStudentsTextBoxButton
            // 
            importStudentsTextBoxButton.Location = new Point(259, 51);
            importStudentsTextBoxButton.Margin = new Padding(2, 1, 2, 1);
            importStudentsTextBoxButton.Name = "importStudentsTextBoxButton";
            importStudentsTextBoxButton.Size = new Size(215, 29);
            importStudentsTextBoxButton.TabIndex = 4;
            importStudentsTextBoxButton.Text = "Import a list";
            importStudentsTextBoxButton.UseVisualStyleBackColor = true;
            importStudentsTextBoxButton.Click += ImportStudentsTextBoxButton_Click;
            // 
            // deleteStudentButton
            // 
            deleteStudentButton.Location = new Point(259, 204);
            deleteStudentButton.Margin = new Padding(2, 1, 2, 1);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(105, 29);
            deleteStudentButton.TabIndex = 5;
            deleteStudentButton.Text = "Delete a Student";
            deleteStudentButton.UseVisualStyleBackColor = true;
            deleteStudentButton.Click += DeleteStudentButton_Click;
            // 
            // clearStudentsButton
            // 
            clearStudentsButton.Location = new Point(371, 204);
            clearStudentsButton.Margin = new Padding(2, 1, 2, 1);
            clearStudentsButton.Name = "clearStudentsButton";
            clearStudentsButton.Size = new Size(105, 29);
            clearStudentsButton.TabIndex = 6;
            clearStudentsButton.Text = "Clear All";
            clearStudentsButton.UseVisualStyleBackColor = true;
            clearStudentsButton.Click += ClearStudentsButton_Click;
            // 
            // groupingGroupBox
            // 
            groupingGroupBox.Controls.Add(numberOfGroupsRadioButton);
            groupingGroupBox.Controls.Add(membersInAGroupRadioButton);
            groupingGroupBox.Location = new Point(264, 269);
            groupingGroupBox.Margin = new Padding(2, 1, 2, 1);
            groupingGroupBox.Name = "groupingGroupBox";
            groupingGroupBox.Padding = new Padding(2, 1, 2, 1);
            groupingGroupBox.Size = new Size(212, 85);
            groupingGroupBox.TabIndex = 7;
            groupingGroupBox.TabStop = false;
            groupingGroupBox.Text = "Choose your group formation";
            // 
            // numberOfGroupsRadioButton
            // 
            numberOfGroupsRadioButton.AutoSize = true;
            numberOfGroupsRadioButton.Location = new Point(8, 45);
            numberOfGroupsRadioButton.Margin = new Padding(2, 1, 2, 1);
            numberOfGroupsRadioButton.Name = "numberOfGroupsRadioButton";
            numberOfGroupsRadioButton.Size = new Size(169, 19);
            numberOfGroupsRadioButton.TabIndex = 1;
            numberOfGroupsRadioButton.Text = "Number of groups to make";
            numberOfGroupsRadioButton.UseVisualStyleBackColor = true;
            // 
            // membersInAGroupRadioButton
            // 
            membersInAGroupRadioButton.AutoSize = true;
            membersInAGroupRadioButton.Checked = true;
            membersInAGroupRadioButton.Location = new Point(8, 25);
            membersInAGroupRadioButton.Margin = new Padding(2, 1, 2, 1);
            membersInAGroupRadioButton.Name = "membersInAGroupRadioButton";
            membersInAGroupRadioButton.Size = new Size(193, 19);
            membersInAGroupRadioButton.TabIndex = 0;
            membersInAGroupRadioButton.TabStop = true;
            membersInAGroupRadioButton.Text = "Number of members in a group";
            membersInAGroupRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupSizeLabel
            // 
            groupSizeLabel.AutoSize = true;
            groupSizeLabel.Location = new Point(319, 371);
            groupSizeLabel.Margin = new Padding(2, 0, 2, 0);
            groupSizeLabel.Name = "groupSizeLabel";
            groupSizeLabel.Size = new Size(30, 15);
            groupSizeLabel.TabIndex = 8;
            groupSizeLabel.Text = "Size:";
            // 
            // groupSizeTextBox
            // 
            groupSizeTextBox.Location = new Point(362, 371);
            groupSizeTextBox.Margin = new Padding(2, 1, 2, 1);
            groupSizeTextBox.Name = "groupSizeTextBox";
            groupSizeTextBox.Size = new Size(49, 23);
            groupSizeTextBox.TabIndex = 9;
            // 
            // createGroupsButton
            // 
            createGroupsButton.Location = new Point(259, 409);
            createGroupsButton.Margin = new Padding(2, 1, 2, 1);
            createGroupsButton.Name = "createGroupsButton";
            createGroupsButton.Size = new Size(215, 42);
            createGroupsButton.TabIndex = 10;
            createGroupsButton.Text = "Create Group";
            createGroupsButton.UseVisualStyleBackColor = true;
            createGroupsButton.Click += CreateGroupsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 487);
            Controls.Add(createGroupsButton);
            Controls.Add(groupSizeTextBox);
            Controls.Add(nameFormatSelectionGroupBox);
            Controls.Add(groupSizeLabel);
            Controls.Add(groupingGroupBox);
            Controls.Add(clearStudentsButton);
            Controls.Add(deleteStudentButton);
            Controls.Add(importStudentsTextBoxButton);
            Controls.Add(label1);
            Controls.Add(studentListBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainForm";
            Text = "Group Generator";
            nameFormatSelectionGroupBox.ResumeLayout(false);
            nameFormatSelectionGroupBox.PerformLayout();
            groupingGroupBox.ResumeLayout(false);
            groupingGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox nameFormatSelectionGroupBox;
        private RadioButton nameWithStudentIdRadioButton;
        private RadioButton fullNameRadioButton;
        private RadioButton hideLastNameRadioButton;
        private Label label1;
        private Button importStudentsTextBoxButton;
        private Button deleteStudentButton;
        private Button clearStudentsButton;
        private GroupBox groupingGroupBox;
        private RadioButton numberOfGroupsRadioButton;
        private RadioButton membersInAGroupRadioButton;
        private Label groupSizeLabel;
        private TextBox groupSizeTextBox;
        private Button createGroupsButton;
        public ListBox studentListBox;
    }
}