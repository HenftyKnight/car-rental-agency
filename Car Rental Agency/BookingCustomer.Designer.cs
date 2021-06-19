
namespace Car_Rental_Agency
{
    partial class BookingCustomer
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
            this.VehicleInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchagainBtn = new System.Windows.Forms.Button();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.seatsComboBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkavailability = new System.Windows.Forms.Button();
            this.dropoffBranchComboBox = new System.Windows.Forms.ComboBox();
            this.pickupBranchComboBox = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pickDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dropoffDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.vehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.backUpDataGridView = new System.Windows.Forms.DataGridView();
            this.RentCarBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleInfoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backUpDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleInfoDataGridView
            // 
            this.VehicleInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VehicleInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleInfoDataGridView.Location = new System.Drawing.Point(475, 86);
            this.VehicleInfoDataGridView.Name = "VehicleInfoDataGridView";
            this.VehicleInfoDataGridView.Size = new System.Drawing.Size(615, 161);
            this.VehicleInfoDataGridView.TabIndex = 18;
            this.VehicleInfoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehicleInfoDataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchagainBtn);
            this.groupBox1.Controls.Add(this.seatsTextBox);
            this.groupBox1.Controls.Add(this.seatsComboBox);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.checkavailability);
            this.groupBox1.Controls.Add(this.dropoffBranchComboBox);
            this.groupBox1.Controls.Add(this.pickupBranchComboBox);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.pickDateTimePicker);
            this.groupBox1.Controls.Add(this.dropoffDateTimePicker);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.vehicleTypeComboBox);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 353);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking";
            // 
            // SearchagainBtn
            // 
            this.SearchagainBtn.BackColor = System.Drawing.SystemColors.Info;
            this.SearchagainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchagainBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SearchagainBtn.Location = new System.Drawing.Point(230, 305);
            this.SearchagainBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchagainBtn.Name = "SearchagainBtn";
            this.SearchagainBtn.Size = new System.Drawing.Size(175, 31);
            this.SearchagainBtn.TabIndex = 16;
            this.SearchagainBtn.Text = "Search Again";
            this.SearchagainBtn.UseVisualStyleBackColor = false;
            this.SearchagainBtn.Click += new System.EventHandler(this.SearchagainBtn_Click);
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.Location = new System.Drawing.Point(230, 210);
            this.seatsTextBox.Multiline = true;
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(168, 27);
            this.seatsTextBox.TabIndex = 15;
            // 
            // seatsComboBox
            // 
            this.seatsComboBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.seatsComboBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seatsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.seatsComboBox.Location = new System.Drawing.Point(230, 178);
            this.seatsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.seatsComboBox.Name = "seatsComboBox";
            this.seatsComboBox.Size = new System.Drawing.Size(105, 19);
            this.seatsComboBox.TabIndex = 14;
            this.seatsComboBox.Text = "Seats";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(22, 35);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 19);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Date From";
            // 
            // checkavailability
            // 
            this.checkavailability.BackColor = System.Drawing.SystemColors.Info;
            this.checkavailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkavailability.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkavailability.Location = new System.Drawing.Point(22, 305);
            this.checkavailability.Margin = new System.Windows.Forms.Padding(2);
            this.checkavailability.Name = "checkavailability";
            this.checkavailability.Size = new System.Drawing.Size(175, 31);
            this.checkavailability.TabIndex = 11;
            this.checkavailability.Text = "Check Availability";
            this.checkavailability.UseVisualStyleBackColor = false;
            this.checkavailability.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dropoffBranchComboBox
            // 
            this.dropoffBranchComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropoffBranchComboBox.FormattingEnabled = true;
            this.dropoffBranchComboBox.Location = new System.Drawing.Point(230, 128);
            this.dropoffBranchComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.dropoffBranchComboBox.Name = "dropoffBranchComboBox";
            this.dropoffBranchComboBox.Size = new System.Drawing.Size(174, 27);
            this.dropoffBranchComboBox.TabIndex = 13;
            this.dropoffBranchComboBox.Text = "All";
            this.dropoffBranchComboBox.SelectedIndexChanged += new System.EventHandler(this.dropoffBranchComboBox_SelectedIndexChanged);
            // 
            // pickupBranchComboBox
            // 
            this.pickupBranchComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupBranchComboBox.FormattingEnabled = true;
            this.pickupBranchComboBox.Location = new System.Drawing.Point(230, 64);
            this.pickupBranchComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.pickupBranchComboBox.Name = "pickupBranchComboBox";
            this.pickupBranchComboBox.Size = new System.Drawing.Size(174, 27);
            this.pickupBranchComboBox.TabIndex = 3;
            this.pickupBranchComboBox.Text = "All";
            this.pickupBranchComboBox.SelectedIndexChanged += new System.EventHandler(this.pickupBranchComboBox_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox7.Location = new System.Drawing.Point(230, 102);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(117, 19);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "Drop Off Branch";
            // 
            // pickDateTimePicker
            // 
            this.pickDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDateTimePicker.Location = new System.Drawing.Point(22, 64);
            this.pickDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.pickDateTimePicker.Name = "pickDateTimePicker";
            this.pickDateTimePicker.Size = new System.Drawing.Size(184, 26);
            this.pickDateTimePicker.TabIndex = 4;
            // 
            // dropoffDateTimePicker
            // 
            this.dropoffDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropoffDateTimePicker.Location = new System.Drawing.Point(22, 125);
            this.dropoffDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dropoffDateTimePicker.Name = "dropoffDateTimePicker";
            this.dropoffDateTimePicker.Size = new System.Drawing.Size(179, 26);
            this.dropoffDateTimePicker.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox6.Location = new System.Drawing.Point(230, 35);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(117, 19);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "Pick Up Branch";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.Location = new System.Drawing.Point(22, 102);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(61, 19);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Date To";
            // 
            // vehicleTypeComboBox
            // 
            this.vehicleTypeComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTypeComboBox.FormattingEnabled = true;
            this.vehicleTypeComboBox.Location = new System.Drawing.Point(22, 210);
            this.vehicleTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.vehicleTypeComboBox.Name = "vehicleTypeComboBox";
            this.vehicleTypeComboBox.Size = new System.Drawing.Size(175, 27);
            this.vehicleTypeComboBox.TabIndex = 9;
            this.vehicleTypeComboBox.Text = "All";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(22, 178);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(105, 19);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Vehicle Type";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(25, 11);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 34);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Book a Car";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Black;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.welcomeLabel.Location = new System.Drawing.Point(194, 53);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(60, 24);
            this.welcomeLabel.TabIndex = 19;
            this.welcomeLabel.Text = "label1";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.BackColor = System.Drawing.Color.Gray;
            this.infolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolabel.ForeColor = System.Drawing.Color.White;
            this.infolabel.Location = new System.Drawing.Point(18, 77);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(133, 20);
            this.infolabel.TabIndex = 20;
            this.infolabel.Text = "Information Label";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Gray;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(18, 33);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(87, 20);
            this.errorLabel.TabIndex = 21;
            this.errorLabel.Text = "Error Label";
            // 
            // backUpDataGridView
            // 
            this.backUpDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backUpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.backUpDataGridView.Location = new System.Drawing.Point(475, 306);
            this.backUpDataGridView.Name = "backUpDataGridView";
            this.backUpDataGridView.Size = new System.Drawing.Size(615, 143);
            this.backUpDataGridView.TabIndex = 22;
            this.backUpDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.backUpDataGridView_CellContentClick);
            // 
            // RentCarBtn
            // 
            this.RentCarBtn.BackColor = System.Drawing.SystemColors.Info;
            this.RentCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentCarBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RentCarBtn.Location = new System.Drawing.Point(828, 517);
            this.RentCarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RentCarBtn.Name = "RentCarBtn";
            this.RentCarBtn.Size = new System.Drawing.Size(177, 50);
            this.RentCarBtn.TabIndex = 23;
            this.RentCarBtn.Text = "Rent Car";
            this.RentCarBtn.UseVisualStyleBackColor = false;
            this.RentCarBtn.Click += new System.EventHandler(this.RentCarBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.errorLabel);
            this.groupBox2.Controls.Add(this.infolabel);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(25, 455);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 190);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rental Summary";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(488, 274);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 19);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Upgrades For Golden Member";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox8.Location = new System.Drawing.Point(477, 44);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(262, 19);
            this.textBox8.TabIndex = 26;
            this.textBox8.Text = "Original Request";
            // 
            // BookingCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1135, 646);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RentCarBtn);
            this.Controls.Add(this.backUpDataGridView);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.VehicleInfoDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookingCustomer";
            this.Text = "BookingCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.VehicleInfoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backUpDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VehicleInfoDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox seatsComboBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button checkavailability;
        private System.Windows.Forms.ComboBox dropoffBranchComboBox;
        private System.Windows.Forms.ComboBox pickupBranchComboBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker pickDateTimePicker;
        private System.Windows.Forms.DateTimePicker dropoffDateTimePicker;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox vehicleTypeComboBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.Button SearchagainBtn;
        private System.Windows.Forms.DataGridView backUpDataGridView;
        private System.Windows.Forms.Button RentCarBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox8;
    }
}