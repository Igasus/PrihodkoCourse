namespace PrihodkoCourse.Forms
{
    partial class SubstitutesForm
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubstituteTextBox = new System.Windows.Forms.TextBox();
            this.MedicamentTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalMedicamentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalMedicamentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalDosageMultiplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubstituteDataGridView = new System.Windows.Forms.DataGridView();
            this.SubstituteMedicamentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubstituteMedicamentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubstituteDosageMultiplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalDataGridView = new System.Windows.Forms.DataGridView();
            this.SubstituteDeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SubstituteEditButton = new System.Windows.Forms.Button();
            this.SubstituteCreateButton = new System.Windows.Forms.Button();
            this.SubstituteSubstitutesButton = new System.Windows.Forms.Button();
            this.OriginalDeleteButton = new System.Windows.Forms.Button();
            this.OriginalEditButton = new System.Windows.Forms.Button();
            this.OriginalSubstitutesButton = new System.Windows.Forms.Button();
            this.OriginalCreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.SubstituteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.OriginalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "StockQuantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // OriginalTextBox
            // 
            this.OriginalTextBox.Location = new System.Drawing.Point(12, 93);
            this.OriginalTextBox.Name = "OriginalTextBox";
            this.OriginalTextBox.Size = new System.Drawing.Size(477, 33);
            this.OriginalTextBox.TabIndex = 3;
            this.OriginalTextBox.TextChanged += new System.EventHandler(this.OriginalTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicament:";
            // 
            // SubstituteTextBox
            // 
            this.SubstituteTextBox.Location = new System.Drawing.Point(495, 93);
            this.SubstituteTextBox.Name = "SubstituteTextBox";
            this.SubstituteTextBox.Size = new System.Drawing.Size(477, 33);
            this.SubstituteTextBox.TabIndex = 3;
            this.SubstituteTextBox.TextChanged += new System.EventHandler(this.SubstituteTextBox_TextChanged);
            // 
            // MedicamentTextBox
            // 
            this.MedicamentTextBox.Location = new System.Drawing.Point(143, 7);
            this.MedicamentTextBox.Name = "MedicamentTextBox";
            this.MedicamentTextBox.ReadOnly = true;
            this.MedicamentTextBox.Size = new System.Drawing.Size(829, 33);
            this.MedicamentTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Is substitute for:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(495, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Substitutes:";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "MedcamentId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "MedicamentName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.Width = 180;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Multiplier";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Width = 113;
            // 
            // OriginalMedicamentIdColumn
            // 
            this.OriginalMedicamentIdColumn.HeaderText = "MedcamentId";
            this.OriginalMedicamentIdColumn.Name = "OriginalMedicamentIdColumn";
            this.OriginalMedicamentIdColumn.ReadOnly = true;
            this.OriginalMedicamentIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OriginalMedicamentIdColumn.Width = 140;
            // 
            // OriginalMedicamentNameColumn
            // 
            this.OriginalMedicamentNameColumn.HeaderText = "MedicamentName";
            this.OriginalMedicamentNameColumn.Name = "OriginalMedicamentNameColumn";
            this.OriginalMedicamentNameColumn.ReadOnly = true;
            this.OriginalMedicamentNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OriginalMedicamentNameColumn.Width = 175;
            // 
            // OriginalDosageMultiplierColumn
            // 
            this.OriginalDosageMultiplierColumn.HeaderText = "DosageMultiplier";
            this.OriginalDosageMultiplierColumn.Name = "OriginalDosageMultiplierColumn";
            this.OriginalDosageMultiplierColumn.ReadOnly = true;
            this.OriginalDosageMultiplierColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OriginalDosageMultiplierColumn.Width = 158;
            // 
            // SubstituteDataGridView
            // 
            this.SubstituteDataGridView.AllowUserToAddRows = false;
            this.SubstituteDataGridView.AllowUserToDeleteRows = false;
            this.SubstituteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubstituteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.SubstituteMedicamentIdColumn, this.SubstituteMedicamentNameColumn, this.SubstituteDosageMultiplierColumn});
            this.SubstituteDataGridView.Location = new System.Drawing.Point(495, 135);
            this.SubstituteDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.SubstituteDataGridView.MultiSelect = false;
            this.SubstituteDataGridView.Name = "SubstituteDataGridView";
            this.SubstituteDataGridView.ReadOnly = true;
            this.SubstituteDataGridView.RowHeadersVisible = false;
            this.SubstituteDataGridView.Size = new System.Drawing.Size(477, 400);
            this.SubstituteDataGridView.TabIndex = 0;
            // 
            // SubstituteMedicamentIdColumn
            // 
            this.SubstituteMedicamentIdColumn.HeaderText = "MedicamentId";
            this.SubstituteMedicamentIdColumn.Name = "SubstituteMedicamentIdColumn";
            this.SubstituteMedicamentIdColumn.ReadOnly = true;
            this.SubstituteMedicamentIdColumn.Width = 140;
            // 
            // SubstituteMedicamentNameColumn
            // 
            this.SubstituteMedicamentNameColumn.HeaderText = "MedicamentName";
            this.SubstituteMedicamentNameColumn.Name = "SubstituteMedicamentNameColumn";
            this.SubstituteMedicamentNameColumn.ReadOnly = true;
            this.SubstituteMedicamentNameColumn.Width = 175;
            // 
            // SubstituteDosageMultiplierColumn
            // 
            this.SubstituteDosageMultiplierColumn.HeaderText = "DosageMultiplier";
            this.SubstituteDosageMultiplierColumn.Name = "SubstituteDosageMultiplierColumn";
            this.SubstituteDosageMultiplierColumn.ReadOnly = true;
            this.SubstituteDosageMultiplierColumn.Width = 158;
            // 
            // OriginalDataGridView
            // 
            this.OriginalDataGridView.AllowUserToAddRows = false;
            this.OriginalDataGridView.AllowUserToDeleteRows = false;
            this.OriginalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OriginalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.OriginalMedicamentIdColumn, this.OriginalMedicamentNameColumn, this.OriginalDosageMultiplierColumn});
            this.OriginalDataGridView.Location = new System.Drawing.Point(12, 135);
            this.OriginalDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.OriginalDataGridView.MultiSelect = false;
            this.OriginalDataGridView.Name = "OriginalDataGridView";
            this.OriginalDataGridView.ReadOnly = true;
            this.OriginalDataGridView.RowHeadersVisible = false;
            this.OriginalDataGridView.Size = new System.Drawing.Size(477, 400);
            this.OriginalDataGridView.TabIndex = 0;
            // 
            // SubstituteDeleteButton
            // 
            this.SubstituteDeleteButton.Location = new System.Drawing.Point(872, 544);
            this.SubstituteDeleteButton.Name = "SubstituteDeleteButton";
            this.SubstituteDeleteButton.Size = new System.Drawing.Size(100, 50);
            this.SubstituteDeleteButton.TabIndex = 8;
            this.SubstituteDeleteButton.Text = "Delete";
            this.SubstituteDeleteButton.UseVisualStyleBackColor = true;
            this.SubstituteDeleteButton.Click += new System.EventHandler(this.SubstituteDeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 600);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 50);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SubstituteEditButton
            // 
            this.SubstituteEditButton.Location = new System.Drawing.Point(766, 544);
            this.SubstituteEditButton.Name = "SubstituteEditButton";
            this.SubstituteEditButton.Size = new System.Drawing.Size(100, 50);
            this.SubstituteEditButton.TabIndex = 10;
            this.SubstituteEditButton.Text = "Edit";
            this.SubstituteEditButton.UseVisualStyleBackColor = true;
            this.SubstituteEditButton.Click += new System.EventHandler(this.SubstituteEditButton_Click);
            // 
            // SubstituteCreateButton
            // 
            this.SubstituteCreateButton.Location = new System.Drawing.Point(640, 544);
            this.SubstituteCreateButton.Name = "SubstituteCreateButton";
            this.SubstituteCreateButton.Size = new System.Drawing.Size(120, 50);
            this.SubstituteCreateButton.TabIndex = 11;
            this.SubstituteCreateButton.Text = "Create new";
            this.SubstituteCreateButton.UseVisualStyleBackColor = true;
            this.SubstituteCreateButton.Click += new System.EventHandler(this.SubstituteCreateButton_Click);
            // 
            // SubstituteSubstitutesButton
            // 
            this.SubstituteSubstitutesButton.Location = new System.Drawing.Point(514, 544);
            this.SubstituteSubstitutesButton.Name = "SubstituteSubstitutesButton";
            this.SubstituteSubstitutesButton.Size = new System.Drawing.Size(120, 50);
            this.SubstituteSubstitutesButton.TabIndex = 12;
            this.SubstituteSubstitutesButton.Text = "Substitutes";
            this.SubstituteSubstitutesButton.UseVisualStyleBackColor = true;
            this.SubstituteSubstitutesButton.Click += new System.EventHandler(this.SubstituteSubstitutesButton_Click);
            // 
            // OriginalDeleteButton
            // 
            this.OriginalDeleteButton.Location = new System.Drawing.Point(370, 544);
            this.OriginalDeleteButton.Name = "OriginalDeleteButton";
            this.OriginalDeleteButton.Size = new System.Drawing.Size(100, 50);
            this.OriginalDeleteButton.TabIndex = 13;
            this.OriginalDeleteButton.Text = "Delete";
            this.OriginalDeleteButton.UseVisualStyleBackColor = true;
            this.OriginalDeleteButton.Click += new System.EventHandler(this.OriginalDeleteButton_Click);
            // 
            // OriginalEditButton
            // 
            this.OriginalEditButton.Location = new System.Drawing.Point(264, 544);
            this.OriginalEditButton.Name = "OriginalEditButton";
            this.OriginalEditButton.Size = new System.Drawing.Size(100, 50);
            this.OriginalEditButton.TabIndex = 14;
            this.OriginalEditButton.Text = "Edit";
            this.OriginalEditButton.UseVisualStyleBackColor = true;
            this.OriginalEditButton.Click += new System.EventHandler(this.OriginalEditButton_Click);
            // 
            // OriginalSubstitutesButton
            // 
            this.OriginalSubstitutesButton.Location = new System.Drawing.Point(12, 544);
            this.OriginalSubstitutesButton.Name = "OriginalSubstitutesButton";
            this.OriginalSubstitutesButton.Size = new System.Drawing.Size(120, 50);
            this.OriginalSubstitutesButton.TabIndex = 15;
            this.OriginalSubstitutesButton.Text = "Substitutes";
            this.OriginalSubstitutesButton.UseVisualStyleBackColor = true;
            this.OriginalSubstitutesButton.Click += new System.EventHandler(this.OriginalSubstitutesButton_Click);
            // 
            // OriginalCreateButton
            // 
            this.OriginalCreateButton.Location = new System.Drawing.Point(138, 544);
            this.OriginalCreateButton.Name = "OriginalCreateButton";
            this.OriginalCreateButton.Size = new System.Drawing.Size(120, 50);
            this.OriginalCreateButton.TabIndex = 16;
            this.OriginalCreateButton.Text = "Create new";
            this.OriginalCreateButton.UseVisualStyleBackColor = true;
            this.OriginalCreateButton.Click += new System.EventHandler(this.OriginalCreateButton_Click);
            // 
            // SubstitutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.OriginalCreateButton);
            this.Controls.Add(this.OriginalSubstitutesButton);
            this.Controls.Add(this.OriginalEditButton);
            this.Controls.Add(this.OriginalDeleteButton);
            this.Controls.Add(this.SubstituteSubstitutesButton);
            this.Controls.Add(this.SubstituteCreateButton);
            this.Controls.Add(this.SubstituteEditButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SubstituteDeleteButton);
            this.Controls.Add(this.SubstituteDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MedicamentTextBox);
            this.Controls.Add(this.SubstituteTextBox);
            this.Controls.Add(this.OriginalDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OriginalTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SubstitutesForm";
            this.Text = "SubstitutesForm";
            this.Load += new System.EventHandler(this.SubstitutesForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.SubstituteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.OriginalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button OriginalCreateButton;

        private System.Windows.Forms.Button BackButton;

        private System.Windows.Forms.Button OriginalDeleteButton;
        private System.Windows.Forms.Button OriginalEditButton;
        private System.Windows.Forms.Button OriginalSubstitutesButton;
        private System.Windows.Forms.Button SubstituteCreateButton;
        private System.Windows.Forms.Button SubstituteDeleteButton;
        private System.Windows.Forms.Button SubstituteEditButton;
        private System.Windows.Forms.Button SubstituteSubstitutesButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn SubstituteDosageMultiplierColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn SubstituteMedicamentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubstituteMedicamentNameColumn;

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox OriginalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubstituteTextBox;
        private System.Windows.Forms.TextBox MedicamentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView OriginalDataGridView;
        private System.Windows.Forms.DataGridView SubstituteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalMedicamentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalMedicamentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalDosageMultiplierColumn;
    }
}