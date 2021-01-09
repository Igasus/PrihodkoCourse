using System.ComponentModel;

namespace PrihodkoCourse.Forms
{
    partial class RecipeMedicamentsForm
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
            this.RecipeMedicamentsDataGridView = new System.Windows.Forms.DataGridView();
            this.RecipeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.RecipeMedicamentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeMedicamentsDataGridView
            // 
            this.RecipeMedicamentsDataGridView.AllowUserToAddRows = false;
            this.RecipeMedicamentsDataGridView.AllowUserToDeleteRows = false;
            this.RecipeMedicamentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeMedicamentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.RecipeIdColumn, this.MedicamentIdColumn, this.MedicamentNameColumn, this.DoseColumn});
            this.RecipeMedicamentsDataGridView.Location = new System.Drawing.Point(12, 58);
            this.RecipeMedicamentsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.RecipeMedicamentsDataGridView.MultiSelect = false;
            this.RecipeMedicamentsDataGridView.Name = "RecipeMedicamentsDataGridView";
            this.RecipeMedicamentsDataGridView.ReadOnly = true;
            this.RecipeMedicamentsDataGridView.RowHeadersVisible = false;
            this.RecipeMedicamentsDataGridView.Size = new System.Drawing.Size(960, 533);
            this.RecipeMedicamentsDataGridView.TabIndex = 9;
            // 
            // RecipeIdColumn
            // 
            this.RecipeIdColumn.HeaderText = "RecipeId";
            this.RecipeIdColumn.Name = "RecipeIdColumn";
            this.RecipeIdColumn.ReadOnly = true;
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
            // DoseColumn
            // 
            this.DoseColumn.HeaderText = "Dose";
            this.DoseColumn.Name = "DoseColumn";
            this.DoseColumn.ReadOnly = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(666, 600);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 50);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(822, 600);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 50);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 600);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 50);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recipe medicaments";
            // 
            // RecipeMedicamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.RecipeMedicamentsDataGridView);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RecipeMedicamentsForm";
            this.Text = "RecipeMedicamentsForm";
            this.Load += new System.EventHandler(this.RecipeMedicamentsForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.RecipeMedicamentsDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView RecipeMedicamentsDataGridView;

        private System.Windows.Forms.DataGridViewTextBoxColumn DoseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeIdColumn;

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}