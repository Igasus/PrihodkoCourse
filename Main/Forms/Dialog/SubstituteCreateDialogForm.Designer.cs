using System.ComponentModel;

namespace PrihodkoCourse.Forms.Dialog
{
    partial class SubstituteCreateDialogForm
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
            this.SubstituteComboBox = new System.Windows.Forms.ComboBox();
            this.OriginalComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DosageMultiplierTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubstituteComboBox
            // 
            this.SubstituteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SubstituteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SubstituteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubstituteComboBox.FormattingEnabled = true;
            this.SubstituteComboBox.Location = new System.Drawing.Point(12, 147);
            this.SubstituteComboBox.Name = "SubstituteComboBox";
            this.SubstituteComboBox.Size = new System.Drawing.Size(660, 32);
            this.SubstituteComboBox.TabIndex = 20;
            this.SubstituteComboBox.SelectedIndexChanged += new System.EventHandler(this.SubstituteComboBox_SelectedIndexChanged);
            // 
            // OriginalComboBox
            // 
            this.OriginalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.OriginalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OriginalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginalComboBox.FormattingEnabled = true;
            this.OriginalComboBox.Location = new System.Drawing.Point(12, 85);
            this.OriginalComboBox.Name = "OriginalComboBox";
            this.OriginalComboBox.Size = new System.Drawing.Size(660, 32);
            this.OriginalComboBox.TabIndex = 19;
            this.OriginalComboBox.SelectedIndexChanged += new System.EventHandler(this.OriginalComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Substitute medicament:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Original medicament:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(522, 300);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 50);
            this.SubmitButton.TabIndex = 16;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 300);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 50);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "New Substitute:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Dosage multiplier:";
            // 
            // DosageMultiplierTextBox
            // 
            this.DosageMultiplierTextBox.Location = new System.Drawing.Point(12, 209);
            this.DosageMultiplierTextBox.Name = "DosageMultiplierTextBox";
            this.DosageMultiplierTextBox.Size = new System.Drawing.Size(660, 29);
            this.DosageMultiplierTextBox.TabIndex = 23;
            // 
            // SubstituteCreateDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.DosageMultiplierTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SubstituteComboBox);
            this.Controls.Add(this.OriginalComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SubstituteCreateDialogForm";
            this.Text = "SubstituteCreateDialogForm";
            this.Load += new System.EventHandler(this.SubstituteCreateDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox DosageMultiplierTextBox;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OriginalComboBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox SubstituteComboBox;

        #endregion
    }
}