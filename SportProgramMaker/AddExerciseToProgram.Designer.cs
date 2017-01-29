namespace SportProgramMaker
{
    partial class AddExerciseToProgram
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
            this.exerciseNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exerciseNameLabel = new System.Windows.Forms.Label();
            this.setCountLabel = new System.Windows.Forms.Label();
            this.repeatsCountLabel = new System.Windows.Forms.Label();
            this.repeatsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.repeatsCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // exerciseNameTextBox
            // 
            this.exerciseNameTextBox.Location = new System.Drawing.Point(12, 34);
            this.exerciseNameTextBox.Name = "exerciseNameTextBox";
            this.exerciseNameTextBox.Size = new System.Drawing.Size(274, 20);
            this.exerciseNameTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(211, 171);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(130, 171);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // exerciseNameLabel
            // 
            this.exerciseNameLabel.AutoSize = true;
            this.exerciseNameLabel.Location = new System.Drawing.Point(12, 18);
            this.exerciseNameLabel.Name = "exerciseNameLabel";
            this.exerciseNameLabel.Size = new System.Drawing.Size(81, 13);
            this.exerciseNameLabel.TabIndex = 5;
            this.exerciseNameLabel.Text = "Exercise Name:";
            // 
            // setCountLabel
            // 
            this.setCountLabel.AutoSize = true;
            this.setCountLabel.Location = new System.Drawing.Point(11, 62);
            this.setCountLabel.Name = "setCountLabel";
            this.setCountLabel.Size = new System.Drawing.Size(57, 13);
            this.setCountLabel.TabIndex = 6;
            this.setCountLabel.Text = "Set Count:";
            // 
            // repeatsCountLabel
            // 
            this.repeatsCountLabel.AutoSize = true;
            this.repeatsCountLabel.Location = new System.Drawing.Point(11, 105);
            this.repeatsCountLabel.Name = "repeatsCountLabel";
            this.repeatsCountLabel.Size = new System.Drawing.Size(81, 13);
            this.repeatsCountLabel.TabIndex = 7;
            this.repeatsCountLabel.Text = "Repeats Count:";
            // 
            // repeatsCountNumericUpDown
            // 
            this.repeatsCountNumericUpDown.Location = new System.Drawing.Point(11, 121);
            this.repeatsCountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.repeatsCountNumericUpDown.Name = "repeatsCountNumericUpDown";
            this.repeatsCountNumericUpDown.Size = new System.Drawing.Size(274, 20);
            this.repeatsCountNumericUpDown.TabIndex = 8;
            // 
            // setCountNumericUpDown
            // 
            this.setCountNumericUpDown.Location = new System.Drawing.Point(11, 78);
            this.setCountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.setCountNumericUpDown.Name = "setCountNumericUpDown";
            this.setCountNumericUpDown.Size = new System.Drawing.Size(274, 20);
            this.setCountNumericUpDown.TabIndex = 9;
            // 
            // AddExerciseToProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 206);
            this.Controls.Add(this.setCountNumericUpDown);
            this.Controls.Add(this.repeatsCountNumericUpDown);
            this.Controls.Add(this.repeatsCountLabel);
            this.Controls.Add(this.setCountLabel);
            this.Controls.Add(this.exerciseNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exerciseNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddExerciseToProgram";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Exercise To Program";
            this.Shown += new System.EventHandler(this.AddExerciseToProgram_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.repeatsCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox exerciseNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label exerciseNameLabel;
        private System.Windows.Forms.Label setCountLabel;
        private System.Windows.Forms.Label repeatsCountLabel;
        private System.Windows.Forms.NumericUpDown repeatsCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown setCountNumericUpDown;
    }
}