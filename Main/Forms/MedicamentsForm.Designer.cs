namespace PrihodkoCourse.Forms
{
    partial class MedicamentsForm
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
            this.DiseasesButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.MedicamentsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubstitutesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.MedicamentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DiseasesButton
            // 
            this.DiseasesButton.Location = new System.Drawing.Point(354, 600);
            this.DiseasesButton.Name = "DiseasesButton";
            this.DiseasesButton.Size = new System.Drawing.Size(150, 50);
            this.DiseasesButton.TabIndex = 7;
            this.DiseasesButton.Text = "Diseases";
            this.DiseasesButton.UseVisualStyleBackColor = true;
            this.DiseasesButton.Click += new System.EventHandler(this.DiseasesButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicaments";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(510, 600);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 50);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create new";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 55);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(960, 33);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 600);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 50);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(822, 600);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 50);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(666, 600);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 50);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // MedicamentsDataGridView
            // 
            this.MedicamentsDataGridView.AllowUserToAddRows = false;
            this.MedicamentsDataGridView.AllowUserToDeleteRows = false;
            this.MedicamentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicamentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.IdColumn, this.NameColumn, this.StockQuantityColumn});
            this.MedicamentsDataGridView.Location = new System.Drawing.Point(12, 93);
            this.MedicamentsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.MedicamentsDataGridView.MultiSelect = false;
            this.MedicamentsDataGridView.Name = "MedicamentsDataGridView";
            this.MedicamentsDataGridView.ReadOnly = true;
            this.MedicamentsDataGridView.Size = new System.Drawing.Size(960, 498);
            this.MedicamentsDataGridView.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 70;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // StockQuantityColumn
            // 
            this.StockQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StockQuantityColumn.HeaderText = "StockQuantity";
            this.StockQuantityColumn.Name = "StockQuantityColumn";
            this.StockQuantityColumn.ReadOnly = true;
            // 
            // SubstitutesButton
            // 
            this.SubstitutesButton.Location = new System.Drawing.Point(198, 600);
            this.SubstitutesButton.Name = "SubstitutesButton";
            this.SubstitutesButton.Size = new System.Drawing.Size(150, 50);
            this.SubstitutesButton.TabIndex = 8;
            this.SubstitutesButton.Text = "Substitutes";
            this.SubstitutesButton.UseVisualStyleBackColor = true;
            this.SubstitutesButton.Click += new System.EventHandler(this.SubstitutesButton_Click);
            // 
            // MedicamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.SubstitutesButton);
            this.Controls.Add(this.MedicamentsDataGridView);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiseasesButton);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MedicamentsForm";
            this.Text = "MedicamentsForm";
            this.Load += new System.EventHandler(this.MedicamentsForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.MedicamentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button SubstitutesButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQuantityColumn;

        #endregion

        private System.Windows.Forms.Button DiseasesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView MedicamentsDataGridView;
    }
}