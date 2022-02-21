namespace NoteTaker
{
    partial class NoteDetails
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
            this.NoteTextTextBox = new System.Windows.Forms.RichTextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DateCreatedOnLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.Location = new System.Drawing.Point(12, 130);
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.Size = new System.Drawing.Size(560, 253);
            this.NoteTextTextBox.TabIndex = 1;
            this.NoteTextTextBox.Text = "";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(248, 12);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(159, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit Note";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 2);
            this.label1.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(413, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(159, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Note";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DateCreatedOnLabel
            // 
            this.DateCreatedOnLabel.AutoSize = true;
            this.DateCreatedOnLabel.Location = new System.Drawing.Point(12, 16);
            this.DateCreatedOnLabel.Name = "DateCreatedOnLabel";
            this.DateCreatedOnLabel.Size = new System.Drawing.Size(38, 15);
            this.DateCreatedOnLabel.TabIndex = 6;
            this.DateCreatedOnLabel.Text = "label2";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(12, 83);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(560, 23);
            this.TitleTextBox.TabIndex = 7;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(83, 12);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(159, 23);
            this.CreateButton.TabIndex = 8;
            this.CreateButton.Text = "Create Note";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // NoteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 395);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.DateCreatedOnLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NoteTextTextBox);
            this.Name = "NoteDetails";
            this.Text = "NoteDetails";
            this.Load += new System.EventHandler(this.NoteDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox NoteTextTextBox;
        private Button EditButton;
        private Label label1;
        private Button DeleteButton;
        private Label DateCreatedOnLabel;
        private TextBox TitleTextBox;
        private Button CreateButton;
    }
}