
namespace Car_Rental_Agency
{
    partial class AddNewBooking
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchbyUserNameBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.userIDTextBox);
            this.groupBox1.Controls.Add(this.userIDLabel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(236, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Booking by User ID";
            // 
            // submitBtn
            // 
            this.submitBtn.ForeColor = System.Drawing.Color.Black;
            this.submitBtn.Location = new System.Drawing.Point(86, 77);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Search";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(129, 35);
            this.userIDTextBox.Multiline = true;
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDTextBox.TabIndex = 1;
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Location = new System.Drawing.Point(19, 35);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(86, 13);
            this.userIDLabel.TabIndex = 0;
            this.userIDLabel.Text = "Enter the UserID";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(286, 317);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(58, 13);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "resultLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Booking For User";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lastNameComboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.userNameComboBox);
            this.groupBox2.Controls.Add(this.SearchbyUserNameBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(236, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Booking by User ID";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // SearchbyUserNameBtn
            // 
            this.SearchbyUserNameBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchbyUserNameBtn.Location = new System.Drawing.Point(102, 104);
            this.SearchbyUserNameBtn.Name = "SearchbyUserNameBtn";
            this.SearchbyUserNameBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchbyUserNameBtn.TabIndex = 2;
            this.SearchbyUserNameBtn.Text = "Search";
            this.SearchbyUserNameBtn.UseVisualStyleBackColor = true;
            this.SearchbyUserNameBtn.Click += new System.EventHandler(this.SearchbyUserNameBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select User First Name";
            // 
            // userNameComboBox
            // 
            this.userNameComboBox.FormattingEnabled = true;
            this.userNameComboBox.Location = new System.Drawing.Point(140, 32);
            this.userNameComboBox.Name = "userNameComboBox";
            this.userNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.userNameComboBox.TabIndex = 3;
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(140, 59);
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.lastNameComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select User Last Name";
            // 
            // AddNewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewBooking";
            this.Text = "AddNewBooking";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SearchbyUserNameBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox userNameComboBox;
        private System.Windows.Forms.ComboBox lastNameComboBox;
        private System.Windows.Forms.Label label3;
    }
}