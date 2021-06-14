
namespace Car_Rental_Agency
{
    partial class FindVehicle
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
            this.updateVehicleGroupBox = new System.Windows.Forms.GroupBox();
            this.vehicleIDSearchBtn = new System.Windows.Forms.Button();
            this.vehicleIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.milesSearchBtn = new System.Windows.Forms.Button();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.branchSearchBtn = new System.Windows.Forms.Button();
            this.BranchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.seatsSearchBtn = new System.Windows.Forms.Button();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vehicleTypeSearchBtn = new System.Windows.Forms.Button();
            this.vehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.findVehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.genQuerylabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateVehicleGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findVehicleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateVehicleGroupBox
            // 
            this.updateVehicleGroupBox.Controls.Add(this.vehicleIDSearchBtn);
            this.updateVehicleGroupBox.Controls.Add(this.vehicleIDTextBox);
            this.updateVehicleGroupBox.Controls.Add(this.label1);
            this.updateVehicleGroupBox.ForeColor = System.Drawing.Color.Gray;
            this.updateVehicleGroupBox.Location = new System.Drawing.Point(18, 146);
            this.updateVehicleGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateVehicleGroupBox.Name = "updateVehicleGroupBox";
            this.updateVehicleGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateVehicleGroupBox.Size = new System.Drawing.Size(392, 146);
            this.updateVehicleGroupBox.TabIndex = 0;
            this.updateVehicleGroupBox.TabStop = false;
            this.updateVehicleGroupBox.Text = " Search By VehicleID";
            // 
            // vehicleIDSearchBtn
            // 
            this.vehicleIDSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleIDSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.vehicleIDSearchBtn.Location = new System.Drawing.Point(184, 97);
            this.vehicleIDSearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vehicleIDSearchBtn.Name = "vehicleIDSearchBtn";
            this.vehicleIDSearchBtn.Size = new System.Drawing.Size(112, 35);
            this.vehicleIDSearchBtn.TabIndex = 6;
            this.vehicleIDSearchBtn.Text = "Search";
            this.vehicleIDSearchBtn.UseVisualStyleBackColor = true;
            // 
            // vehicleIDTextBox
            // 
            this.vehicleIDTextBox.BackColor = System.Drawing.Color.Black;
            this.vehicleIDTextBox.ForeColor = System.Drawing.Color.White;
            this.vehicleIDTextBox.Location = new System.Drawing.Point(170, 57);
            this.vehicleIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vehicleIDTextBox.Multiline = true;
            this.vehicleIDTextBox.Name = "vehicleIDTextBox";
            this.vehicleIDTextBox.Size = new System.Drawing.Size(194, 29);
            this.vehicleIDTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VehicleID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miles";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(27, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(27, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(27, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vehicle Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.milesSearchBtn);
            this.groupBox1.Controls.Add(this.milesTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(18, 317);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(392, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Search By Vehicle Miles ";
            // 
            // milesSearchBtn
            // 
            this.milesSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.milesSearchBtn.Location = new System.Drawing.Point(184, 97);
            this.milesSearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.milesSearchBtn.Name = "milesSearchBtn";
            this.milesSearchBtn.Size = new System.Drawing.Size(112, 35);
            this.milesSearchBtn.TabIndex = 6;
            this.milesSearchBtn.Text = "Search";
            this.milesSearchBtn.UseVisualStyleBackColor = true;
            // 
            // milesTextBox
            // 
            this.milesTextBox.BackColor = System.Drawing.Color.Black;
            this.milesTextBox.ForeColor = System.Drawing.Color.White;
            this.milesTextBox.Location = new System.Drawing.Point(170, 57);
            this.milesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.milesTextBox.Multiline = true;
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(194, 29);
            this.milesTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.branchSearchBtn);
            this.groupBox2.Controls.Add(this.BranchTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(18, 500);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(392, 146);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Search By Vehicle Current Branch";
            // 
            // branchSearchBtn
            // 
            this.branchSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.branchSearchBtn.Location = new System.Drawing.Point(184, 97);
            this.branchSearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.branchSearchBtn.Name = "branchSearchBtn";
            this.branchSearchBtn.Size = new System.Drawing.Size(112, 35);
            this.branchSearchBtn.TabIndex = 6;
            this.branchSearchBtn.Text = "Search";
            this.branchSearchBtn.UseVisualStyleBackColor = true;
            // 
            // BranchTextBox
            // 
            this.BranchTextBox.BackColor = System.Drawing.Color.Black;
            this.BranchTextBox.ForeColor = System.Drawing.Color.White;
            this.BranchTextBox.Location = new System.Drawing.Point(170, 57);
            this.BranchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BranchTextBox.Multiline = true;
            this.BranchTextBox.Name = "BranchTextBox";
            this.BranchTextBox.Size = new System.Drawing.Size(194, 29);
            this.BranchTextBox.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.seatsSearchBtn);
            this.groupBox3.Controls.Add(this.seatsTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.ForeColor = System.Drawing.Color.Gray;
            this.groupBox3.Location = new System.Drawing.Point(18, 675);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(392, 146);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Search Vehicle by Seats";
            // 
            // seatsSearchBtn
            // 
            this.seatsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.seatsSearchBtn.Location = new System.Drawing.Point(184, 97);
            this.seatsSearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seatsSearchBtn.Name = "seatsSearchBtn";
            this.seatsSearchBtn.Size = new System.Drawing.Size(112, 35);
            this.seatsSearchBtn.TabIndex = 6;
            this.seatsSearchBtn.Text = "Search";
            this.seatsSearchBtn.UseVisualStyleBackColor = true;
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.BackColor = System.Drawing.Color.Black;
            this.seatsTextBox.ForeColor = System.Drawing.Color.White;
            this.seatsTextBox.Location = new System.Drawing.Point(170, 57);
            this.seatsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seatsTextBox.Multiline = true;
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(194, 29);
            this.seatsTextBox.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.vehicleTypeSearchBtn);
            this.groupBox4.Controls.Add(this.vehicleTypeTextBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.ForeColor = System.Drawing.Color.Gray;
            this.groupBox4.Location = new System.Drawing.Point(18, 835);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(392, 146);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Search Vehicle by Vehicle Type";
            // 
            // vehicleTypeSearchBtn
            // 
            this.vehicleTypeSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTypeSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.vehicleTypeSearchBtn.Location = new System.Drawing.Point(184, 97);
            this.vehicleTypeSearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vehicleTypeSearchBtn.Name = "vehicleTypeSearchBtn";
            this.vehicleTypeSearchBtn.Size = new System.Drawing.Size(112, 35);
            this.vehicleTypeSearchBtn.TabIndex = 6;
            this.vehicleTypeSearchBtn.Text = "Search";
            this.vehicleTypeSearchBtn.UseVisualStyleBackColor = true;
            // 
            // vehicleTypeTextBox
            // 
            this.vehicleTypeTextBox.BackColor = System.Drawing.Color.Black;
            this.vehicleTypeTextBox.ForeColor = System.Drawing.Color.White;
            this.vehicleTypeTextBox.Location = new System.Drawing.Point(170, 57);
            this.vehicleTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vehicleTypeTextBox.Multiline = true;
            this.vehicleTypeTextBox.Name = "vehicleTypeTextBox";
            this.vehicleTypeTextBox.Size = new System.Drawing.Size(194, 29);
            this.vehicleTypeTextBox.TabIndex = 5;
            // 
            // findVehicleDataGridView
            // 
            this.findVehicleDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.findVehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.findVehicleDataGridView.Location = new System.Drawing.Point(441, 146);
            this.findVehicleDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findVehicleDataGridView.Name = "findVehicleDataGridView";
            this.findVehicleDataGridView.RowHeadersWidth = 62;
            this.findVehicleDataGridView.Size = new System.Drawing.Size(1314, 835);
            this.findVehicleDataGridView.TabIndex = 9;
            // 
            // genQuerylabel
            // 
            this.genQuerylabel.AutoSize = true;
            this.genQuerylabel.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genQuerylabel.Location = new System.Drawing.Point(939, 1015);
            this.genQuerylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genQuerylabel.Name = "genQuerylabel";
            this.genQuerylabel.Size = new System.Drawing.Size(126, 45);
            this.genQuerylabel.TabIndex = 10;
            this.genQuerylabel.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(40, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(704, 47);
            this.label6.TabIndex = 11;
            this.label6.Text = "Find Vehicle By Different Attributes";
            // 
            // FindVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1814, 1050);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genQuerylabel);
            this.Controls.Add(this.findVehicleDataGridView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updateVehicleGroupBox);
            this.Name = "FindVehicle";
            this.Text = "Find Vehicle";
            this.Load += new System.EventHandler(this.FindVehicle_Load);
            this.updateVehicleGroupBox.ResumeLayout(false);
            this.updateVehicleGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findVehicleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox updateVehicleGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vehicleIDSearchBtn;
        private System.Windows.Forms.TextBox vehicleIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button milesSearchBtn;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button branchSearchBtn;
        private System.Windows.Forms.TextBox BranchTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button seatsSearchBtn;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button vehicleTypeSearchBtn;
        private System.Windows.Forms.TextBox vehicleTypeTextBox;
        private System.Windows.Forms.DataGridView findVehicleDataGridView;
        private System.Windows.Forms.Label genQuerylabel;
        private System.Windows.Forms.Label label6;
    }
}