namespace PainMonitorTeamB
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databasepainDataSet1 = new PainMonitorTeamB.DatabasepainDataSet1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxPain = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxSymphtoms = new System.Windows.Forms.TextBox();
            this.textBoxMedication = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.monitorTableAdapter1 = new PainMonitorTeamB.DatabasepainDataSet1TableAdapters.monitorTableAdapter();
            this.checkedListBoxMedicine = new System.Windows.Forms.CheckedListBox();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasepainDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.medicationDataGridViewTextBoxColumn,
            this.painDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.symptomsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.monitorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date ";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date ";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // medicationDataGridViewTextBoxColumn
            // 
            this.medicationDataGridViewTextBoxColumn.DataPropertyName = "medication";
            this.medicationDataGridViewTextBoxColumn.HeaderText = "medication";
            this.medicationDataGridViewTextBoxColumn.Name = "medicationDataGridViewTextBoxColumn";
            // 
            // painDataGridViewTextBoxColumn
            // 
            this.painDataGridViewTextBoxColumn.DataPropertyName = "pain";
            this.painDataGridViewTextBoxColumn.HeaderText = "pain";
            this.painDataGridViewTextBoxColumn.Name = "painDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // symptomsDataGridViewTextBoxColumn
            // 
            this.symptomsDataGridViewTextBoxColumn.DataPropertyName = "symptoms";
            this.symptomsDataGridViewTextBoxColumn.HeaderText = "symptoms";
            this.symptomsDataGridViewTextBoxColumn.Name = "symptomsDataGridViewTextBoxColumn";
            // 
            // monitorBindingSource1
            // 
            this.monitorBindingSource1.DataMember = "monitor";
            this.monitorBindingSource1.DataSource = this.databasepainDataSet1;
            // 
            // databasepainDataSet1
            // 
            this.databasepainDataSet1.DataSetName = "DatabasepainDataSet1";
            this.databasepainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorInfoToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // doctorInfoToolStripMenuItem
            // 
            this.doctorInfoToolStripMenuItem.Name = "doctorInfoToolStripMenuItem";
            this.doctorInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doctorInfoToolStripMenuItem.Text = "Doctor Info";
            this.doctorInfoToolStripMenuItem.Click += new System.EventHandler(this.doctorInfoToolStripMenuItem_Click);
            // 
            // comboBoxPain
            // 
            this.comboBoxPain.FormattingEnabled = true;
            this.comboBoxPain.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxPain.Location = new System.Drawing.Point(46, 183);
            this.comboBoxPain.Name = "comboBoxPain";
            this.comboBoxPain.Size = new System.Drawing.Size(31, 21);
            this.comboBoxPain.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Medication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Symphtoms";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(308, 186);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 70);
            this.textBoxLocation.TabIndex = 8;
            // 
            // textBoxSymphtoms
            // 
            this.textBoxSymphtoms.Location = new System.Drawing.Point(478, 186);
            this.textBoxSymphtoms.Multiline = true;
            this.textBoxSymphtoms.Name = "textBoxSymphtoms";
            this.textBoxSymphtoms.Size = new System.Drawing.Size(100, 73);
            this.textBoxSymphtoms.TabIndex = 9;
            // 
            // textBoxMedication
            // 
            this.textBoxMedication.Location = new System.Drawing.Point(147, 253);
            this.textBoxMedication.Name = "textBoxMedication";
            this.textBoxMedication.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedication.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monitorTableAdapter1
            // 
            this.monitorTableAdapter1.ClearBeforeFill = true;
            // 
            // checkedListBoxMedicine
            // 
            this.checkedListBoxMedicine.FormattingEnabled = true;
            this.checkedListBoxMedicine.Items.AddRange(new object[] {
            "tylonal ",
            "motrin ",
            "advil",
            "oxcodone "});
            this.checkedListBoxMedicine.Location = new System.Drawing.Point(147, 183);
            this.checkedListBoxMedicine.Name = "checkedListBoxMedicine";
            this.checkedListBoxMedicine.Size = new System.Drawing.Size(100, 64);
            this.checkedListBoxMedicine.TabIndex = 12;
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(331, 274);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(75, 23);
            this.buttonEmail.TabIndex = 13;
            this.buttonEmail.Text = "email";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(583, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 149);
            this.textBox1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(718, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 410);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.checkedListBoxMedicine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMedication);
            this.Controls.Add(this.textBoxSymphtoms);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPain);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pain Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasepainDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorInfoToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxPain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxSymphtoms;
        private System.Windows.Forms.TextBox textBoxMedication;
        private System.Windows.Forms.Button button1;
        private DatabasepainDataSet1 databasepainDataSet1;
        private System.Windows.Forms.BindingSource monitorBindingSource1;
        private DatabasepainDataSet1TableAdapters.monitorTableAdapter monitorTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn painDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckedListBox checkedListBoxMedicine;
        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

