﻿
namespace Car_Rental_Agency
{
    partial class DeleteVehicleType
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
            this.label8 = new System.Windows.Forms.Label();
            this.queryResultlabel = new System.Windows.Forms.Label();
            this.VehicleTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vehicleTypeSearchBtm = new System.Windows.Forms.Button();
            this.vehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateVtype = new System.Windows.Forms.Button();
            this.cBranchFeeTextBox = new System.Windows.Forms.TextBox();
            this.lateFeeTextBox = new System.Windows.Forms.TextBox();
            this.MonthlyFee = new System.Windows.Forms.TextBox();
            this.WeeklyFeeTextBox = new System.Windows.Forms.TextBox();
            this.DailyFee = new System.Windows.Forms.TextBox();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleTypeDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(212, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 32);
            this.label8.TabIndex = 23;
            this.label8.Text = "Delete Vehicle Type";
            // 
            // queryResultlabel
            // 
            this.queryResultlabel.AutoSize = true;
            this.queryResultlabel.Location = new System.Drawing.Point(510, 431);
            this.queryResultlabel.Name = "queryResultlabel";
            this.queryResultlabel.Size = new System.Drawing.Size(29, 13);
            this.queryResultlabel.TabIndex = 19;
            this.queryResultlabel.Text = "label";
            // 
            // VehicleTypeDataGridView
            // 
            this.VehicleTypeDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VehicleTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleTypeDataGridView.Location = new System.Drawing.Point(274, 80);
            this.VehicleTypeDataGridView.Name = "VehicleTypeDataGridView";
            this.VehicleTypeDataGridView.RowHeadersWidth = 62;
            this.VehicleTypeDataGridView.Size = new System.Drawing.Size(551, 334);
            this.VehicleTypeDataGridView.TabIndex = 22;
            this.VehicleTypeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehicleTypeDataGridView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vehicleTypeSearchBtm);
            this.groupBox2.Controls.Add(this.vehicleTypeComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(-5, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 117);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find Specific Vehicle Type";
            // 
            // vehicleTypeSearchBtm
            // 
            this.vehicleTypeSearchBtm.ForeColor = System.Drawing.Color.Black;
            this.vehicleTypeSearchBtm.Location = new System.Drawing.Point(111, 75);
            this.vehicleTypeSearchBtm.Name = "vehicleTypeSearchBtm";
            this.vehicleTypeSearchBtm.Size = new System.Drawing.Size(75, 23);
            this.vehicleTypeSearchBtm.TabIndex = 2;
            this.vehicleTypeSearchBtm.Text = "Search";
            this.vehicleTypeSearchBtm.UseVisualStyleBackColor = true;
            this.vehicleTypeSearchBtm.Click += new System.EventHandler(this.vehicleTypeSearchBtm_Click);
            // 
            // vehicleTypeComboBox
            // 
            this.vehicleTypeComboBox.BackColor = System.Drawing.Color.Black;
            this.vehicleTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.vehicleTypeComboBox.FormattingEnabled = true;
            this.vehicleTypeComboBox.Location = new System.Drawing.Point(81, 38);
            this.vehicleTypeComboBox.Name = "vehicleTypeComboBox";
            this.vehicleTypeComboBox.Size = new System.Drawing.Size(161, 21);
            this.vehicleTypeComboBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vehicle Type";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.updateVtype);
            this.groupBox1.Controls.Add(this.cBranchFeeTextBox);
            this.groupBox1.Controls.Add(this.lateFeeTextBox);
            this.groupBox1.Controls.Add(this.MonthlyFee);
            this.groupBox1.Controls.Add(this.WeeklyFeeTextBox);
            this.groupBox1.Controls.Add(this.DailyFee);
            this.groupBox1.Controls.Add(this.vehicleTypeTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-5, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 282);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete";
            // 
            // updateVtype
            // 
            this.updateVtype.ForeColor = System.Drawing.Color.Black;
            this.updateVtype.Location = new System.Drawing.Point(93, 247);
            this.updateVtype.Name = "updateVtype";
            this.updateVtype.Size = new System.Drawing.Size(75, 23);
            this.updateVtype.TabIndex = 12;
            this.updateVtype.Text = "Delete";
            this.updateVtype.UseVisualStyleBackColor = true;
            this.updateVtype.Click += new System.EventHandler(this.updateVtype_Click_1);
            // 
            // cBranchFeeTextBox
            // 
            this.cBranchFeeTextBox.BackColor = System.Drawing.Color.Black;
            this.cBranchFeeTextBox.ForeColor = System.Drawing.Color.White;
            this.cBranchFeeTextBox.Location = new System.Drawing.Point(130, 210);
            this.cBranchFeeTextBox.Multiline = true;
            this.cBranchFeeTextBox.Name = "cBranchFeeTextBox";
            this.cBranchFeeTextBox.Size = new System.Drawing.Size(112, 20);
            this.cBranchFeeTextBox.TabIndex = 11;
            // 
            // lateFeeTextBox
            // 
            this.lateFeeTextBox.BackColor = System.Drawing.Color.Black;
            this.lateFeeTextBox.ForeColor = System.Drawing.Color.White;
            this.lateFeeTextBox.Location = new System.Drawing.Point(130, 180);
            this.lateFeeTextBox.Multiline = true;
            this.lateFeeTextBox.Name = "lateFeeTextBox";
            this.lateFeeTextBox.Size = new System.Drawing.Size(112, 20);
            this.lateFeeTextBox.TabIndex = 10;
            // 
            // MonthlyFee
            // 
            this.MonthlyFee.BackColor = System.Drawing.Color.Black;
            this.MonthlyFee.ForeColor = System.Drawing.Color.White;
            this.MonthlyFee.Location = new System.Drawing.Point(130, 149);
            this.MonthlyFee.Multiline = true;
            this.MonthlyFee.Name = "MonthlyFee";
            this.MonthlyFee.Size = new System.Drawing.Size(112, 20);
            this.MonthlyFee.TabIndex = 9;
            // 
            // WeeklyFeeTextBox
            // 
            this.WeeklyFeeTextBox.BackColor = System.Drawing.Color.Black;
            this.WeeklyFeeTextBox.ForeColor = System.Drawing.Color.White;
            this.WeeklyFeeTextBox.Location = new System.Drawing.Point(130, 112);
            this.WeeklyFeeTextBox.Multiline = true;
            this.WeeklyFeeTextBox.Name = "WeeklyFeeTextBox";
            this.WeeklyFeeTextBox.Size = new System.Drawing.Size(112, 20);
            this.WeeklyFeeTextBox.TabIndex = 8;
            // 
            // DailyFee
            // 
            this.DailyFee.BackColor = System.Drawing.Color.Black;
            this.DailyFee.ForeColor = System.Drawing.Color.White;
            this.DailyFee.Location = new System.Drawing.Point(130, 75);
            this.DailyFee.Multiline = true;
            this.DailyFee.Name = "DailyFee";
            this.DailyFee.Size = new System.Drawing.Size(112, 20);
            this.DailyFee.TabIndex = 7;
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.BackColor = System.Drawing.Color.Black;
            this.vehicleTypeTextBox.ForeColor = System.Drawing.Color.White;
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(130, 37);
            this.vehicleTypeTextBox.Multiline = true;
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(112, 20);
            this.vehicleTypeTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Change Branch Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Late Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weekly Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monthly Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daily Fee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VehicleType";
            // 
            // DeleteVehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(836, 475);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.queryResultlabel);
            this.Controls.Add(this.VehicleTypeDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteVehicleType";
            this.Text = "DeleteVehicleType";
            this.Load += new System.EventHandler(this.DeleteVehicleType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehicleTypeDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label queryResultlabel;
        private System.Windows.Forms.DataGridView VehicleTypeDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button vehicleTypeSearchBtm;
        private System.Windows.Forms.ComboBox vehicleTypeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateVtype;
        private System.Windows.Forms.TextBox cBranchFeeTextBox;
        private System.Windows.Forms.TextBox lateFeeTextBox;
        private System.Windows.Forms.TextBox MonthlyFee;
        private System.Windows.Forms.TextBox WeeklyFeeTextBox;
        private System.Windows.Forms.TextBox DailyFee;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}