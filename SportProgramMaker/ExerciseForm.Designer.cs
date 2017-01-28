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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exerciseTextBox = new System.Windows.Forms.TextBox();
            this.exerciseAddButton = new System.Windows.Forms.Button();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.categoryAddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.catExerciseListView = new System.Windows.Forms.ListView();
            this.ExerciseNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.exerciseTextBox);
            this.panel1.Controls.Add(this.exerciseAddButton);
            this.panel1.Controls.Add(this.categoryTextBox);
            this.panel1.Controls.Add(this.categoryAddButton);
            this.panel1.Location = new System.Drawing.Point(175, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 355);
            this.panel1.TabIndex = 1;
            // 
            // exerciseTextBox
            // 
            this.exerciseTextBox.Location = new System.Drawing.Point(214, 18);
            this.exerciseTextBox.Name = "exerciseTextBox";
            this.exerciseTextBox.Size = new System.Drawing.Size(100, 20);
            this.exerciseTextBox.TabIndex = 3;
            this.exerciseTextBox.TextChanged += new System.EventHandler(this.exerciseTextBox_TextChanged);
            // 
            // exerciseAddButton
            // 
            this.exerciseAddButton.Enabled = false;
            this.exerciseAddButton.Location = new System.Drawing.Point(214, 44);
            this.exerciseAddButton.Name = "exerciseAddButton";
            this.exerciseAddButton.Size = new System.Drawing.Size(100, 23);
            this.exerciseAddButton.TabIndex = 2;
            this.exerciseAddButton.Text = "Add Exercise";
            this.exerciseAddButton.UseVisualStyleBackColor = true;
            this.exerciseAddButton.Click += new System.EventHandler(this.exerciseAddButton_Click);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(13, 18);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 1;
            // 
            // categoryAddButton
            // 
            this.categoryAddButton.Location = new System.Drawing.Point(13, 44);
            this.categoryAddButton.Name = "categoryAddButton";
            this.categoryAddButton.Size = new System.Drawing.Size(100, 23);
            this.categoryAddButton.TabIndex = 0;
            this.categoryAddButton.Text = "Add Category";
            this.categoryAddButton.UseVisualStyleBackColor = true;
            this.categoryAddButton.Click += new System.EventHandler(this.categoryAddButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Up";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Down";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(107, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // catExerciseListView
            // 
            this.catExerciseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ExerciseNamecolumnHeader});
            this.catExerciseListView.GridLines = true;
            this.catExerciseListView.Location = new System.Drawing.Point(14, 12);
            this.catExerciseListView.Name = "catExerciseListView";
            this.catExerciseListView.Size = new System.Drawing.Size(155, 326);
            this.catExerciseListView.TabIndex = 5;
            this.catExerciseListView.UseCompatibleStateImageBehavior = false;
            // 
            // ExerciseNamecolumnHeader
            // 
            this.ExerciseNamecolumnHeader.Text = "Exercise Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(322, 329);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 378);
            this.Controls.Add(this.catExerciseListView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExerciseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button categoryAddButton;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox exerciseTextBox;
        private System.Windows.Forms.Button exerciseAddButton;
        private System.Windows.Forms.ListView catExerciseListView;
        private System.Windows.Forms.ColumnHeader ExerciseNamecolumnHeader;
        private System.Windows.Forms.Button saveButton;
    }
}