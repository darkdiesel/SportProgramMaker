namespace SportProgramMaker
{
    partial class ExerciseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseForm));
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.categoryAddButton = new System.Windows.Forms.Button();
            this.catExerciseListView = new System.Windows.Forms.ListView();
            this.ExerciseNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exerciesGroupBox = new System.Windows.Forms.GroupBox();
            this.exerciseTextBox = new System.Windows.Forms.TextBox();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.exerciseAddButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.categoriesGroupBox.SuspendLayout();
            this.exerciesGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(6, 19);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(188, 20);
            this.categoryTextBox.TabIndex = 1;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.categoryTextBox_TextChanged);
            // 
            // categoryAddButton
            // 
            this.categoryAddButton.Enabled = false;
            this.categoryAddButton.Location = new System.Drawing.Point(94, 45);
            this.categoryAddButton.Name = "categoryAddButton";
            this.categoryAddButton.Size = new System.Drawing.Size(100, 23);
            this.categoryAddButton.TabIndex = 0;
            this.categoryAddButton.Text = "Add Category";
            this.categoryAddButton.UseVisualStyleBackColor = true;
            this.categoryAddButton.Click += new System.EventHandler(this.categoryAddButton_Click);
            // 
            // catExerciseListView
            // 
            this.catExerciseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ExerciseNamecolumnHeader});
            this.catExerciseListView.GridLines = true;
            this.catExerciseListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.catExerciseListView.Location = new System.Drawing.Point(14, 12);
            this.catExerciseListView.MultiSelect = false;
            this.catExerciseListView.Name = "catExerciseListView";
            this.catExerciseListView.Size = new System.Drawing.Size(155, 251);
            this.catExerciseListView.TabIndex = 5;
            this.catExerciseListView.UseCompatibleStateImageBehavior = false;
            // 
            // ExerciseNamecolumnHeader
            // 
            this.ExerciseNamecolumnHeader.Text = "Exercise Name";
            // 
            // categoriesGroupBox
            // 
            this.categoriesGroupBox.Controls.Add(this.categoryTextBox);
            this.categoriesGroupBox.Controls.Add(this.categoryAddButton);
            this.categoriesGroupBox.Location = new System.Drawing.Point(175, 12);
            this.categoriesGroupBox.Name = "categoriesGroupBox";
            this.categoriesGroupBox.Size = new System.Drawing.Size(428, 79);
            this.categoriesGroupBox.TabIndex = 7;
            this.categoriesGroupBox.TabStop = false;
            this.categoriesGroupBox.Text = "Categories";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(528, 269);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exerciesGroupBox
            // 
            this.exerciesGroupBox.Controls.Add(this.exerciseAddButton);
            this.exerciesGroupBox.Controls.Add(this.categoriesListBox);
            this.exerciesGroupBox.Controls.Add(this.exerciseTextBox);
            this.exerciesGroupBox.Location = new System.Drawing.Point(175, 97);
            this.exerciesGroupBox.Name = "exerciesGroupBox";
            this.exerciesGroupBox.Size = new System.Drawing.Size(427, 166);
            this.exerciesGroupBox.TabIndex = 9;
            this.exerciesGroupBox.TabStop = false;
            this.exerciesGroupBox.Text = "Exercises";
            // 
            // exerciseTextBox
            // 
            this.exerciseTextBox.Location = new System.Drawing.Point(6, 19);
            this.exerciseTextBox.Name = "exerciseTextBox";
            this.exerciseTextBox.Size = new System.Drawing.Size(188, 20);
            this.exerciseTextBox.TabIndex = 4;
            this.exerciseTextBox.TextChanged += new System.EventHandler(this.exerciseTextBox_TextChanged);
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.Location = new System.Drawing.Point(6, 45);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(188, 82);
            this.categoriesListBox.TabIndex = 6;
            this.categoriesListBox.SelectedIndexChanged += new System.EventHandler(this.categoriesListBox_SelectedIndexChanged);
            // 
            // exerciseAddButton
            // 
            this.exerciseAddButton.Enabled = false;
            this.exerciseAddButton.Location = new System.Drawing.Point(94, 133);
            this.exerciseAddButton.Name = "exerciseAddButton";
            this.exerciseAddButton.Size = new System.Drawing.Size(100, 23);
            this.exerciseAddButton.TabIndex = 7;
            this.exerciseAddButton.Text = "Add Exercise";
            this.exerciseAddButton.UseVisualStyleBackColor = true;
            this.exerciseAddButton.Click += new System.EventHandler(this.exerciseAddButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(611, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 323);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exerciesGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.categoriesGroupBox);
            this.Controls.Add(this.catExerciseListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExerciseForm";
            this.Shown += new System.EventHandler(this.ExerciseForm_Shown);
            this.categoriesGroupBox.ResumeLayout(false);
            this.categoriesGroupBox.PerformLayout();
            this.exerciesGroupBox.ResumeLayout(false);
            this.exerciesGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button categoryAddButton;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.ListView catExerciseListView;
        private System.Windows.Forms.ColumnHeader ExerciseNamecolumnHeader;
        private System.Windows.Forms.GroupBox categoriesGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox exerciesGroupBox;
        private System.Windows.Forms.Button exerciseAddButton;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.TextBox exerciseTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}