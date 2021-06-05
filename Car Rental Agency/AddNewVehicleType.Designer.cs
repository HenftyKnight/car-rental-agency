
namespace Car_Rental_Agency
{
    partial class AddNewVehicleType
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.carTypeTextBox = new System.Windows.Forms.TextBox();
            this.weeklyFeeTextBox = new System.Windows.Forms.TextBox();
            this.dailyFeeTextBox = new System.Windows.Forms.TextBox();
            this.monthlyFeeTextBox = new System.Windows.Forms.TextBox();
            this.lateFeeTextBox = new System.Windows.Forms.TextBox();
            this.changeBranchTextBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.queryResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.changeBranchTextBox);
            this.groupBox1.Controls.Add(this.lateFeeTextBox);
            this.groupBox1.Controls.Add(this.monthlyFeeTextBox);
            this.groupBox1.Controls.Add(this.dailyFeeTextBox);
            this.groupBox1.Controls.Add(this.weeklyFeeTextBox);
            this.groupBox1.Controls.Add(this.carTypeTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(45, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daily Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weekly Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monthly Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Late Fee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Change Branch Fee";
            // 
            // carTypeTextBox
            // 
            this.carTypeTextBox.Location = new System.Drawing.Point(267, 40);
            this.carTypeTextBox.Multiline = true;
            this.carTypeTextBox.Name = "carTypeTextBox";
            this.carTypeTextBox.Size = new System.Drawing.Size(259, 27);
            this.carTypeTextBox.TabIndex = 6;
            // 
            // weeklyFeeTextBox
            // 
            this.weeklyFeeTextBox.Location = new System.Drawing.Point(267, 120);
            this.weeklyFeeTextBox.Multiline = true;
            this.weeklyFeeTextBox.Name = "weeklyFeeTextBox";
            this.weeklyFeeTextBox.Size = new System.Drawing.Size(259, 27);
            this.weeklyFeeTextBox.TabIndex = 7;
            // 
            // dailyFeeTextBox
            // 
            this.dailyFeeTextBox.Location = new System.Drawing.Point(267, 80);
            this.dailyFeeTextBox.Multiline = true;
            this.dailyFeeTextBox.Name = "dailyFeeTextBox";
            this.dailyFeeTextBox.Size = new System.Drawing.Size(259, 27);
            this.dailyFeeTextBox.TabIndex = 8;
            // 
            // monthlyFeeTextBox
            // 
            this.monthlyFeeTextBox.Location = new System.Drawing.Point(267, 161);
            this.monthlyFeeTextBox.Multiline = true;
            this.monthlyFeeTextBox.Name = "monthlyFeeTextBox";
            this.monthlyFeeTextBox.Size = new System.Drawing.Size(259, 27);
            this.monthlyFeeTextBox.TabIndex = 9;
            // 
            // lateFeeTextBox
            // 
            this.lateFeeTextBox.Location = new System.Drawing.Point(267, 199);
            this.lateFeeTextBox.Multiline = true;
            this.lateFeeTextBox.Name = "lateFeeTextBox";
            this.lateFeeTextBox.Size = new System.Drawing.Size(259, 27);
            this.lateFeeTextBox.TabIndex = 10;
            // 
            // changeBranchTextBox
            // 
            this.changeBranchTextBox.Location = new System.Drawing.Point(267, 242);
            this.changeBranchTextBox.Multiline = true;
            this.changeBranchTextBox.Name = "changeBranchTextBox";
            this.changeBranchTextBox.Size = new System.Drawing.Size(259, 27);
            this.changeBranchTextBox.TabIndex = 11;
            // 
            // submitBtn
            // 
            this.submitBtn.ForeColor = System.Drawing.Color.Black;
            this.submitBtn.Location = new System.Drawing.Point(331, 288);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(127, 32);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Add Type";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(245, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 41);
            this.label7.TabIndex = 2;
            this.label7.Text = "Add Vehicle Type";
            // 
            // queryResult
            // 
            this.queryResult.AutoSize = true;
            this.queryResult.Location = new System.Drawing.Point(309, 428);
            this.queryResult.Name = "queryResult";
            this.queryResult.Size = new System.Drawing.Size(35, 13);
            this.queryResult.TabIndex = 2;
            this.queryResult.Text = "label8";
            // 
            // AddNewVehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewVehicleType";
            this.Text = "AddNewVehicleType";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox changeBranchTextBox;
        private System.Windows.Forms.TextBox lateFeeTextBox;
        private System.Windows.Forms.TextBox monthlyFeeTextBox;
        private System.Windows.Forms.TextBox dailyFeeTextBox;
        private System.Windows.Forms.TextBox weeklyFeeTextBox;
        private System.Windows.Forms.TextBox carTypeTextBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label queryResult;
    }
}