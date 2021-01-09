using System.ComponentModel;

namespace PrihodkoCourse.Forms.Dialog
{
    partial class DiseaseChooseDialogForm
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
            this.DiseasesDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ChooseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.DiseasesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DiseasesDataGridView
            // 
            this.DiseasesDataGridView.AllowUserToAddRows = false;
            this.DiseasesDataGridView.AllowUserToDeleteRows = false;
            this.DiseasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiseasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.IdColumn, this.NameColumn});
            this.DiseasesDataGridView.Location = new System.Drawing.Point(12, 93);
            this.DiseasesDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.DiseasesDataGridView.MultiSelect = false;
            this.DiseasesDataGridView.Name = "DiseasesDataGridView";
            this.DiseasesDataGridView.ReadOnly = true;
            this.DiseasesDataGridView.Size = new System.Drawing.Size(960, 498);
            this.DiseasesDataGridView.TabIndex = 9;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdColumn.Width = 70;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Diseases";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 55);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(960, 29);
            this.SearchTextBox.TabIndex = 12;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 600);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 50);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(822, 599);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 50);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "Create new";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(168, 599);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(150, 50);
            this.ChooseButton.TabIndex = 14;
            this.ChooseButton.Text = "Choose";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // DiseaseChooseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.DiseasesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CancelButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DiseaseChooseDialogForm";
            this.Text = "DiseaseChooseDialogForm";
            this.Load += new System.EventHandler(this.DiseaseChooseDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.DiseasesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ChooseButton;

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView DiseasesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.TextBox SearchTextBox;

        #endregion
    }
}