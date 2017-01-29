using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportProgramMaker.Properties;

namespace SportProgramMaker
{
    public partial class MainForm : Form
    {
        public const string EXERCISES_FILE_NAME = "exercises.json";
        String FormName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();

            aboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void exercisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExerciseForm exerciseForm = new ExerciseForm();
            exerciseForm.ShowDialog();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(MainForm.EXERCISES_FILE_NAME)) return;

                var stream = File.OpenRead(MainForm.EXERCISES_FILE_NAME);

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GroupExerciseSettings[]));

                GroupExerciseSettings[] groups = (GroupExerciseSettings[])serializer.ReadObject(stream);

                foreach (GroupExerciseSettings group in groups)
                {
                    var group_added = catExerciseListView.Groups.Add(new ListViewGroup(@group.name, HorizontalAlignment.Left));

                    if (@group.items == null) continue;
                    foreach (var item in @group.items)
                    {
                        var exercise = catExerciseListView.Items.Add(new ListViewItem(item));
                        catExerciseListView.Items[exercise.Index].Group = catExerciseListView.Groups[group_added];
                    }
                }

                stream.Close();
            }
            catch (System.Exception ex)
            {
                //logger.Error("Cannot deserialize json " + filePath, ex);
                //throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = FormName.Substring(1, FormName.Length - 1) + FormName.Substring(0, 1);
            FormName = this.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormName = this.Text + "     ";
            toolStripStatusLabel1.Text = Resources.MainForm_StartMessage;
        }

        private void createProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display new program panel
            //TODO: check if panel not dispplaying now and program creation in process.
            mainPanel.Show();
            mainPanel.Enabled = true;

            // remove message from status bar
            toolStripStatusLabel1.Text = string.Empty;

        }

        private void addExerciseButton_Click(object sender, EventArgs e)
        {

            var item = catExerciseListView.SelectedItems[0];

            AddExerciseToProgram addExerciseFrom = new AddExerciseToProgram {ExerciseName = item.Text, ParentForm = this};
            addExerciseFrom.ShowDialog(this);

            catExerciseListView.SelectedItems.Clear();
        }

        private void catExerciseListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enable add exercise btn if any item selected
            addExerciseButton.Enabled = catExerciseListView.SelectedItems.Count > 0;
        }

        public void AddExerciseToProgram(string exersciseName, int exersciseSets, int exersciseRepeats)
        {
            string[] row1 = new string[] { exersciseName, exersciseSets.ToString(), exersciseRepeats.ToString() };
            programDataGridView.Rows.Add(row1);
        }
    }
}
