using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;

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
        }

        private void ExerciseForm_Shown(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(MainForm.EXERCISES_FILE_NAME))
                {
                    var stream = File.OpenRead(MainForm.EXERCISES_FILE_NAME);
                     

                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GroupExerciseSettings[]));

                    GroupExerciseSettings[] groups = (GroupExerciseSettings[])serializer.ReadObject(stream);

                    foreach (GroupExerciseSettings group in groups)
                    {
                        var group_added = catExerciseListView.Groups.Add(new ListViewGroup(group.name, HorizontalAlignment.Left));

                        if (group.items != null) {
                            foreach (var item in group.items) {
                                var exercise = catExerciseListView.Items.Add(new ListViewItem(item));
                                catExerciseListView.Items[exercise.Index].Group = catExerciseListView.Groups[group_added];
                            }
                        }
                    }

                    updateCategriesList();

                    stream.Close();
                }
                
            }
            catch (System.Exception ex)
            {
                //logger.Error("Cannot deserialize json " + filePath, ex);
                //throw;
            }
        }
    }

    
}
