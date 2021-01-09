using System.ComponentModel;

namespace PrihodkoCourse.Forms.Dialog
{
    partial class RecipeCreateFinishDialogForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MedicamentsDataGridView = new System.Windows.Forms.DataGridView();
            this.MedicamentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicamentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.MedicamentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here is recipe medicaments which we have is stock:";
            // 
            // MedicamentsDataGridView
            // 
            this.MedicamentsDataGridView.AllowUserToAddRows = false;
            this.MedicamentsDataGridView.AllowUserToDeleteRows = false;
            this.MedicamentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicamentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.MedicamentIdColumn, this.MedicamentNameColumn, this.DoseColumn});
            this.MedicamentsDataGridView.Location = new System.Drawing.Point(15, 38);
            this.MedicamentsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.MedicamentsDataGridView.MultiSelect = false;
            this.MedicamentsDataGridView.Name = "MedicamentsDataGridView";
            this.MedicamentsDataGridView.ReadOnly = true;
            this.MedicamentsDataGridView.RowHeadersVisible = false;
            this.MedicamentsDataGridView.Size = new System.Drawing.Size(654, 252);
            this.MedicamentsDataGridView.TabIndex = 19;
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
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 299);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 50);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "No";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(522, 299);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 50);
            this.SubmitButton.TabIndex = 24;
            this.SubmitButton.Text = "Yes";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(210, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Do you want to crete recipe?";
            // 
            // RecipeCreateFinishDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.MedicamentsDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RecipeCreateFinishDialogForm";
            this.Text = "RecipeCreateFinishDialogForm";
            this.Load += new System.EventHandler(this.RecipeCreateFinishDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.MedicamentsDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridView MedicamentsDataGridView;
        private System.Windows.Forms.Button SubmitButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn DoseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicamentNameColumn;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}