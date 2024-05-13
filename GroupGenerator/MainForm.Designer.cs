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
            studentListBox.ItemHeight = 32;
            studentListBox.Location = new Point(11, 13);
            studentListBox.Margin = new Padding(4, 2, 4, 2);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(426, 996);
            studentListBox.TabIndex = 0;
            // 
            // nameFormatSelectionGroupBox
            // 
            nameFormatSelectionGroupBox.Controls.Add(nameWithStudentIdRadioButton);
            nameFormatSelectionGroupBox.Controls.Add(fullNameRadioButton);
            nameFormatSelectionGroupBox.Controls.Add(hideLastNameRadioButton);
            nameFormatSelectionGroupBox.Location = new Point(481, 215);
            nameFormatSelectionGroupBox.Margin = new Padding(4, 2, 4, 2);
            nameFormatSelectionGroupBox.Name = "nameFormatSelectionGroupBox";
            nameFormatSelectionGroupBox.Padding = new Padding(4, 2, 4, 2);
            nameFormatSelectionGroupBox.Size = new Size(399, 183);
            nameFormatSelectionGroupBox.TabIndex = 1;
            nameFormatSelectionGroupBox.TabStop = false;
            nameFormatSelectionGroupBox.Text = "Choose your name format";
            // 
            // nameWithStudentIdRadioButton
            // 
            nameWithStudentIdRadioButton.AutoSize = true;
            nameWithStudentIdRadioButton.Location = new Point(20, 122);
            nameWithStudentIdRadioButton.Margin = new Padding(4, 2, 4, 2);
            nameWithStudentIdRadioButton.Name = "nameWithStudentIdRadioButton";
            nameWithStudentIdRadioButton.Size = new Size(326, 36);
            nameWithStudentIdRadioButton.TabIndex = 2;
            nameWithStudentIdRadioButton.Text = "Full Name with Student ID";
            nameWithStudentIdRadioButton.UseVisualStyleBackColor = true;
            nameWithStudentIdRadioButton.Click += NameWithStudentIdRadioButton_Clicked;
            // 
            // fullNameRadioButton
            // 
            fullNameRadioButton.AutoSize = true;
            fullNameRadioButton.Checked = true;
            fullNameRadioButton.Location = new Point(20, 32);
            fullNameRadioButton.Margin = new Padding(4, 2, 4, 2);
            fullNameRadioButton.Name = "fullNameRadioButton";
            fullNameRadioButton.Size = new Size(154, 36);
            fullNameRadioButton.TabIndex = 1;
            fullNameRadioButton.TabStop = true;
            fullNameRadioButton.Text = "Full Name";
            fullNameRadioButton.UseVisualStyleBackColor = true;
            fullNameRadioButton.Click += FullNameRadioButton_Clicked;
            // 
            // hideLastNameRadioButton
            // 
            hideLastNameRadioButton.AutoSize = true;
            hideLastNameRadioButton.Location = new Point(20, 77);
            hideLastNameRadioButton.Margin = new Padding(4, 2, 4, 2);
            hideLastNameRadioButton.Name = "hideLastNameRadioButton";
            hideLastNameRadioButton.Size = new Size(261, 36);
            hideLastNameRadioButton.TabIndex = 0;
            hideLastNameRadioButton.Text = "Last Name as Initials";
            hideLastNameRadioButton.UseVisualStyleBackColor = true;
            hideLastNameRadioButton.Click += HideLastNameRadioButton_Clicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(481, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(315, 45);
            label1.TabIndex = 2;
            label1.Text = "Upload your list first:";
            // 
            // importStudentsTextBoxButton
            // 
            importStudentsTextBoxButton.Location = new Point(481, 109);
            importStudentsTextBoxButton.Margin = new Padding(4, 2, 4, 2);
            importStudentsTextBoxButton.Name = "importStudentsTextBoxButton";
            importStudentsTextBoxButton.Size = new Size(399, 62);
            importStudentsTextBoxButton.TabIndex = 4;
            importStudentsTextBoxButton.Text = "Import a list";
            importStudentsTextBoxButton.UseVisualStyleBackColor = true;
            importStudentsTextBoxButton.Click += ImportStudentsTextBoxButton_Click;
            // 
            // deleteStudentButton
            // 
            deleteStudentButton.Location = new Point(481, 402);
            deleteStudentButton.Margin = new Padding(4, 2, 4, 2);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(195, 76);
            deleteStudentButton.TabIndex = 5;
            deleteStudentButton.Text = "Delete Student";
            deleteStudentButton.UseVisualStyleBackColor = true;
            deleteStudentButton.Click += DeleteStudentButton_Click;
            // 
            // clearStudentsButton
            // 
            clearStudentsButton.Location = new Point(684, 402);
            clearStudentsButton.Margin = new Padding(4, 2, 4, 2);
            clearStudentsButton.Name = "clearStudentsButton";
            clearStudentsButton.Size = new Size(195, 76);
            clearStudentsButton.TabIndex = 6;
            clearStudentsButton.Text = "Clear List";
            clearStudentsButton.UseVisualStyleBackColor = true;
            clearStudentsButton.Click += ClearStudentsButton_Click;
            // 
            // groupingGroupBox
            // 
            groupingGroupBox.Controls.Add(numberOfGroupsRadioButton);
            groupingGroupBox.Controls.Add(membersInAGroupRadioButton);
            groupingGroupBox.Location = new Point(481, 548);
            groupingGroupBox.Margin = new Padding(4, 2, 4, 2);
            groupingGroupBox.Name = "groupingGroupBox";
            groupingGroupBox.Padding = new Padding(4, 2, 4, 2);
            groupingGroupBox.Size = new Size(403, 181);
            groupingGroupBox.TabIndex = 7;
            groupingGroupBox.TabStop = false;
            groupingGroupBox.Text = "Choose your group formation";
            // 
            // numberOfGroupsRadioButton
            // 
            numberOfGroupsRadioButton.AutoSize = true;
            numberOfGroupsRadioButton.Location = new Point(15, 96);
            numberOfGroupsRadioButton.Margin = new Padding(4, 2, 4, 2);
            numberOfGroupsRadioButton.Name = "numberOfGroupsRadioButton";
            numberOfGroupsRadioButton.Size = new Size(337, 36);
            numberOfGroupsRadioButton.TabIndex = 1;
            numberOfGroupsRadioButton.Text = "Number of groups to make";
            numberOfGroupsRadioButton.UseVisualStyleBackColor = true;
            // 
            // membersInAGroupRadioButton
            // 
            membersInAGroupRadioButton.AutoSize = true;
            membersInAGroupRadioButton.Checked = true;
            membersInAGroupRadioButton.Location = new Point(15, 53);
            membersInAGroupRadioButton.Margin = new Padding(4, 2, 4, 2);
            membersInAGroupRadioButton.Name = "membersInAGroupRadioButton";
            membersInAGroupRadioButton.Size = new Size(386, 36);
            membersInAGroupRadioButton.TabIndex = 0;
            membersInAGroupRadioButton.TabStop = true;
            membersInAGroupRadioButton.Text = "Number of members in a group";
            membersInAGroupRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupSizeLabel
            // 
            groupSizeLabel.AutoSize = true;
            groupSizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupSizeLabel.Location = new Point(546, 744);
            groupSizeLabel.Margin = new Padding(4, 0, 4, 0);
            groupSizeLabel.Name = "groupSizeLabel";
            groupSizeLabel.Size = new Size(83, 45);
            groupSizeLabel.TabIndex = 8;
            groupSizeLabel.Text = "Size:";
            // 
            // groupSizeTextBox
            // 
            groupSizeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupSizeTextBox.Location = new Point(684, 739);
            groupSizeTextBox.Margin = new Padding(4, 2, 4, 2);
            groupSizeTextBox.Name = "groupSizeTextBox";
            groupSizeTextBox.Size = new Size(88, 50);
            groupSizeTextBox.TabIndex = 9;
            // 
            // createGroupsButton
            // 
            createGroupsButton.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            createGroupsButton.Location = new Point(481, 845);
            createGroupsButton.Margin = new Padding(4, 2, 4, 2);
            createGroupsButton.Name = "createGroupsButton";
            createGroupsButton.Size = new Size(399, 126);
            createGroupsButton.TabIndex = 10;
            createGroupsButton.Text = "Create Group";
            createGroupsButton.UseVisualStyleBackColor = true;
            createGroupsButton.Click += CreateGroupsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 1039);
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
            Margin = new Padding(4, 2, 4, 2);
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