﻿
namespace Car_Rental_Agency
{
    partial class Main
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
            this.Customer = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(488, 372);
            this.Customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(248, 60);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer Login";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.Employee.Location = new System.Drawing.Point(488, 558);
            this.Employee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(248, 57);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Employee Portal";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(280, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 95);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Rental Agency";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Customer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Label label1;
    }
}

