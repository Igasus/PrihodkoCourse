namespace PrihodkoCourse.Forms.Dialog
{
    partial class DosageCreateDialogForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.DiseaseNameTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinAgeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DoseTextBox = new System.Windows.Forms.TextBox();
            this.MedicamentNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Dosage:";
            // 
            // DiseaseNameTextBox
            // 
            this.DiseaseNameTextBox.Location = new System.Drawing.Point(12, 85);
            this.DiseaseNameTextBox.Name = "DiseaseNameTextBox";
            this.DiseaseNameTextBox.ReadOnly = true;
            this.DiseaseNameTextBox.Size = new System.Drawing.Size(320, 29);
            this.DiseaseNameTextBox.TabIndex = 6;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 300);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 50);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(522, 300);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 50);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Minimum age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Disease name:";
            // 
            // MinAgeTextBox
            // 
            this.MinAgeTextBox.Location = new System.Drawing.Point(12, 144);
            this.MinAgeTextBox.Name = "MinAgeTextBox";
            this.MinAgeTextBox.Size = new System.Drawing.Size(660, 29);
            this.MinAgeTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dose:";
            // 
            // DoseTextBox
            // 
            this.DoseTextBox.Location = new System.Drawing.Point(12, 203);
            this.DoseTextBox.Name = "DoseTextBox";
            this.DoseTextBox.Size = new System.Drawing.Size(660, 29);
            this.DoseTextBox.TabIndex = 2;
            // 
            // MedicamentNameTextBox
            // 
            this.MedicamentNameTextBox.Location = new System.Drawing.Point(352, 85);
            this.MedicamentNameTextBox.Name = "MedicamentNameTextBox";
            this.MedicamentNameTextBox.ReadOnly = true;
            this.MedicamentNameTextBox.Size = new System.Drawing.Size(320, 29);
            this.MedicamentNameTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Medicament name:";
            // 
            // DosageCreateDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MedicamentNameTextBox);
            this.Controls.Add(this.DoseTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MinAgeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiseaseNameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DosageCreateDialogForm";
            this.Text = "DosageCreateDialogForm";
            this.Load += new System.EventHandler(this.DosageCreateDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox DiseaseNameTextBox;
        private System.Windows.Forms.TextBox DoseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MedicamentNameTextBox;
        private System.Windows.Forms.TextBox MinAgeTextBox;
        private System.Windows.Forms.Button SubmitButton;

        #endregion
    }
}