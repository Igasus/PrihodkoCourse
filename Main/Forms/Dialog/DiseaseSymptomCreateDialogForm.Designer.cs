using System.ComponentModel;

namespace PrihodkoCourse.Forms.Dialog
{
    partial class DiseaseSymptomCreateDialogForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DiseaseComboBox = new System.Windows.Forms.ComboBox();
            this.SymptomComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Disease Symptom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Symptom:";
            // 
            // DiseaseComboBox
            // 
            this.DiseaseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DiseaseComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DiseaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiseaseComboBox.FormattingEnabled = true;
            this.DiseaseComboBox.Location = new System.Drawing.Point(12, 85);
            this.DiseaseComboBox.Name = "DiseaseComboBox";
            this.DiseaseComboBox.Size = new System.Drawing.Size(660, 32);
            this.DiseaseComboBox.TabIndex = 12;
            this.DiseaseComboBox.SelectedIndexChanged += new System.EventHandler(this.DiseaseComboBox_SelectedIndexChanged);
            // 
            // SymptomComboBox
            // 
            this.SymptomComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SymptomComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SymptomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SymptomComboBox.FormattingEnabled = true;
            this.SymptomComboBox.Location = new System.Drawing.Point(12, 147);
            this.SymptomComboBox.Name = "SymptomComboBox";
            this.SymptomComboBox.Size = new System.Drawing.Size(660, 32);
            this.SymptomComboBox.TabIndex = 13;
            this.SymptomComboBox.SelectedIndexChanged += new System.EventHandler(this.SymptomComboBox_SelectedIndexChanged);
            // 
            // DiseaseSymptomCreateDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.SymptomComboBox);
            this.Controls.Add(this.DiseaseComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DiseaseSymptomCreateDialogForm";
            this.Text = "DiseaseSymptomCreateForm";
            this.Load += new System.EventHandler(this.DiseaseSymptomCreateDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox SymptomComboBox;

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox DiseaseComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmitButton;

        #endregion
    }
}