using System.ComponentModel;

namespace PrihodkoCourse.Forms
{
    partial class DiseasesSymptomsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.DiseasesSymptomsDataGridView = new System.Windows.Forms.DataGridView();
            this.DiseaseIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SymptomIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SymptomNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.DiseasesSymptomsDataGridView)).BeginInit();
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
            this.SearchTextBox.Size = new System.Drawing.Size(960, 29);
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
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Symptoms Diseases";
            // 
            // DiseasesSymptomsDataGridView
            // 
            this.DiseasesSymptomsDataGridView.AllowUserToAddRows = false;
            this.DiseasesSymptomsDataGridView.AllowUserToDeleteRows = false;
            this.DiseasesSymptomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiseasesSymptomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.DiseaseIdColumn, this.DiseaseNameColumn, this.SymptomIdColumn, this.SymptomNameColumn});
            this.DiseasesSymptomsDataGridView.Location = new System.Drawing.Point(12, 93);
            this.DiseasesSymptomsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.DiseasesSymptomsDataGridView.MultiSelect = false;
            this.DiseasesSymptomsDataGridView.Name = "DiseasesSymptomsDataGridView";
            this.DiseasesSymptomsDataGridView.ReadOnly = true;
            this.DiseasesSymptomsDataGridView.Size = new System.Drawing.Size(960, 498);
            this.DiseasesSymptomsDataGridView.TabIndex = 7;
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
            // SymptomIdColumn
            // 
            this.SymptomIdColumn.HeaderText = "SymptomId";
            this.SymptomIdColumn.Name = "SymptomIdColumn";
            this.SymptomIdColumn.ReadOnly = true;
            this.SymptomIdColumn.Width = 150;
            // 
            // SymptomNameColumn
            // 
            this.SymptomNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SymptomNameColumn.HeaderText = "SymptomName";
            this.SymptomNameColumn.Name = "SymptomNameColumn";
            this.SymptomNameColumn.ReadOnly = true;
            // 
            // DiseasesSymptomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiseasesSymptomsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DiseasesSymptomsForm";
            this.Text = "SymptomsDiseasesForm";
            this.Load += new System.EventHandler(this.DiseasesSymptomsForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.DiseasesSymptomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymptomIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymptomNameColumn;

        private System.Windows.Forms.DataGridView DiseasesSymptomsDataGridView;

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;

        #endregion
    }
}