
namespace Car_Rental_Agency
{
    partial class AddingtoDB
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
            this.addNewVehicleButton = new System.Windows.Forms.Button();
            this.addNewVehicleTypeButton = new System.Windows.Forms.Button();
            this.addNewBranchButton = new System.Windows.Forms.Button();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateBranchbtn = new System.Windows.Forms.Button();
            this.updateVehicleTypebtn = new System.Windows.Forms.Button();
            this.updateVehiclebtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.findBranchBtn = new System.Windows.Forms.Button();
            this.findVehicleTypeBtn = new System.Windows.Forms.Button();
            this.findVehicleBtn = new System.Windows.Forms.Button();
            this.addNewBookingBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewVehicleButton
            // 
            this.addNewVehicleButton.Location = new System.Drawing.Point(17, 122);
            this.addNewVehicleButton.Name = "addNewVehicleButton";
            this.addNewVehicleButton.Size = new System.Drawing.Size(263, 44);
            this.addNewVehicleButton.TabIndex = 0;
            this.addNewVehicleButton.Text = "Add New Vehicle";
            this.addNewVehicleButton.UseVisualStyleBackColor = true;
            this.addNewVehicleButton.Click += new System.EventHandler(this.addNewVehicleButton_Click_1);
            // 
            // addNewVehicleTypeButton
            // 
            this.addNewVehicleTypeButton.Location = new System.Drawing.Point(17, 60);
            this.addNewVehicleTypeButton.Name = "addNewVehicleTypeButton";
            this.addNewVehicleTypeButton.Size = new System.Drawing.Size(263, 44);
            this.addNewVehicleTypeButton.TabIndex = 1;
            this.addNewVehicleTypeButton.Text = "Add New Vehicle Type";
            this.addNewVehicleTypeButton.UseVisualStyleBackColor = true;
            // 
            // addNewBranchButton
            // 
            this.addNewBranchButton.Location = new System.Drawing.Point(17, 199);
            this.addNewBranchButton.Name = "addNewBranchButton";
            this.addNewBranchButton.Size = new System.Drawing.Size(263, 44);
            this.addNewBranchButton.TabIndex = 5;
            this.addNewBranchButton.Text = "Add New Branch";
            this.addNewBranchButton.UseVisualStyleBackColor = true;
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.addNewBookingBtn);
            this.addGroupBox.Controls.Add(this.addNewBranchButton);
            this.addGroupBox.Controls.Add(this.addNewVehicleTypeButton);
            this.addGroupBox.Controls.Add(this.addNewVehicleButton);
            this.addGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.addGroupBox.Location = new System.Drawing.Point(22, 94);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(302, 333);
            this.addGroupBox.TabIndex = 7;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add";
            this.addGroupBox.Enter += new System.EventHandler(this.addGroupBox_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateBranchbtn);
            this.groupBox1.Controls.Add(this.updateVehicleTypebtn);
            this.groupBox1.Controls.Add(this.updateVehiclebtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(465, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 333);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update";
            // 
            // updateBranchbtn
            // 
            this.updateBranchbtn.Location = new System.Drawing.Point(17, 233);
            this.updateBranchbtn.Name = "updateBranchbtn";
            this.updateBranchbtn.Size = new System.Drawing.Size(263, 44);
            this.updateBranchbtn.TabIndex = 5;
            this.updateBranchbtn.Text = "Update Branch";
            this.updateBranchbtn.UseVisualStyleBackColor = true;
            // 
            // updateVehicleTypebtn
            // 
            this.updateVehicleTypebtn.Location = new System.Drawing.Point(17, 82);
            this.updateVehicleTypebtn.Name = "updateVehicleTypebtn";
            this.updateVehicleTypebtn.Size = new System.Drawing.Size(263, 44);
            this.updateVehicleTypebtn.TabIndex = 1;
            this.updateVehicleTypebtn.Text = "Update Vehicle Type";
            this.updateVehicleTypebtn.UseVisualStyleBackColor = true;
            // 
            // updateVehiclebtn
            // 
            this.updateVehiclebtn.Location = new System.Drawing.Point(17, 153);
            this.updateVehiclebtn.Name = "updateVehiclebtn";
            this.updateVehiclebtn.Size = new System.Drawing.Size(263, 44);
            this.updateVehiclebtn.TabIndex = 0;
            this.updateVehiclebtn.Text = "Update Vehicle";
            this.updateVehiclebtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.findBranchBtn);
            this.groupBox3.Controls.Add(this.findVehicleTypeBtn);
            this.groupBox3.Controls.Add(this.findVehicleBtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(949, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 333);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // findBranchBtn
            // 
            this.findBranchBtn.Location = new System.Drawing.Point(17, 186);
            this.findBranchBtn.Name = "findBranchBtn";
            this.findBranchBtn.Size = new System.Drawing.Size(263, 44);
            this.findBranchBtn.TabIndex = 5;
            this.findBranchBtn.Text = "Find Branch";
            this.findBranchBtn.UseVisualStyleBackColor = true;
            // 
            // findVehicleTypeBtn
            // 
            this.findVehicleTypeBtn.Location = new System.Drawing.Point(17, 42);
            this.findVehicleTypeBtn.Name = "findVehicleTypeBtn";
            this.findVehicleTypeBtn.Size = new System.Drawing.Size(263, 44);
            this.findVehicleTypeBtn.TabIndex = 1;
            this.findVehicleTypeBtn.Text = "Find Vehicle Type";
            this.findVehicleTypeBtn.UseVisualStyleBackColor = true;
            this.findVehicleTypeBtn.Click += new System.EventHandler(this.findVehicleTypeBtn_Click_1);
            // 
            // findVehicleBtn
            // 
            this.findVehicleBtn.Location = new System.Drawing.Point(17, 110);
            this.findVehicleBtn.Name = "findVehicleBtn";
            this.findVehicleBtn.Size = new System.Drawing.Size(263, 44);
            this.findVehicleBtn.TabIndex = 0;
            this.findVehicleBtn.Text = "Find Vehicle";
            this.findVehicleBtn.UseVisualStyleBackColor = true;
            // 
            // addNewBookingBtn
            // 
            this.addNewBookingBtn.Location = new System.Drawing.Point(17, 263);
            this.addNewBookingBtn.Name = "addNewBookingBtn";
            this.addNewBookingBtn.Size = new System.Drawing.Size(263, 44);
            this.addNewBookingBtn.TabIndex = 11;
            this.addNewBookingBtn.Text = "Add New Booking";
            this.addNewBookingBtn.UseVisualStyleBackColor = true;
            this.addNewBookingBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Find Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddingtoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1282, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddingtoDB";
            this.Text = "AddingtoDB";
            this.addGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewVehicleButton;
        private System.Windows.Forms.Button addNewVehicleTypeButton;
        private System.Windows.Forms.Button addNewBranchButton;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateBranchbtn;
        private System.Windows.Forms.Button updateVehicleTypebtn;
        private System.Windows.Forms.Button updateVehiclebtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button findBranchBtn;
        private System.Windows.Forms.Button findVehicleTypeBtn;
        private System.Windows.Forms.Button findVehicleBtn;
        private System.Windows.Forms.Button addNewBookingBtn;
        private System.Windows.Forms.Button button1;
    }
}