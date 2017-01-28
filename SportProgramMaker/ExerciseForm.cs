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
        public const string EXERCISES_FILE_NAME = "exercises.json";

        public ExerciseForm()
        {
            InitializeComponent();
        }

        private void categoryAddButton_Click(object sender, EventArgs e)
        {
            //catExerciseListView.Items.Add(new ListViewItem(new string[] {"Programming Windows"}));
            //catExerciseListView.Items[0].Group = catExerciseListView.Groups[0];

            catExerciseListView.Groups.Add(new ListViewGroup(categoryTextBox.Text, HorizontalAlignment.Left));

            categoryTextBox.Text = string.Empty;
            categoryAddButton.Enabled = false;

            updateCategriesList();
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

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length > 0)
            {
                categoryAddButton.Enabled = true;
            }
        }

        private void updateCategriesList() {
            categoriesListBox.Items.Clear();

            foreach (ListViewGroup group in catExerciseListView.Groups)
            {
                categoriesListBox.Items.Add(group.Header);
            }
        }
    }

    
}
