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
    public partial class ExerciseForm : Form
    {
        public ExerciseForm()
        {
            InitializeComponent();
        }

        private void categoryAddButton_Click(object sender, EventArgs e)
        {

            //exerciseTextBox.Text = catExerciseListView.Groups;

            catExerciseListView.Items.Add(new ListViewItem(new string[] {"Programming Windows"}));
            catExerciseListView.Groups.Add(new ListViewGroup("List item text", HorizontalAlignment.Left));
            

            catExerciseListView.Items[0].Group = catExerciseListView.Groups[0];
        }

        private void exerciseAddButton_Click(object sender, EventArgs e)
        {
            catExerciseListView.Items.Add(new ListViewItem(exerciseTextBox.Text));
            exerciseTextBox.Text = string.Empty;
            exerciseAddButton.Enabled = false;
        }

        private void exerciseTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length > 0)
            {
                exerciseAddButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
