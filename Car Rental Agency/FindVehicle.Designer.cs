
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.vehicleTypeSearchBtn = new System.Windows.Forms.Button();
            this.findVehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.genQuerylabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.brNameComboBox = new System.Windows.Forms.ComboBox();
            this.vehicleMilesComboBox = new System.Windows.Forms.ComboBox();
            this.seatsComboBox = new System.Windows.Forms.ComboBox();
            this.VtypeComboBox = new System.Windows.Forms.ComboBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.updateVehicleGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findVehicleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateVehicleGroupBox
            // 
            this.updateVehicleGroupBox.Controls.Add(this.VtypeComboBox);
            this.updateVehicleGroupBox.Controls.Add(this.seatsComboBox);
            this.updateVehicleGroupBox.Controls.Add(this.vehicleMilesComboBox);
            this.updateVehicleGroupBox.Controls.Add(this.brNameComboBox);
            this.updateVehicleGroupBox.Controls.Add(this.vehicleIDSearchBtn);
            this.updateVehicleGroupBox.Controls.Add(this.label5);
            this.updateVehicleGroupBox.Controls.Add(this.label4);
            this.updateVehicleGroupBox.Controls.Add(this.label2);
            this.updateVehicleGroupBox.Controls.Add(this.label3);
            this.updateVehicleGroupBox.ForeColor = System.Drawing.Color.Gray;
            this.updateVehicleGroupBox.Location = new System.Drawing.Point(12, 95);
            this.updateVehicleGroupBox.Name = "updateVehicleGroupBox";
            this.updateVehicleGroupBox.Size = new System.Drawing.Size(261, 253);
            this.updateVehicleGroupBox.TabIndex = 0;
            this.updateVehicleGroupBox.TabStop = false;
            this.updateVehicleGroupBox.Text = " Search By VehicleID";
            // 
            // vehicleIDSearchBtn
            // 
            this.vehicleIDSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleIDSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.vehicleIDSearchBtn.Location = new System.Drawing.Point(92, 212);
            this.vehicleIDSearchBtn.Name = "vehicleIDSearchBtn";
            this.vehicleIDSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.vehicleIDSearchBtn.TabIndex = 6;
            this.vehicleIDSearchBtn.Text = "Search";
            this.vehicleIDSearchBtn.UseVisualStyleBackColor = true;
            this.vehicleIDSearchBtn.Click += new System.EventHandler(this.vehicleIDSearchBtn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(18, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vehicle Type";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.vehicleTypeSearchBtn);
            this.groupBox4.ForeColor = System.Drawing.Color.Gray;
            this.groupBox4.Location = new System.Drawing.Point(12, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 95);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Search Vehicle by Vehicle Type";
            // 
            // vehicleTypeSearchBtn
            // 
            this.vehicleTypeSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTypeSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.vehicleTypeSearchBtn.Location = new System.Drawing.Point(123, 63);
            this.vehicleTypeSearchBtn.Name = "vehicleTypeSearchBtn";
            this.vehicleTypeSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.vehicleTypeSearchBtn.TabIndex = 6;
            this.vehicleTypeSearchBtn.Text = "Search";
            this.vehicleTypeSearchBtn.UseVisualStyleBackColor = true;
            this.vehicleTypeSearchBtn.Click += new System.EventHandler(this.vehicleTypeSearchBtn_Click_1);
            // 
            // findVehicleDataGridView
            // 
            this.findVehicleDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.findVehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.findVehicleDataGridView.Location = new System.Drawing.Point(294, 95);
            this.findVehicleDataGridView.Name = "findVehicleDataGridView";
            this.findVehicleDataGridView.Size = new System.Drawing.Size(876, 543);
            this.findVehicleDataGridView.TabIndex = 9;
            this.findVehicleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.findVehicleDataGridView_CellContentClick);
            // 
            // genQuerylabel
            // 
            this.genQuerylabel.AutoSize = true;
            this.genQuerylabel.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genQuerylabel.Location = new System.Drawing.Point(626, 660);
            this.genQuerylabel.Name = "genQuerylabel";
            this.genQuerylabel.Size = new System.Drawing.Size(83, 30);
            this.genQuerylabel.TabIndex = 10;
            this.genQuerylabel.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(27, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(477, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Find Vehicle By Different Attributes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miles";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(23, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vehicle Type";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(113, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 8;
            // 
            // brNameComboBox
            // 
            this.brNameComboBox.BackColor = System.Drawing.Color.Black;
            this.brNameComboBox.ForeColor = System.Drawing.Color.White;
            this.brNameComboBox.FormattingEnabled = true;
            this.brNameComboBox.Location = new System.Drawing.Point(92, 37);
            this.brNameComboBox.Name = "brNameComboBox";
            this.brNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.brNameComboBox.TabIndex = 7;
            // 
            // vehicleMilesComboBox
            // 
            this.vehicleMilesComboBox.BackColor = System.Drawing.Color.Black;
            this.vehicleMilesComboBox.ForeColor = System.Drawing.Color.White;
            this.vehicleMilesComboBox.FormattingEnabled = true;
            this.vehicleMilesComboBox.Location = new System.Drawing.Point(92, 79);
            this.vehicleMilesComboBox.Name = "vehicleMilesComboBox";
            this.vehicleMilesComboBox.Size = new System.Drawing.Size(121, 21);
            this.vehicleMilesComboBox.TabIndex = 8;
            // 
            // seatsComboBox
            // 
            this.seatsComboBox.BackColor = System.Drawing.Color.Black;
            this.seatsComboBox.ForeColor = System.Drawing.Color.White;
            this.seatsComboBox.FormattingEnabled = true;
            this.seatsComboBox.Location = new System.Drawing.Point(92, 121);
            this.seatsComboBox.Name = "seatsComboBox";
            this.seatsComboBox.Size = new System.Drawing.Size(121, 21);
            this.seatsComboBox.TabIndex = 9;
            // 
            // VtypeComboBox
            // 
            this.VtypeComboBox.BackColor = System.Drawing.Color.Black;
            this.VtypeComboBox.ForeColor = System.Drawing.Color.White;
            this.VtypeComboBox.FormattingEnabled = true;
            this.VtypeComboBox.Location = new System.Drawing.Point(93, 152);
            this.VtypeComboBox.Name = "VtypeComboBox";
            this.VtypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.VtypeComboBox.TabIndex = 10;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.ErrorLabel.Location = new System.Drawing.Point(35, 545);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 12;
            // 
            // FindVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1209, 731);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genQuerylabel);
            this.Controls.Add(this.findVehicleDataGridView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.updateVehicleGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindVehicle";
            this.Text = "Find Vehicle";
            this.updateVehicleGroupBox.ResumeLayout(false);
            this.updateVehicleGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findVehicleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox updateVehicleGroupBox;
        private System.Windows.Forms.Button vehicleIDSearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button vehicleTypeSearchBtn;
        private System.Windows.Forms.DataGridView findVehicleDataGridView;
        private System.Windows.Forms.Label genQuerylabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox VtypeComboBox;
        private System.Windows.Forms.ComboBox seatsComboBox;
        private System.Windows.Forms.ComboBox vehicleMilesComboBox;
        private System.Windows.Forms.ComboBox brNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ErrorLabel;
    }
}