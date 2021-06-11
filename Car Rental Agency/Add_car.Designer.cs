
namespace Car_Rental_Agency
{
    partial class AddNewVehicle
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
            this.Type = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.availabilityComboBox = new System.Windows.Forms.ComboBox();
            this.vehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.branchNameCombobox = new System.Windows.Forms.ComboBox();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.queryResultLabel = new System.Windows.Forms.Label();
            this.queryResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(46, 58);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(105, 19);
            this.Type.TabIndex = 0;
            this.Type.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Branch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Miles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Availability";
            // 
            // availabilityComboBox
            // 
            this.availabilityComboBox.BackColor = System.Drawing.Color.Black;
            this.availabilityComboBox.ForeColor = System.Drawing.Color.White;
            this.availabilityComboBox.FormattingEnabled = true;
            this.availabilityComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.availabilityComboBox.Location = new System.Drawing.Point(233, 444);
            this.availabilityComboBox.Name = "availabilityComboBox";
            this.availabilityComboBox.Size = new System.Drawing.Size(259, 27);
            this.availabilityComboBox.TabIndex = 9;
            this.availabilityComboBox.SelectedIndexChanged += new System.EventHandler(this.availabilityComboBox_SelectedIndexChanged);
            // 
            // vehicleTypeComboBox
            // 
            this.vehicleTypeComboBox.BackColor = System.Drawing.Color.Black;
            this.vehicleTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.vehicleTypeComboBox.FormattingEnabled = true;
            this.vehicleTypeComboBox.Location = new System.Drawing.Point(233, 58);
            this.vehicleTypeComboBox.Name = "vehicleTypeComboBox";
            this.vehicleTypeComboBox.Size = new System.Drawing.Size(259, 27);
            this.vehicleTypeComboBox.TabIndex = 10;
            this.vehicleTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.vehicleTypeComboBox_SelectedIndexChanged);
            // 
            // branchNameCombobox
            // 
            this.branchNameCombobox.BackColor = System.Drawing.Color.Black;
            this.branchNameCombobox.ForeColor = System.Drawing.Color.White;
            this.branchNameCombobox.FormattingEnabled = true;
            this.branchNameCombobox.Location = new System.Drawing.Point(233, 108);
            this.branchNameCombobox.Name = "branchNameCombobox";
            this.branchNameCombobox.Size = new System.Drawing.Size(259, 27);
            this.branchNameCombobox.TabIndex = 11;
            this.branchNameCombobox.SelectedIndexChanged += new System.EventHandler(this.branchNameCombobox_SelectedIndexChanged);
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.BackColor = System.Drawing.Color.Black;
            this.seatsTextBox.ForeColor = System.Drawing.Color.White;
            this.seatsTextBox.Location = new System.Drawing.Point(233, 268);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(259, 26);
            this.seatsTextBox.TabIndex = 13;
            this.seatsTextBox.TextChanged += new System.EventHandler(this.seatsTextBox_TextChanged);
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.Color.Black;
            this.modelTextBox.ForeColor = System.Drawing.Color.White;
            this.modelTextBox.Location = new System.Drawing.Point(233, 213);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(259, 26);
            this.modelTextBox.TabIndex = 14;
            this.modelTextBox.TextChanged += new System.EventHandler(this.modelTextBox_TextChanged);
            // 
            // milesTextBox
            // 
            this.milesTextBox.BackColor = System.Drawing.Color.Black;
            this.milesTextBox.ForeColor = System.Drawing.Color.White;
            this.milesTextBox.Location = new System.Drawing.Point(233, 331);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(259, 26);
            this.milesTextBox.TabIndex = 15;
            this.milesTextBox.TextChanged += new System.EventHandler(this.milesTextBox_TextChanged);
            // 
            // makeTextBox
            // 
            this.makeTextBox.BackColor = System.Drawing.Color.Black;
            this.makeTextBox.ForeColor = System.Drawing.Color.White;
            this.makeTextBox.Location = new System.Drawing.Point(233, 158);
            this.makeTextBox.Multiline = true;
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(259, 27);
            this.makeTextBox.TabIndex = 12;
            this.makeTextBox.TextChanged += new System.EventHandler(this.makeTextBox_TextChanged);
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.Black;
            this.yearTextBox.ForeColor = System.Drawing.Color.White;
            this.yearTextBox.Location = new System.Drawing.Point(233, 391);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(259, 26);
            this.yearTextBox.TabIndex = 16;
            this.yearTextBox.TextChanged += new System.EventHandler(this.yearTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addVehicleBtn);
            this.groupBox1.Controls.Add(this.yearTextBox);
            this.groupBox1.Controls.Add(this.makeTextBox);
            this.groupBox1.Controls.Add(this.milesTextBox);
            this.groupBox1.Controls.Add(this.modelTextBox);
            this.groupBox1.Controls.Add(this.seatsTextBox);
            this.groupBox1.Controls.Add(this.branchNameCombobox);
            this.groupBox1.Controls.Add(this.vehicleTypeComboBox);
            this.groupBox1.Controls.Add(this.availabilityComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(131, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 527);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Vehicle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addVehicleBtn.ForeColor = System.Drawing.Color.White;
            this.addVehicleBtn.Location = new System.Drawing.Point(289, 477);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(154, 38);
            this.addVehicleBtn.TabIndex = 1;
            this.addVehicleBtn.Text = "Add Vehicle";
            this.addVehicleBtn.UseVisualStyleBackColor = false;
            // 
            // queryResultLabel
            // 
            this.queryResultLabel.AutoSize = true;
            this.queryResultLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryResultLabel.Location = new System.Drawing.Point(352, 604);
            this.queryResultLabel.Name = "queryResultLabel";
            this.queryResultLabel.Size = new System.Drawing.Size(0, 29);
            this.queryResultLabel.TabIndex = 1;
            // 
            // queryResult
            // 
            this.queryResult.AutoSize = true;
            this.queryResult.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryResult.Location = new System.Drawing.Point(358, 604);
            this.queryResult.Name = "queryResult";
            this.queryResult.Size = new System.Drawing.Size(0, 29);
            this.queryResult.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(294, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Add A New Vehicle";
            // 
            // AddNewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(833, 642);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.queryResult);
            this.Controls.Add(this.queryResultLabel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddNewVehicle";
            this.Text = "Add New Vehicle";
            this.Load += new System.EventHandler(this.add_car_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox availabilityComboBox;
        private System.Windows.Forms.ComboBox vehicleTypeComboBox;
        private System.Windows.Forms.ComboBox branchNameCombobox;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addVehicleBtn;
        private System.Windows.Forms.Label queryResultLabel;
        private System.Windows.Forms.Label queryResult;
        private System.Windows.Forms.Label label8;
    }
}