namespace PrihodkoCourse.Forms
{
    partial class DiseasesMedicamentsForm
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseasesMedicamentsDataGridView = new System.Windows.Forms.DataGridView();
            this.DosagesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.DiseasesMedicamentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(822, 600);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 50);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 600);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 50);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 55);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(960, 33);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(666, 599);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 50);
            this.CreateButton.TabIndex = 9;
            this.CreateButton.Text = "Create new";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Diseases Medicaments";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "DiseaseId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "DiseaseName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "SymptomId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "SymptomName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 70;
            // 
            // DiseaseIdColumn
            // 
            this.DiseaseIdColumn.HeaderText = "DiseaseId";
            this.DiseaseIdColumn.Name = "DiseaseIdColumn";
            this.DiseaseIdColumn.ReadOnly = true;
            this.DiseaseIdColumn.Width = 150;
            // 
            // DiseaseNameColumn
            // 
            this.DiseaseNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiseaseNameColumn.HeaderText = "DiseaseName";
            this.DiseaseNameColumn.Name = "DiseaseNameColumn";
            this.DiseaseNameColumn.ReadOnly = true;
            // 
            // MedicamentIdColumn
            // 
            this.MedicamentIdColumn.HeaderText = "MedicamentId";
            this.MedicamentIdColumn.Name = "MedicamentIdColumn";
            this.MedicamentIdColumn.ReadOnly = true;
            this.MedicamentIdColumn.Width = 150;
            // 
            // MedicamentNameColumn
            // 
            this.MedicamentNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicamentNameColumn.HeaderText = "MedicamentName";
            this.MedicamentNameColumn.Name = "MedicamentNameColumn";
            this.MedicamentNameColumn.ReadOnly = true;
            // 
            // DiseasesMedicamentsDataGridView
            // 
            this.DiseasesMedicamentsDataGridView.AllowUserToAddRows = false;
            this.DiseasesMedicamentsDataGridView.AllowUserToDeleteRows = false;
            this.DiseasesMedicamentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiseasesMedicamentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.IdColumn, this.DiseaseIdColumn, this.DiseaseNameColumn, this.MedicamentIdColumn, this.MedicamentNameColumn});
            this.DiseasesMedicamentsDataGridView.Location = new System.Drawing.Point(12, 93);
            this.DiseasesMedicamentsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.DiseasesMedicamentsDataGridView.MultiSelect = false;
            this.DiseasesMedicamentsDataGridView.Name = "DiseasesMedicamentsDataGridView";
            this.DiseasesMedicamentsDataGridView.ReadOnly = true;
            this.DiseasesMedicamentsDataGridView.Size = new System.Drawing.Size(960, 498);
            this.DiseasesMedicamentsDataGridView.TabIndex = 7;
            // 
            // DosagesButton
            // 
            this.DosagesButton.Location = new System.Drawing.Point(510, 599);
            this.DosagesButton.Name = "DosagesButton";
            this.DosagesButton.Size = new System.Drawing.Size(150, 50);
            this.DosagesButton.TabIndex = 13;
            this.DosagesButton.Text = "Dosages";
            this.DosagesButton.UseVisualStyleBackColor = true;
            this.DosagesButton.Click += new System.EventHandler(this.DosagesButton_Click);
            // 
            // DiseasesMedicamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.DosagesButton);
            this.Controls.Add(this.DiseasesMedicamentsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeleteButton);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DiseasesMedicamentsForm";
            this.Text = "DiseasesMedicamentsForm";
            this.Load += new System.EventHandler(this.DiseasesMedicamentsForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.DiseasesMedicamentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button DosagesButton;

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView DiseasesMedicamentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentNameColumn;
    }
}