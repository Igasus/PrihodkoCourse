namespace PrihodkoCourse.Forms
{
    partial class RecipesForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.RecipesDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.MedicamentsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.RecipesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 600);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 50);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(666, 600);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 50);
            this.EditButton.TabIndex = 21;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(822, 600);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 50);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(510, 600);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 50);
            this.CreateButton.TabIndex = 19;
            this.CreateButton.Text = "Create new";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RecipesDataGridView
            // 
            this.RecipesDataGridView.AllowUserToAddRows = false;
            this.RecipesDataGridView.AllowUserToDeleteRows = false;
            this.RecipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.IdColumn, this.ClientIdColumn, this.ClientNameColumn, this.DiseaseIdColumn, this.DiseaseNameColumn, this.DateColumn});
            this.RecipesDataGridView.Location = new System.Drawing.Point(12, 93);
            this.RecipesDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.RecipesDataGridView.MultiSelect = false;
            this.RecipesDataGridView.Name = "RecipesDataGridView";
            this.RecipesDataGridView.ReadOnly = true;
            this.RecipesDataGridView.RowHeadersVisible = false;
            this.RecipesDataGridView.Size = new System.Drawing.Size(960, 497);
            this.RecipesDataGridView.TabIndex = 18;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 40;
            // 
            // ClientIdColumn
            // 
            this.ClientIdColumn.HeaderText = "ClientId";
            this.ClientIdColumn.Name = "ClientIdColumn";
            this.ClientIdColumn.ReadOnly = true;
            // 
            // ClientNameColumn
            // 
            this.ClientNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientNameColumn.HeaderText = "ClientName";
            this.ClientNameColumn.Name = "ClientNameColumn";
            this.ClientNameColumn.ReadOnly = true;
            // 
            // DiseaseIdColumn
            // 
            this.DiseaseIdColumn.HeaderText = "DiseaseId";
            this.DiseaseIdColumn.Name = "DiseaseIdColumn";
            this.DiseaseIdColumn.ReadOnly = true;
            // 
            // DiseaseNameColumn
            // 
            this.DiseaseNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiseaseNameColumn.HeaderText = "DiseaseName";
            this.DiseaseNameColumn.Name = "DiseaseNameColumn";
            this.DiseaseNameColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 150;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Recipes";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 55);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(960, 29);
            this.SearchTextBox.TabIndex = 23;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // MedicamentsButton
            // 
            this.MedicamentsButton.Location = new System.Drawing.Point(354, 600);
            this.MedicamentsButton.Name = "MedicamentsButton";
            this.MedicamentsButton.Size = new System.Drawing.Size(150, 50);
            this.MedicamentsButton.TabIndex = 24;
            this.MedicamentsButton.Text = "Medicaments";
            this.MedicamentsButton.UseVisualStyleBackColor = true;
            this.MedicamentsButton.Click += new System.EventHandler(this.MedicamentsButton_Click);
            // 
            // RecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.MedicamentsButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.RecipesDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RecipesForm";
            this.Text = "RecipesForm";
            this.Load += new System.EventHandler(this.RecipesForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.RecipesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button MedicamentsButton;

        private System.Windows.Forms.TextBox SearchTextBox;

        private System.Windows.Forms.DataGridViewTextBoxColumn ClientIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseIdColumn;

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseNameColumn;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RecipesDataGridView;

        #endregion
    }
}