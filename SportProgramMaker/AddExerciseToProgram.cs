using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportProgramMaker
{
    public partial class AddExerciseToProgram : Form
    {
        public AddExerciseToProgram()
        {
            InitializeComponent();
        }

        public MainForm ParentForm { get; set; }

        public string ExerciseName { get; set; }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddExerciseToProgram_Shown(object sender, EventArgs e)
        {
            exerciseNameTextBox.Text = ExerciseName;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ParentForm.AddExerciseToProgram(exerciseNameTextBox.Text, (int)setCountNumericUpDown.Value, (int)repeatsCountNumericUpDown.Value);

            this.Close();
        }
    }
}
