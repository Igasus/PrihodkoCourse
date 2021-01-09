namespace PrihodkoCourse.Forms.Dialog
{
    partial class RecipeCreateDialogForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateRecipeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.ClientChooseButton = new System.Windows.Forms.Button();
            this.DiseaseChooseButton = new System.Windows.Forms.Button();
            this.DiseaseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Disease:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Recipe:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 300);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 50);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateRecipeButton
            // 
            this.CreateRecipeButton.Location = new System.Drawing.Point(522, 299);
            this.CreateRecipeButton.Name = "CreateRecipeButton";
            this.CreateRecipeButton.Size = new System.Drawing.Size(150, 50);
            this.CreateRecipeButton.TabIndex = 9;
            this.CreateRecipeButton.Text = "Create Recipe";
            this.CreateRecipeButton.UseVisualStyleBackColor = true;
            this.CreateRecipeButton.Click += new System.EventHandler(this.CreateRecipeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Client:";
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Location = new System.Drawing.Point(12, 87);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.ReadOnly = true;
            this.ClientTextBox.Size = new System.Drawing.Size(504, 29);
            this.ClientTextBox.TabIndex = 24;
            // 
            // ClientChooseButton
            // 
            this.ClientChooseButton.Location = new System.Drawing.Point(522, 66);
            this.ClientChooseButton.Name = "ClientChooseButton";
            this.ClientChooseButton.Size = new System.Drawing.Size(150, 50);
            this.ClientChooseButton.TabIndex = 25;
            this.ClientChooseButton.Text = "Choose";
            this.ClientChooseButton.UseVisualStyleBackColor = true;
            this.ClientChooseButton.Click += new System.EventHandler(this.ClientChooseButton_Click);
            // 
            // DiseaseChooseButton
            // 
            this.DiseaseChooseButton.Location = new System.Drawing.Point(522, 130);
            this.DiseaseChooseButton.Name = "DiseaseChooseButton";
            this.DiseaseChooseButton.Size = new System.Drawing.Size(150, 50);
            this.DiseaseChooseButton.TabIndex = 26;
            this.DiseaseChooseButton.Text = "Choose";
            this.DiseaseChooseButton.UseVisualStyleBackColor = true;
            this.DiseaseChooseButton.Click += new System.EventHandler(this.DiseaseChooseButton_Click);
            // 
            // DiseaseTextBox
            // 
            this.DiseaseTextBox.Location = new System.Drawing.Point(12, 151);
            this.DiseaseTextBox.Name = "DiseaseTextBox";
            this.DiseaseTextBox.ReadOnly = true;
            this.DiseaseTextBox.Size = new System.Drawing.Size(504, 29);
            this.DiseaseTextBox.TabIndex = 27;
            // 
            // RecipeCreateDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.DiseaseTextBox);
            this.Controls.Add(this.DiseaseChooseButton);
            this.Controls.Add(this.ClientChooseButton);
            this.Controls.Add(this.ClientTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateRecipeButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RecipeCreateDialogForm";
            this.Text = "RecipeCreateDialogForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ClientChooseButton;
        private System.Windows.Forms.Button CreateRecipeButton;
        private System.Windows.Forms.Button DiseaseChooseButton;

        private System.Windows.Forms.TextBox ClientTextBox;
        private System.Windows.Forms.TextBox DiseaseTextBox;

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        #endregion
    }
}