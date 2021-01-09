namespace PrihodkoCourse.Forms.Dialog
{
    partial class DosagesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DosagesDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseMedicamentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinAgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.DosagesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dosages";
            // 
            // DosagesDataGridView
            // 
            this.DosagesDataGridView.AllowUserToAddRows = false;
            this.DosagesDataGridView.AllowUserToDeleteRows = false;
            this.DosagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DosagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.IdColumn, this.DiseaseMedicamentIdColumn, this.DiseaseNameColumn, this.MedicamentNameColumn, this.MinAgeColumn, this.DoseColumn});
            this.DosagesDataGridView.Location = new System.Drawing.Point(12, 57);
            this.DosagesDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.DosagesDataGridView.MultiSelect = false;
            this.DosagesDataGridView.Name = "DosagesDataGridView";
            this.DosagesDataGridView.ReadOnly = true;
            this.DosagesDataGridView.RowHeadersVisible = false;
            this.DosagesDataGridView.Size = new System.Drawing.Size(957, 532);
            this.DosagesDataGridView.TabIndex = 10;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 40;
            // 
            // DiseaseMedicamentIdColumn
            // 
            this.DiseaseMedicamentIdColumn.HeaderText = "DiseaseMedicamentId";
            this.DiseaseMedicamentIdColumn.Name = "DiseaseMedicamentIdColumn";
            this.DiseaseMedicamentIdColumn.ReadOnly = true;
            this.DiseaseMedicamentIdColumn.Width = 200;
            // 
            // DiseaseNameColumn
            // 
            this.DiseaseNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiseaseNameColumn.HeaderText = "DiseaseName";
            this.DiseaseNameColumn.Name = "DiseaseNameColumn";
            this.DiseaseNameColumn.ReadOnly = true;
            // 
            // MedicamentNameColumn
            // 
            this.MedicamentNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicamentNameColumn.HeaderText = "MedicamentName";
            this.MedicamentNameColumn.Name = "MedicamentNameColumn";
            this.MedicamentNameColumn.ReadOnly = true;
            // 
            // MinAgeColumn
            // 
            this.MinAgeColumn.HeaderText = "MinAge";
            this.MinAgeColumn.Name = "MinAgeColumn";
            this.MinAgeColumn.ReadOnly = true;
            this.MinAgeColumn.Width = 150;
            // 
            // DoseColumn
            // 
            this.DoseColumn.HeaderText = "Dose";
            this.DoseColumn.Name = "DoseColumn";
            this.DoseColumn.ReadOnly = true;
            this.DoseColumn.Width = 150;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(822, 599);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 50);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(510, 599);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 50);
            this.CreateButton.TabIndex = 13;
            this.CreateButton.Text = "Create new";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(666, 599);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 50);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 599);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 50);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DosagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.DosagesDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DosagesForm";
            this.Text = "DosagesForm";
            this.Load += new System.EventHandler(this.DosagesForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.DosagesDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView DosagesDataGridView;

        private System.Windows.Forms.Button BackButton;

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseMedicamentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinAgeColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseNameColumn;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}