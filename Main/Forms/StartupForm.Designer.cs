namespace PrihodkoCourse.Forms
{
    partial class StartupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.SymptomsButton = new System.Windows.Forms.Button();
            this.DiseasesButton = new System.Windows.Forms.Button();
            this.MedicamentsButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.RecipesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SymptomsButton
            // 
            this.SymptomsButton.Location = new System.Drawing.Point(12, 12);
            this.SymptomsButton.Name = "SymptomsButton";
            this.SymptomsButton.Size = new System.Drawing.Size(660, 50);
            this.SymptomsButton.TabIndex = 8;
            this.SymptomsButton.Text = "Symptoms";
            this.SymptomsButton.UseVisualStyleBackColor = true;
            this.SymptomsButton.Click += new System.EventHandler(this.SymptomsButton_Click);
            // 
            // DiseasesButton
            // 
            this.DiseasesButton.Location = new System.Drawing.Point(12, 83);
            this.DiseasesButton.Name = "DiseasesButton";
            this.DiseasesButton.Size = new System.Drawing.Size(660, 50);
            this.DiseasesButton.TabIndex = 9;
            this.DiseasesButton.Text = "Diseases";
            this.DiseasesButton.UseVisualStyleBackColor = true;
            this.DiseasesButton.Click += new System.EventHandler(this.DiseasesButton_Click);
            // 
            // MedicamentsButton
            // 
            this.MedicamentsButton.Location = new System.Drawing.Point(12, 155);
            this.MedicamentsButton.Name = "MedicamentsButton";
            this.MedicamentsButton.Size = new System.Drawing.Size(660, 50);
            this.MedicamentsButton.TabIndex = 10;
            this.MedicamentsButton.Text = "Medicaments";
            this.MedicamentsButton.UseVisualStyleBackColor = true;
            this.MedicamentsButton.Click += new System.EventHandler(this.MedicamentsButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.Location = new System.Drawing.Point(12, 226);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(660, 50);
            this.ClientsButton.TabIndex = 11;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // RecipesButton
            // 
            this.RecipesButton.Location = new System.Drawing.Point(12, 299);
            this.RecipesButton.Name = "RecipesButton";
            this.RecipesButton.Size = new System.Drawing.Size(660, 50);
            this.RecipesButton.TabIndex = 12;
            this.RecipesButton.Text = "Recipes";
            this.RecipesButton.UseVisualStyleBackColor = true;
            this.RecipesButton.Click += new System.EventHandler(this.RecipesButton_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.RecipesButton);
            this.Controls.Add(this.ClientsButton);
            this.Controls.Add(this.MedicamentsButton);
            this.Controls.Add(this.DiseasesButton);
            this.Controls.Add(this.SymptomsButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StartupForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button RecipesButton;

        private System.Windows.Forms.Button ClientsButton;

        private System.Windows.Forms.Button MedicamentsButton;

        private System.Windows.Forms.Button DiseasesButton;
        private System.Windows.Forms.Button SymptomsButton;

        #endregion
    }
}

