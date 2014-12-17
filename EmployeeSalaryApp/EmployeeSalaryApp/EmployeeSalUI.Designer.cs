namespace EmployeeSalaryApp
{
    partial class EmployeeSalUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salaryAmountTextBox = new System.Windows.Forms.TextBox();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.showListBox = new System.Windows.Forms.ListBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(122, 26);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(122, 68);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(219, 20);
            this.employeeIdTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salary Amount:";
            // 
            // salaryAmountTextBox
            // 
            this.salaryAmountTextBox.Location = new System.Drawing.Point(122, 119);
            this.salaryAmountTextBox.Name = "salaryAmountTextBox";
            this.salaryAmountTextBox.Size = new System.Drawing.Size(219, 20);
            this.salaryAmountTextBox.TabIndex = 3;
            // 
            // saveDataButton
            // 
            this.saveDataButton.Location = new System.Drawing.Point(383, 23);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(101, 38);
            this.saveDataButton.TabIndex = 4;
            this.saveDataButton.Text = "Save";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(383, 162);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(101, 40);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "Show";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // showListBox
            // 
            this.showListBox.FormattingEnabled = true;
            this.showListBox.Location = new System.Drawing.Point(124, 162);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(217, 95);
            this.showListBox.TabIndex = 10;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(127, 296);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(217, 20);
            this.totalAmountTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Amount";
            // 
            // EmployeeSalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.salaryAmountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeSalUI";
            this.Text = "EmployeeSalUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salaryAmountTextBox;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.ListBox showListBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Label label4;
    }
}

