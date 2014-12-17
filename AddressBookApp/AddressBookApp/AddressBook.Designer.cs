namespace AddressBookApp
{
    partial class AddressBook
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.showAllbutton = new System.Windows.Forms.Button();
            this.showAllListView = new System.Windows.Forms.ListView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.NameRadioButton = new System.Windows.Forms.RadioButton();
            this.EmailRadioButton = new System.Windows.Forms.RadioButton();
            this.numberRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(142, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(175, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(349, 50);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(142, 81);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(175, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(142, 118);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(175, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // showAllbutton
            // 
            this.showAllbutton.Location = new System.Drawing.Point(349, 157);
            this.showAllbutton.Name = "showAllbutton";
            this.showAllbutton.Size = new System.Drawing.Size(75, 23);
            this.showAllbutton.TabIndex = 2;
            this.showAllbutton.Text = "Show All";
            this.showAllbutton.UseVisualStyleBackColor = true;
            this.showAllbutton.Click += new System.EventHandler(this.showAllbutton_Click);
            // 
            // showAllListView
            // 
            this.showAllListView.Location = new System.Drawing.Point(27, 185);
            this.showAllListView.Name = "showAllListView";
            this.showAllListView.Size = new System.Drawing.Size(461, 97);
            this.showAllListView.TabIndex = 3;
            this.showAllListView.UseCompatibleStateImageBehavior = false;
            this.showAllListView.View = System.Windows.Forms.View.List;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(142, 347);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(175, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(349, 344);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // NameRadioButton
            // 
            this.NameRadioButton.AutoSize = true;
            this.NameRadioButton.Location = new System.Drawing.Point(27, 350);
            this.NameRadioButton.Name = "NameRadioButton";
            this.NameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.NameRadioButton.TabIndex = 4;
            this.NameRadioButton.TabStop = true;
            this.NameRadioButton.Text = "Name";
            this.NameRadioButton.UseVisualStyleBackColor = true;
            this.NameRadioButton.CheckedChanged += new System.EventHandler(this.NameRadioButton_CheckedChanged);
            // 
            // EmailRadioButton
            // 
            this.EmailRadioButton.AutoSize = true;
            this.EmailRadioButton.Location = new System.Drawing.Point(27, 373);
            this.EmailRadioButton.Name = "EmailRadioButton";
            this.EmailRadioButton.Size = new System.Drawing.Size(50, 17);
            this.EmailRadioButton.TabIndex = 4;
            this.EmailRadioButton.TabStop = true;
            this.EmailRadioButton.Text = "Email";
            this.EmailRadioButton.UseVisualStyleBackColor = true;
            // 
            // numberRadioButton
            // 
            this.numberRadioButton.AutoSize = true;
            this.numberRadioButton.Location = new System.Drawing.Point(27, 396);
            this.numberRadioButton.Name = "numberRadioButton";
            this.numberRadioButton.Size = new System.Drawing.Size(102, 17);
            this.numberRadioButton.TabIndex = 4;
            this.numberRadioButton.TabStop = true;
            this.numberRadioButton.Text = "Contact Number";
            this.numberRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 466);
            this.Controls.Add(this.numberRadioButton);
            this.Controls.Add(this.EmailRadioButton);
            this.Controls.Add(this.NameRadioButton);
            this.Controls.Add(this.showAllListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.showAllbutton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddressBook";
            this.Text = "AddressBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button showAllbutton;
        private System.Windows.Forms.ListView showAllListView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton NameRadioButton;
        private System.Windows.Forms.RadioButton EmailRadioButton;
        private System.Windows.Forms.RadioButton numberRadioButton;
    }
}

