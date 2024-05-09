namespace GroupGenerator
{
    partial class GroupResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CloseButton = new Button();
            GroupsListView = new ListView();
            SuspendLayout();
            // 
            // closeButton
            // 
            CloseButton.Location = new Point(110, 388);
            CloseButton.Name = "closeButton";
            CloseButton.Size = new Size(137, 34);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "&Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // GroupsListView
            // 
            GroupsListView.Location = new Point(51, 24);
            GroupsListView.Name = "GroupsListView";
            GroupsListView.Size = new Size(259, 338);
            GroupsListView.TabIndex = 1;
            GroupsListView.UseCompatibleStateImageBehavior = false;
            // 
            // GroupResultsFrom
            // 
            AcceptButton = CloseButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CloseButton;
            ClientSize = new Size(363, 450);
            Controls.Add(GroupsListView);
            Controls.Add(CloseButton);
            Name = "GroupResultsFrom";
            Text = "GroupResultsFrom";
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private ListView GroupsListView;
    }
}