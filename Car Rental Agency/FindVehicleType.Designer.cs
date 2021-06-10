
namespace Car_Rental_Agency
{
    partial class FindVehicleType
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
            this.vehicleTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vehicletypesearchbtn = new System.Windows.Forms.Button();
            this.vehicleTypeNameTextbox = new System.Windows.Forms.TextBox();
            this.vehicleTypeNameLabel = new System.Windows.Forms.Label();
            this.queryResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleTypeDataGridView
            // 
            this.vehicleTypeDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.vehicleTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleTypeDataGridView.Location = new System.Drawing.Point(324, 51);
            this.vehicleTypeDataGridView.Name = "vehicleTypeDataGridView";
            this.vehicleTypeDataGridView.Size = new System.Drawing.Size(706, 386);
            this.vehicleTypeDataGridView.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vehicletypesearchbtn);
            this.groupBox1.Controls.Add(this.vehicleTypeNameTextbox);
            this.groupBox1.Controls.Add(this.vehicleTypeNameLabel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Vehicle Type By Name";
            // 
            // vehicletypesearchbtn
            // 
            this.vehicletypesearchbtn.ForeColor = System.Drawing.Color.Black;
            this.vehicletypesearchbtn.Location = new System.Drawing.Point(85, 55);
            this.vehicletypesearchbtn.Name = "vehicletypesearchbtn";
            this.vehicletypesearchbtn.Size = new System.Drawing.Size(75, 23);
            this.vehicletypesearchbtn.TabIndex = 2;
            this.vehicletypesearchbtn.Text = "Search";
            this.vehicletypesearchbtn.UseVisualStyleBackColor = true;
            this.vehicletypesearchbtn.Click += new System.EventHandler(this.vehicletypesearchbtn_Click);
            // 
            // vehicleTypeNameTextbox
            // 
            this.vehicleTypeNameTextbox.Location = new System.Drawing.Point(112, 26);
            this.vehicleTypeNameTextbox.Multiline = true;
            this.vehicleTypeNameTextbox.Name = "vehicleTypeNameTextbox";
            this.vehicleTypeNameTextbox.Size = new System.Drawing.Size(131, 20);
            this.vehicleTypeNameTextbox.TabIndex = 1;
            // 
            // vehicleTypeNameLabel
            // 
            this.vehicleTypeNameLabel.AutoSize = true;
            this.vehicleTypeNameLabel.ForeColor = System.Drawing.Color.White;
            this.vehicleTypeNameLabel.Location = new System.Drawing.Point(6, 29);
            this.vehicleTypeNameLabel.Name = "vehicleTypeNameLabel";
            this.vehicleTypeNameLabel.Size = new System.Drawing.Size(100, 13);
            this.vehicleTypeNameLabel.TabIndex = 1;
            this.vehicleTypeNameLabel.Text = "Vehicle Type Name";
            // 
            // queryResultLabel
            // 
            this.queryResultLabel.AutoSize = true;
            this.queryResultLabel.Location = new System.Drawing.Point(94, 319);
            this.queryResultLabel.Name = "queryResultLabel";
            this.queryResultLabel.Size = new System.Drawing.Size(35, 13);
            this.queryResultLabel.TabIndex = 9;
            this.queryResultLabel.Text = "label1";
            // 
            // FindVehicleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1057, 473);
            this.Controls.Add(this.queryResultLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vehicleTypeDataGridView);
            this.Name = "FindVehicleType";
            this.Text = "FindVehicleType";
            this.Load += new System.EventHandler(this.FindVehicleType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vehicleTypeDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button vehicletypesearchbtn;
        private System.Windows.Forms.TextBox vehicleTypeNameTextbox;
        private System.Windows.Forms.Label vehicleTypeNameLabel;
        private System.Windows.Forms.Label queryResultLabel;
    }
}