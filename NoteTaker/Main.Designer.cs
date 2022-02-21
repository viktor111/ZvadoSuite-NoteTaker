namespace NoteTaker
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NotesListView = new System.Windows.Forms.ListView();
            this.TitleHeader = new System.Windows.Forms.ColumnHeader();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 2);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Note";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(71, 47);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(200, 23);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Apply Sortation";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(71, 18);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.FromDateTimePicker.TabIndex = 3;
            // 
            // NotesListView
            // 
            this.NotesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitleHeader});
            this.NotesListView.Location = new System.Drawing.Point(12, 177);
            this.NotesListView.MultiSelect = false;
            this.NotesListView.Name = "NotesListView";
            this.NotesListView.Size = new System.Drawing.Size(330, 422);
            this.NotesListView.TabIndex = 7;
            this.NotesListView.UseCompatibleStateImageBehavior = false;
            this.NotesListView.View = System.Windows.Forms.View.Details;
            this.NotesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotesListView_MouseDoubleClick);
            // 
            // TitleHeader
            // 
            this.TitleHeader.Text = "Title";
            this.TitleHeader.Width = 250;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 611);
            this.Controls.Add(this.NotesListView);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button SortButton;
        private DateTimePicker FromDateTimePicker;
        private ListView NotesListView;
        private ColumnHeader TitleHeader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}