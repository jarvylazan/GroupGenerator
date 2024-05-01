namespace GroupGenerator
{
    partial class Form1
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
            addStudentsTextBox = new TextBox();
            importStudentsTextBox = new Button();
            deleteStudentButton = new Button();
            clearStudentsButton = new Button();
            groupingGroupBox = new GroupBox();
            membersInAGroupRadioButton = new RadioButton();
            numberOfMembersRadioButton = new RadioButton();
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
            studentListBox.Location = new Point(12, 12);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(426, 676);
            studentListBox.TabIndex = 0;
            // 
            // nameFormatSelectionGroupBox
            // 
            nameFormatSelectionGroupBox.Controls.Add(nameWithStudentIdRadioButton);
            nameFormatSelectionGroupBox.Controls.Add(fullNameRadioButton);
            nameFormatSelectionGroupBox.Controls.Add(hideLastNameRadioButton);
            nameFormatSelectionGroupBox.Location = new Point(471, 28);
            nameFormatSelectionGroupBox.Name = "nameFormatSelectionGroupBox";
            nameFormatSelectionGroupBox.Size = new Size(400, 184);
            nameFormatSelectionGroupBox.TabIndex = 1;
            nameFormatSelectionGroupBox.TabStop = false;
            nameFormatSelectionGroupBox.Text = "Choose your name format";
            // 
            // nameWithStudentIdRadioButton
            // 
            nameWithStudentIdRadioButton.AutoSize = true;
            nameWithStudentIdRadioButton.Location = new Point(21, 122);
            nameWithStudentIdRadioButton.Name = "nameWithStudentIdRadioButton";
            nameWithStudentIdRadioButton.Size = new Size(326, 36);
            nameWithStudentIdRadioButton.TabIndex = 2;
            nameWithStudentIdRadioButton.TabStop = true;
            nameWithStudentIdRadioButton.Text = "Full Name with Student ID";
            nameWithStudentIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // fullNameRadioButton
            // 
            fullNameRadioButton.AutoSize = true;
            fullNameRadioButton.Location = new Point(21, 80);
            fullNameRadioButton.Name = "fullNameRadioButton";
            fullNameRadioButton.Size = new Size(154, 36);
            fullNameRadioButton.TabIndex = 1;
            fullNameRadioButton.TabStop = true;
            fullNameRadioButton.Text = "Full Name";
            fullNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // hideLastNameRadioButton
            // 
            hideLastNameRadioButton.AutoSize = true;
            hideLastNameRadioButton.Location = new Point(21, 38);
            hideLastNameRadioButton.Name = "hideLastNameRadioButton";
            hideLastNameRadioButton.Size = new Size(261, 36);
            hideLastNameRadioButton.TabIndex = 0;
            hideLastNameRadioButton.TabStop = true;
            hideLastNameRadioButton.Text = "Last Name as Initials";
            hideLastNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(471, 246);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 2;
            label1.Text = "Add students here:";
            // 
            // addStudentsTextBox
            // 
            addStudentsTextBox.Location = new Point(471, 295);
            addStudentsTextBox.Multiline = true;
            addStudentsTextBox.Name = "addStudentsTextBox";
            addStudentsTextBox.Size = new Size(400, 166);
            addStudentsTextBox.TabIndex = 3;
            // 
            // importStudentsTextBox
            // 
            importStudentsTextBox.Location = new Point(471, 499);
            importStudentsTextBox.Name = "importStudentsTextBox";
            importStudentsTextBox.Size = new Size(400, 62);
            importStudentsTextBox.TabIndex = 4;
            importStudentsTextBox.Text = "Import";
            importStudentsTextBox.UseVisualStyleBackColor = true;
            // 
            // deleteStudentButton
            // 
            deleteStudentButton.Location = new Point(12, 707);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(195, 62);
            deleteStudentButton.TabIndex = 5;
            deleteStudentButton.Text = "Delete";
            deleteStudentButton.UseVisualStyleBackColor = true;
            // 
            // clearStudentsButton
            // 
            clearStudentsButton.Location = new Point(243, 707);
            clearStudentsButton.Name = "clearStudentsButton";
            clearStudentsButton.Size = new Size(195, 62);
            clearStudentsButton.TabIndex = 6;
            clearStudentsButton.Text = "Clear";
            clearStudentsButton.UseVisualStyleBackColor = true;
            // 
            // groupingGroupBox
            // 
            groupingGroupBox.Controls.Add(numberOfMembersRadioButton);
            groupingGroupBox.Controls.Add(membersInAGroupRadioButton);
            groupingGroupBox.Location = new Point(12, 775);
            groupingGroupBox.Name = "groupingGroupBox";
            groupingGroupBox.Size = new Size(426, 182);
            groupingGroupBox.TabIndex = 7;
            groupingGroupBox.TabStop = false;
            groupingGroupBox.Text = "Choose how to group the students";
            // 
            // membersInAGroupRadioButton
            // 
            membersInAGroupRadioButton.AutoSize = true;
            membersInAGroupRadioButton.Location = new Point(15, 54);
            membersInAGroupRadioButton.Name = "membersInAGroupRadioButton";
            membersInAGroupRadioButton.Size = new Size(386, 36);
            membersInAGroupRadioButton.TabIndex = 0;
            membersInAGroupRadioButton.TabStop = true;
            membersInAGroupRadioButton.Text = "Number of members in a group";
            membersInAGroupRadioButton.UseVisualStyleBackColor = true;
            // 
            // numberOfMembersRadioButton
            // 
            numberOfMembersRadioButton.AutoSize = true;
            numberOfMembersRadioButton.Location = new Point(15, 96);
            numberOfMembersRadioButton.Name = "numberOfMembersRadioButton";
            numberOfMembersRadioButton.Size = new Size(337, 36);
            numberOfMembersRadioButton.TabIndex = 1;
            numberOfMembersRadioButton.TabStop = true;
            numberOfMembersRadioButton.Text = "Number of groups to make";
            numberOfMembersRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupSizeLabel
            // 
            groupSizeLabel.AutoSize = true;
            groupSizeLabel.Location = new Point(27, 989);
            groupSizeLabel.Name = "groupSizeLabel";
            groupSizeLabel.Size = new Size(62, 32);
            groupSizeLabel.TabIndex = 8;
            groupSizeLabel.Text = "Size:";
            // 
            // groupSizeTextBox
            // 
            groupSizeTextBox.Location = new Point(120, 982);
            groupSizeTextBox.Name = "groupSizeTextBox";
            groupSizeTextBox.Size = new Size(87, 39);
            groupSizeTextBox.TabIndex = 9;
            // 
            // createGroupsButton
            // 
            createGroupsButton.Location = new Point(471, 931);
            createGroupsButton.Name = "createGroupsButton";
            createGroupsButton.Size = new Size(400, 90);
            createGroupsButton.TabIndex = 10;
            createGroupsButton.Text = "Create Group";
            createGroupsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 1086);
            Controls.Add(createGroupsButton);
            Controls.Add(groupSizeTextBox);
            Controls.Add(groupSizeLabel);
            Controls.Add(groupingGroupBox);
            Controls.Add(clearStudentsButton);
            Controls.Add(deleteStudentButton);
            Controls.Add(importStudentsTextBox);
            Controls.Add(addStudentsTextBox);
            Controls.Add(label1);
            Controls.Add(nameFormatSelectionGroupBox);
            Controls.Add(studentListBox);
            Name = "Form1";
            Text = "Group Generator";
            nameFormatSelectionGroupBox.ResumeLayout(false);
            nameFormatSelectionGroupBox.PerformLayout();
            groupingGroupBox.ResumeLayout(false);
            groupingGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox studentListBox;
        private GroupBox nameFormatSelectionGroupBox;
        private RadioButton nameWithStudentIdRadioButton;
        private RadioButton fullNameRadioButton;
        private RadioButton hideLastNameRadioButton;
        private Label label1;
        private TextBox addStudentsTextBox;
        private Button importStudentsTextBox;
        private Button deleteStudentButton;
        private Button clearStudentsButton;
        private GroupBox groupingGroupBox;
        private RadioButton numberOfMembersRadioButton;
        private RadioButton membersInAGroupRadioButton;
        private Label groupSizeLabel;
        private TextBox groupSizeTextBox;
        private Button createGroupsButton;
    }
}