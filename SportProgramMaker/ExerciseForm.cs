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
            catExerciseListView.Groups.Add(new ListViewGroup(categoryTextBox.Text, HorizontalAlignment.Left));

            categoryTextBox.Text = string.Empty;
            categoryAddButton.Enabled = false;

            updateCategriesList();
        }

        private void exerciseAddButton_Click(object sender, EventArgs e)
        {
            var exercise = catExerciseListView.Items.Add(new ListViewItem(exerciseTextBox.Text));

            catExerciseListView.Items[exercise.Index].Group = catExerciseListView.Groups[categoriesListBox.SelectedIndex];

            exerciseTextBox.Text = string.Empty;
            exerciseAddButton.Enabled = false;

            categoriesListBox.ClearSelected();
        }

        private void exerciseTextBox_TextChanged(object sender, EventArgs e)
        {
            checkExerciseToAdd();        
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            checkCategoriesToAdd();
        }

        private void updateCategriesList() {
            categoriesListBox.Items.Clear();

            foreach (ListViewGroup group in catExerciseListView.Groups)
            {
                categoriesListBox.Items.Add(group.Header);
            }
        }

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkExerciseToAdd();
        }

        private void checkCategoriesToAdd()
        {
            if (categoryTextBox.Text.Length > 0)
            {
                categoryAddButton.Enabled = true;
            }
            else
            {
                categoryAddButton.Enabled = false;
            }
        }

        private void checkExerciseToAdd()
        {
            if (exerciseTextBox.Text.Length > 0 && categoriesListBox.SelectedIndex >= 0)
            {
                exerciseAddButton.Enabled = true;
            }
            else
            {
                exerciseAddButton.Enabled = false;
            }
        }
    }

    
}
