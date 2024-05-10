﻿namespace GroupGenerator
{
    partial class ImportForm
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
            importTextBox = new TextBox();
            importNCloseButton = new Button();
            DescriptionLabel = new Label();
            SuspendLayout();
            // 
            // importTextBox
            // 
            importTextBox.AllowDrop = true;
            importTextBox.Location = new Point(95, 87);
            importTextBox.Margin = new Padding(6);
            importTextBox.Multiline = true;
            importTextBox.Name = "importTextBox";
            importTextBox.Size = new Size(442, 774);
            importTextBox.TabIndex = 0;
            // 
            // importNCloseButton
            // 
            importNCloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            importNCloseButton.Location = new Point(158, 879);
            importNCloseButton.Margin = new Padding(6);
            importNCloseButton.Name = "importNCloseButton";
            importNCloseButton.Size = new Size(292, 53);
            importNCloseButton.TabIndex = 1;
            importNCloseButton.Text = "Import and Close";
            importNCloseButton.UseVisualStyleBackColor = true;
            importNCloseButton.Click += ImportAndCloseButton_CLick;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(58, 19);
            DescriptionLabel.Margin = new Padding(6, 0, 6, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(542, 36);
            DescriptionLabel.TabIndex = 2;
            DescriptionLabel.Text = "Copy and Paste Or Click and Drop your list :";
            // 
            // ImportForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 996);
            Controls.Add(DescriptionLabel);
            Controls.Add(importNCloseButton);
            Controls.Add(importTextBox);
            Margin = new Padding(6);
            Name = "ImportForm";
            Text = "ImportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox importTextBox;
        private Button importNCloseButton;
        private Label DescriptionLabel;
    }
}