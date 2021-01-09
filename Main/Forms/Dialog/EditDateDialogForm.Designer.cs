namespace PrihodkoCourse.Forms.Dialog
{
    partial class EditDateDialogForm
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewValueTextBox = new System.Windows.Forms.TextBox();
            this.OldValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewValueCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(168, 299);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 50);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 300);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 50);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewValueTextBox
            // 
            this.NewValueTextBox.Location = new System.Drawing.Point(12, 152);
            this.NewValueTextBox.Name = "NewValueTextBox";
            this.NewValueTextBox.ReadOnly = true;
            this.NewValueTextBox.Size = new System.Drawing.Size(310, 29);
            this.NewValueTextBox.TabIndex = 11;
            // 
            // OldValueTextBox
            // 
            this.OldValueTextBox.Location = new System.Drawing.Point(12, 88);
            this.OldValueTextBox.Name = "OldValueTextBox";
            this.OldValueTextBox.ReadOnly = true;
            this.OldValueTextBox.Size = new System.Drawing.Size(310, 29);
            this.OldValueTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "New value (Date):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Old value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Edit:";
            // 
            // NewValueCalendar
            // 
            this.NewValueCalendar.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.NewValueCalendar.Location = new System.Drawing.Point(334, 43);
            this.NewValueCalendar.Name = "NewValueCalendar";
            this.NewValueCalendar.TabIndex = 14;
            this.NewValueCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.NewValueCalendar_DateChanged);
            // 
            // EditDateDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.NewValueCalendar);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NewValueTextBox);
            this.Controls.Add(this.OldValueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditDateDialogForm";
            this.Text = "EditDateDialogForm";
            this.Load += new System.EventHandler(this.EditDateDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MonthCalendar NewValueCalendar;

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewValueTextBox;
        private System.Windows.Forms.TextBox OldValueTextBox;
        private System.Windows.Forms.Button SubmitButton;

        #endregion
    }
}