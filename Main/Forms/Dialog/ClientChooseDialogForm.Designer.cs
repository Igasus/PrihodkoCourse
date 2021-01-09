using System.ComponentModel;

namespace PrihodkoCourse.Forms.Dialog
{
    partial class ClientChooseDialogForm
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
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsurancePolicyNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ChooseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.ClientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsDataGridView
            // 
            this.ClientsDataGridView.AllowUserToAddRows = false;
            this.ClientsDataGridView.AllowUserToDeleteRows = false;
            this.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.IdColumn, this.FullNameColumn, this.PhoneNumberColumn, this.InsurancePolicyNumberColumn, this.SexColumn});
            this.ClientsDataGridView.Location = new System.Drawing.Point(12, 93);
            this.ClientsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.ClientsDataGridView.MultiSelect = false;
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.ReadOnly = true;
            this.ClientsDataGridView.RowHeadersVisible = false;
            this.ClientsDataGridView.Size = new System.Drawing.Size(960, 498);
            this.ClientsDataGridView.TabIndex = 16;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdColumn.Width = 40;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.HeaderText = "FullName";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            this.FullNameColumn.Width = 250;
            // 
            // PhoneNumberColumn
            // 
            this.PhoneNumberColumn.HeaderText = "PhoneNumber";
            this.PhoneNumberColumn.Name = "PhoneNumberColumn";
            this.PhoneNumberColumn.ReadOnly = true;
            this.PhoneNumberColumn.Width = 200;
            // 
            // InsurancePolicyNumberColumn
            // 
            this.InsurancePolicyNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InsurancePolicyNumberColumn.HeaderText = "InsurancePolicyNumber";
            this.InsurancePolicyNumberColumn.Name = "InsurancePolicyNumberColumn";
            this.InsurancePolicyNumberColumn.ReadOnly = true;
            // 
            // SexColumn
            // 
            this.SexColumn.HeaderText = "Sex";
            this.SexColumn.Name = "SexColumn";
            this.SexColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Clients";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(822, 600);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 50);
            this.CreateButton.TabIndex = 18;
            this.CreateButton.Text = "Create new";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 55);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(960, 29);
            this.SearchTextBox.TabIndex = 19;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 600);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 50);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(168, 600);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(150, 50);
            this.ChooseButton.TabIndex = 23;
            this.ChooseButton.Text = "Choose";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // ClientChooseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.ClientsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CancelButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ClientChooseDialogForm";
            this.Text = "ClientChooseDialogForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.ClientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.DataGridView ClientsDataGridView;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsurancePolicyNumberColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberColumn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexColumn;

        #endregion
    }
}