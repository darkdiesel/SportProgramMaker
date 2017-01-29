using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;
using SportProgramMaker.Properties;

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
            catExerciseListView.Groups.Add(new ListViewGroup(categoryTextBox.Text, HorizontalAlignment.Left));

            categoryTextBox.Text = string.Empty;
            categoryAddButton.Enabled = false;

            toolStripStatusLabel1.Text = Resources.ExerciseForm_Changed;

            updateCategriesList();
        }

        private void exerciseAddButton_Click(object sender, EventArgs e)
        {
            var exercise = catExerciseListView.Items.Add(new ListViewItem(exerciseTextBox.Text));

            catExerciseListView.Items[exercise.Index].Group = catExerciseListView.Groups[categoriesListBox.SelectedIndex];

            exerciseTextBox.Text = string.Empty;
            exerciseAddButton.Enabled = false;

            categoriesListBox.ClearSelected();

            toolStripStatusLabel1.Text = Resources.ExerciseForm_Changed;
        }

        private void exerciseTextBox_TextChanged(object sender, EventArgs e)
        {
            checkExerciseToAdd();        
        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckCategoriesToAdd();
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

        private void CheckCategoriesToAdd()
        {
            categoryAddButton.Enabled = categoryTextBox.Text.Length > 0;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(GroupExerciseSettings[]));

            var stream = File.Create(MainForm.EXERCISES_FILE_NAME);

            GroupExerciseSettings[] settings = new GroupExerciseSettings[catExerciseListView.Groups.Count];

            var index = 0;
            foreach (ListViewGroup group in catExerciseListView.Groups)
            {
                GroupExerciseSettings setting = new GroupExerciseSettings();


                setting.items = new List<string>();

                foreach (ListViewItem item in group.Items)
                {
                    setting.items.Add(item.Text);
                }

                setting.name = group.Header;

                settings.SetValue(setting, index);
                index++;
            }

            ser.WriteObject(stream, settings);

            stream.Close();

            toolStripStatusLabel1.Text = string.Empty;
        }

        private void ExerciseForm_Shown(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(MainForm.EXERCISES_FILE_NAME)) return;

                var stream = File.OpenRead(MainForm.EXERCISES_FILE_NAME);
                     

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GroupExerciseSettings[]));

                GroupExerciseSettings[] groups = (GroupExerciseSettings[])serializer.ReadObject(stream);

                foreach (GroupExerciseSettings group in groups)
                {
                    var groupAdded = catExerciseListView.Groups.Add(new ListViewGroup(@group.name, HorizontalAlignment.Left));

                    if (@group.items == null) continue;

                    foreach (var item in @group.items) {
                        var exercise = catExerciseListView.Items.Add(new ListViewItem(item));
                        catExerciseListView.Items[exercise.Index].Group = catExerciseListView.Groups[groupAdded];
                    }
                }

                updateCategriesList();

                stream.Close();
            }
            catch (System.Exception ex)
            {
                //logger.Error("Cannot deserialize json " + filePath, ex);
                //throw;
            }
        }

        private void ExerciseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (toolStripStatusLabel1.Text != string.Empty)
            {
                string message = Resources.ExerciseForm_ExitWithoutSaving;
                string caption = Resources.ExerciseForm_Warning;

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                // Displays the MessageBox.
                DialogResult result = MessageBox.Show(this, message, caption, buttons);

                e.Cancel = (result == DialogResult.No);
            }

        }
    }

    
}
