
namespace Car_Rental_Agency
{
    partial class EmployeeLogin
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.empEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.employeepassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
=======
            this.email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.queryResult = new System.Windows.Forms.Label();
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
            this.SuspendLayout();
            // Query label

            this.queryResult.Visible = false;
             this.queryResult.AutoSize = true;
            this.queryResult.Location = new System.Drawing.Point(0, 10);
            this.queryResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.queryResult.Name = "queryResult";
            this.queryResult.Size = new System.Drawing.Size(51, 20);
            this.queryResult.TabIndex = 0;
            this.queryResult.Text = "";

            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // empEmail
            // 
            this.empEmail.AutoSize = true;
            this.empEmail.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEmail.ForeColor = System.Drawing.Color.White;
            this.empEmail.Location = new System.Drawing.Point(753, 211);
            this.empEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(297, 45);
            this.empEmail.TabIndex = 1;
            this.empEmail.Text = "Employee Email";
            this.empEmail.Click += new System.EventHandler(this.empEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(753, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
<<<<<<< HEAD
            // employeeTextBox
            // 
            this.employeeTextBox.Location = new System.Drawing.Point(507, 192);
            this.employeeTextBox.Multiline = true;
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.Size = new System.Drawing.Size(249, 28);
            this.employeeTextBox.TabIndex = 3;
            // 
            // employeepassword
            // 
            this.employeepassword.Location = new System.Drawing.Point(507, 300);
            this.employeepassword.Multiline = true;
            this.employeepassword.Name = "employeepassword";
            this.employeepassword.Size = new System.Drawing.Size(249, 28);
            this.employeepassword.TabIndex = 4;
=======
            // email
            // 
            this.email.Location = new System.Drawing.Point(760, 295);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(372, 41);
            this.email.TabIndex = 3;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.email.Text +="";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(760, 462);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(372, 41);
            this.pass.TabIndex = 4;
            this.pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
              this.pass.Text +="";
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(848, 595);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 237);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee \r\nLogin \r\nPortal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(43, 396);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 7;
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeepassword);
            this.Controls.Add(this.employeeTextBox);
=======
            this.ClientSize = new System.Drawing.Size(1246, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.Load += new System.EventHandler(this.EmployeeLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label empEmail;
        private System.Windows.Forms.Label label2;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.TextBox employeepassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorLabel;
=======
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label queryResult;
>>>>>>> d6558f2d1e9b9827101cabaddeab3702fa5a6d28
    }
}