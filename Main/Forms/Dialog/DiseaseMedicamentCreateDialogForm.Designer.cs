namespace PrihodkoCourse.Forms.Dialog
{
    partial class DiseaseMedicamentCreateDialogForm
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
            this.MedicamentComboBox = new System.Windows.Forms.ComboBox();
            this.DiseaseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MedicamentComboBox
            // 
            this.MedicamentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MedicamentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MedicamentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MedicamentComboBox.FormattingEnabled = true;
            this.MedicamentComboBox.Location = new System.Drawing.Point(12, 147);
            this.MedicamentComboBox.Name = "MedicamentComboBox";
            this.MedicamentComboBox.Size = new System.Drawing.Size(660, 33);
            this.MedicamentComboBox.TabIndex = 13;
            this.MedicamentComboBox.SelectedIndexChanged += new System.EventHandler(this.MedicamentComboBox_SelectedIndexChanged);
            // 
            // DiseaseComboBox
            // 
            this.DiseaseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DiseaseComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DiseaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiseaseComboBox.FormattingEnabled = true;
            this.DiseaseComboBox.Location = new System.Drawing.Point(12, 85);
            this.DiseaseComboBox.Name = "DiseaseComboBox";
            this.DiseaseComboBox.Size = new System.Drawing.Size(660, 33);
            this.DiseaseComboBox.TabIndex = 12;
            this.DiseaseComboBox.SelectedIndexChanged += new System.EventHandler(this.DiseaseComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Medicament:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Disease:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(522, 300);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 50);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 300);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 50);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Disease Medicament:";
            // 
            // DiseaseMedicamentCreateDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiseaseComboBox);
            this.Controls.Add(this.MedicamentComboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DiseaseMedicamentCreateDialogForm";
            this.Text = "DiseaseMedicamentCreateDialogForm";
            this.Load += new System.EventHandler(this.DiseaseMedicamentCreateDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox MedicamentComboBox;

        #endregion

        private System.Windows.Forms.ComboBox DiseaseComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label3;
    }
}