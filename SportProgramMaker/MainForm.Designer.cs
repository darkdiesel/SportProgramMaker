namespace SportProgramMaker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.catExerciseListView = new System.Windows.Forms.ListView();
            this.programDataGridView = new System.Windows.Forms.DataGridView();
            this.ExerciseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formNameTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addExerciseButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programDataGridView)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(818, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProgramToolStripMenuItem,
            this.openProgramToolStripMenuItem,
            this.saveProgramToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createProgramToolStripMenuItem
            // 
            this.createProgramToolStripMenuItem.Name = "createProgramToolStripMenuItem";
            this.createProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createProgramToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.createProgramToolStripMenuItem.Text = "Create";
            this.createProgramToolStripMenuItem.Click += new System.EventHandler(this.createProgramToolStripMenuItem_Click);
            // 
            // openProgramToolStripMenuItem
            // 
            this.openProgramToolStripMenuItem.Name = "openProgramToolStripMenuItem";
            this.openProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProgramToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openProgramToolStripMenuItem.Text = "Open";
            this.openProgramToolStripMenuItem.Click += new System.EventHandler(this.openProgramToolStripMenuItem_Click);
            // 
            // saveProgramToolStripMenuItem
            // 
            this.saveProgramToolStripMenuItem.Enabled = false;
            this.saveProgramToolStripMenuItem.Name = "saveProgramToolStripMenuItem";
            this.saveProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProgramToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveProgramToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercisesToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // exercisesToolStripMenuItem
            // 
            this.exercisesToolStripMenuItem.Name = "exercisesToolStripMenuItem";
            this.exercisesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exercisesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exercisesToolStripMenuItem.Text = "Exercises";
            this.exercisesToolStripMenuItem.Click += new System.EventHandler(this.exercisesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // catExerciseListView
            // 
            this.catExerciseListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catExerciseListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.catExerciseListView.Location = new System.Drawing.Point(495, 3);
            this.catExerciseListView.MultiSelect = false;
            this.catExerciseListView.Name = "catExerciseListView";
            this.catExerciseListView.Size = new System.Drawing.Size(323, 352);
            this.catExerciseListView.TabIndex = 2;
            this.catExerciseListView.UseCompatibleStateImageBehavior = false;
            this.catExerciseListView.View = System.Windows.Forms.View.Tile;
            this.catExerciseListView.SelectedIndexChanged += new System.EventHandler(this.catExerciseListView_SelectedIndexChanged);
            // 
            // programDataGridView
            // 
            this.programDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExerciseName,
            this.Set,
            this.Repeats});
            this.programDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.programDataGridView.Location = new System.Drawing.Point(0, 0);
            this.programDataGridView.Name = "programDataGridView";
            this.programDataGridView.Size = new System.Drawing.Size(489, 433);
            this.programDataGridView.TabIndex = 3;
            // 
            // ExerciseName
            // 
            this.ExerciseName.HeaderText = "Exercise Name";
            this.ExerciseName.Name = "ExerciseName";
            // 
            // Set
            // 
            this.Set.HeaderText = "Set";
            this.Set.Name = "Set";
            // 
            // Repeats
            // 
            this.Repeats.HeaderText = "Repeats";
            this.Repeats.Name = "Repeats";
            // 
            // formNameTimer
            // 
            this.formNameTimer.Enabled = true;
            this.formNameTimer.Interval = 300;
            this.formNameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.addExerciseButton);
            this.mainPanel.Controls.Add(this.programDataGridView);
            this.mainPanel.Controls.Add(this.catExerciseListView);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Enabled = false;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(818, 433);
            this.mainPanel.TabIndex = 4;
            this.mainPanel.Visible = false;
            // 
            // addExerciseButton
            // 
            this.addExerciseButton.Enabled = false;
            this.addExerciseButton.Location = new System.Drawing.Point(495, 361);
            this.addExerciseButton.Name = "addExerciseButton";
            this.addExerciseButton.Size = new System.Drawing.Size(87, 23);
            this.addExerciseButton.TabIndex = 4;
            this.addExerciseButton.Text = "Add Exercise";
            this.addExerciseButton.UseVisualStyleBackColor = true;
            this.addExerciseButton.Click += new System.EventHandler(this.addExerciseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 479);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sport Program Maker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programDataGridView)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercisesToolStripMenuItem;
        private System.Windows.Forms.DataGridView programDataGridView;
        private System.Windows.Forms.Timer formNameTimer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button addExerciseButton;
        private System.Windows.Forms.ListView catExerciseListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerciseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Set;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repeats;
    }
}

