
namespace Car_Rental_Agency
{
    partial class delBranch
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
            this.branchNameComboBox = new System.Windows.Forms.ComboBox();
            this.branchGroupBox = new System.Windows.Forms.GroupBox();
            this.branchSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.branchInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.brName = new System.Windows.Forms.Label();
            this.brStreet = new System.Windows.Forms.Label();
            this.brCity = new System.Windows.Forms.Label();
            this.CityBr = new System.Windows.Forms.Label();
            this.brStree = new System.Windows.Forms.Label();
            this.CountryBr = new System.Windows.Forms.Label();
            this.postalcodeBr = new System.Windows.Forms.Label();
            this.brNameTbox = new System.Windows.Forms.TextBox();
            this.streetTbox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTBox = new System.Windows.Forms.TextBox();
            this.countryTBox = new System.Windows.Forms.TextBox();
            this.postalCodeTbox = new System.Windows.Forms.TextBox();
            this.phoneTbox = new System.Windows.Forms.TextBox();
            this.updateBranchBtn = new System.Windows.Forms.Button();
            this.queryResultlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.branchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchInfoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();



            // queryResultlabel
            // 
            this.queryResultlabel.AutoSize = true;
            this.queryResultlabel.Location = new System.Drawing.Point(932, 643);
            this.queryResultlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.queryResultlabel.Name = "queryResultlabel";
            this.queryResultlabel.Size = new System.Drawing.Size(42, 20);
            this.queryResultlabel.TabIndex = 3;
            this.queryResultlabel.Text = "label";
            // 
            // branchNameComboBox
            // 
            this.branchNameComboBox.BackColor = System.Drawing.Color.Black;
            this.branchNameComboBox.ForeColor = System.Drawing.Color.White;
            this.branchNameComboBox.FormattingEnabled = true;
            this.branchNameComboBox.Location = new System.Drawing.Point(100, 50);
            this.branchNameComboBox.Name = "branchNameComboBox";
            this.branchNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.branchNameComboBox.TabIndex = 0;
            // 
            // branchGroupBox
            // 
            this.branchGroupBox.Controls.Add(this.branchSearchBtn);
            this.branchGroupBox.Controls.Add(this.label1);
            this.branchGroupBox.Controls.Add(this.branchNameComboBox);
            this.branchGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.branchGroupBox.Location = new System.Drawing.Point(39, 87);
            this.branchGroupBox.Name = "branchGroupBox";
            this.branchGroupBox.Size = new System.Drawing.Size(243, 123);
            this.branchGroupBox.TabIndex = 1;
            this.branchGroupBox.TabStop = false;
            this.branchGroupBox.Text = "Find Branch";
            this.branchGroupBox.Enter += new System.EventHandler(this.branchGroupBox_Enter);
            // 
            // branchSearchBtn
            // 
            this.branchSearchBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchSearchBtn.Location = new System.Drawing.Point(120, 77);
            this.branchSearchBtn.Name = "branchSearchBtn";
            this.branchSearchBtn.Size = new System.Drawing.Size(81, 27);
            this.branchSearchBtn.TabIndex = 2;
            this.branchSearchBtn.Text = "Select";
            this.branchSearchBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch Name";
            // 
            // branchInfoDataGridView
            // 
            this.branchInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.branchInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchInfoDataGridView.Location = new System.Drawing.Point(519, 115);
            this.branchInfoDataGridView.Name = "branchInfoDataGridView";
            this.branchInfoDataGridView.Size = new System.Drawing.Size(677, 457);
            this.branchInfoDataGridView.TabIndex = 2;
            // 
            // brName
            // 
            this.brName.AutoSize = true;
            this.brName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brName.Location = new System.Drawing.Point(6, 32);
            this.brName.Name = "brName";
            this.brName.Size = new System.Drawing.Size(110, 18);
            this.brName.TabIndex = 3;
            this.brName.Text = "Branch Name";
            // 
            // brStreet
            // 
            this.brStreet.AutoSize = true;
            this.brStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brStreet.Location = new System.Drawing.Point(6, 67);
            this.brStreet.Name = "brStreet";
            this.brStreet.Size = new System.Drawing.Size(53, 18);
            this.brStreet.TabIndex = 4;
            this.brStreet.Text = "Street";
            // 
            // brCity
            // 
            this.brCity.AutoSize = true;
            this.brCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brCity.Location = new System.Drawing.Point(6, 100);
            this.brCity.Name = "brCity";
            this.brCity.Size = new System.Drawing.Size(37, 18);
            this.brCity.TabIndex = 5;
            this.brCity.Text = "City";
            // 
            // CityBr
            // 
            this.CityBr.AutoSize = true;
            this.CityBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityBr.Location = new System.Drawing.Point(6, 166);
            this.CityBr.Name = "CityBr";
            this.CityBr.Size = new System.Drawing.Size(67, 18);
            this.CityBr.TabIndex = 6;
            this.CityBr.Text = "Country";
            // 
            // brStree
            // 
            this.brStree.AutoSize = true;
            this.brStree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brStree.Location = new System.Drawing.Point(6, 133);
            this.brStree.Name = "brStree";
            this.brStree.Size = new System.Drawing.Size(47, 18);
            this.brStree.TabIndex = 7;
            this.brStree.Text = "State";
            // 
            // CountryBr
            // 
            this.CountryBr.AutoSize = true;
            this.CountryBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryBr.Location = new System.Drawing.Point(6, 199);
            this.CountryBr.Name = "CountryBr";
            this.CountryBr.Size = new System.Drawing.Size(101, 18);
            this.CountryBr.TabIndex = 8;
            this.CountryBr.Text = "Postal Code";
            // 
            // postalcodeBr
            // 
            this.postalcodeBr.AutoSize = true;
            this.postalcodeBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalcodeBr.Location = new System.Drawing.Point(6, 232);
            this.postalcodeBr.Name = "postalcodeBr";
            this.postalcodeBr.Size = new System.Drawing.Size(56, 18);
            this.postalcodeBr.TabIndex = 9;
            this.postalcodeBr.Text = "Phone";
            // 
            // brNameTbox
            // 
            this.brNameTbox.BackColor = System.Drawing.Color.Black;
            this.brNameTbox.ForeColor = System.Drawing.Color.White;
            this.brNameTbox.Location = new System.Drawing.Point(132, 32);
            this.brNameTbox.Multiline = true;
            this.brNameTbox.Name = "brNameTbox";
            this.brNameTbox.Size = new System.Drawing.Size(259, 27);
            this.brNameTbox.TabIndex = 11;
            // 
            // streetTbox
            // 
            this.streetTbox.BackColor = System.Drawing.Color.Black;
            this.streetTbox.ForeColor = System.Drawing.Color.White;
            this.streetTbox.Location = new System.Drawing.Point(132, 67);
            this.streetTbox.Multiline = true;
            this.streetTbox.Name = "streetTbox";
            this.streetTbox.Size = new System.Drawing.Size(259, 27);
            this.streetTbox.TabIndex = 12;
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.Color.Black;
            this.cityTextBox.ForeColor = System.Drawing.Color.White;
            this.cityTextBox.Location = new System.Drawing.Point(132, 100);
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(259, 27);
            this.cityTextBox.TabIndex = 13;
            // 
            // stateTBox
            // 
            this.stateTBox.BackColor = System.Drawing.Color.Black;
            this.stateTBox.ForeColor = System.Drawing.Color.White;
            this.stateTBox.Location = new System.Drawing.Point(132, 133);
            this.stateTBox.Multiline = true;
            this.stateTBox.Name = "stateTBox";
            this.stateTBox.Size = new System.Drawing.Size(259, 27);
            this.stateTBox.TabIndex = 14;
            // 
            // countryTBox
            // 
            this.countryTBox.BackColor = System.Drawing.Color.Black;
            this.countryTBox.ForeColor = System.Drawing.Color.White;
            this.countryTBox.Location = new System.Drawing.Point(132, 166);
            this.countryTBox.Multiline = true;
            this.countryTBox.Name = "countryTBox";
            this.countryTBox.Size = new System.Drawing.Size(259, 27);
            this.countryTBox.TabIndex = 15;
            // 
            // postalCodeTbox
            // 
            this.postalCodeTbox.BackColor = System.Drawing.Color.Black;
            this.postalCodeTbox.ForeColor = System.Drawing.Color.White;
            this.postalCodeTbox.Location = new System.Drawing.Point(132, 199);
            this.postalCodeTbox.Multiline = true;
            this.postalCodeTbox.Name = "postalCodeTbox";
            this.postalCodeTbox.Size = new System.Drawing.Size(259, 27);
            this.postalCodeTbox.TabIndex = 16;
            // 
            // phoneTbox
            // 
            this.phoneTbox.BackColor = System.Drawing.Color.Black;
            this.phoneTbox.ForeColor = System.Drawing.Color.White;
            this.phoneTbox.Location = new System.Drawing.Point(132, 232);
            this.phoneTbox.Multiline = true;
            this.phoneTbox.Name = "phoneTbox";
            this.phoneTbox.Size = new System.Drawing.Size(259, 27);
            this.phoneTbox.TabIndex = 17;
            // 
            // updateBranchBtn
            // 
            this.updateBranchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBranchBtn.Location = new System.Drawing.Point(217, 265);
            this.updateBranchBtn.Name = "updateBranchBtn";
            this.updateBranchBtn.Size = new System.Drawing.Size(84, 28);
            this.updateBranchBtn.TabIndex = 19;
            this.updateBranchBtn.Text = "Delete";
            this.updateBranchBtn.UseVisualStyleBackColor = true;
            this.updateBranchBtn.Click += new System.EventHandler(this.updateBranchBtn_Click);
            // 
            // queryResultLabel
            // 
            this.queryResultlabel.AutoSize = true;
            this.queryResultlabel.Location = new System.Drawing.Point(750, 592);
            this.queryResultlabel.Name = "queryResultLabel";
            this.queryResultlabel.Size = new System.Drawing.Size(35, 13);
            this.queryResultlabel.TabIndex = 20;
            this.queryResultlabel.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brName);
            this.groupBox1.Controls.Add(this.brStreet);
            this.groupBox1.Controls.Add(this.updateBranchBtn);
            this.groupBox1.Controls.Add(this.brCity);
            this.groupBox1.Controls.Add(this.phoneTbox);
            this.groupBox1.Controls.Add(this.CityBr);
            this.groupBox1.Controls.Add(this.postalCodeTbox);
            this.groupBox1.Controls.Add(this.brStree);
            this.groupBox1.Controls.Add(this.countryTBox);
            this.groupBox1.Controls.Add(this.CountryBr);
            this.groupBox1.Controls.Add(this.stateTBox);
            this.groupBox1.Controls.Add(this.postalcodeBr);
            this.groupBox1.Controls.Add(this.cityTextBox);
            this.groupBox1.Controls.Add(this.brNameTbox);
            this.groupBox1.Controls.Add(this.streetTbox);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(39, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 329);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Branch Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Delete Branch ";
            // 
            // UpdateBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1236, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.queryResultlabel);
            this.Controls.Add(this.branchInfoDataGridView);
            this.Controls.Add(this.branchGroupBox);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "UpdateBranch";
            this.Text = "DeleteBranch";
            this.Load += new System.EventHandler(this.UpdateBranch_Load);
            this.branchGroupBox.ResumeLayout(false);
            this.branchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchInfoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox branchNameComboBox;
        private System.Windows.Forms.GroupBox branchGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button branchSearchBtn;
        private System.Windows.Forms.DataGridView branchInfoDataGridView;
        private System.Windows.Forms.Label brName;
        private System.Windows.Forms.Label brStreet;
        private System.Windows.Forms.Label brCity;
        private System.Windows.Forms.Label CityBr;
        private System.Windows.Forms.Label brStree;
        private System.Windows.Forms.Label CountryBr;
        private System.Windows.Forms.Label postalcodeBr;
        private System.Windows.Forms.TextBox brNameTbox;
        private System.Windows.Forms.TextBox streetTbox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTBox;
        private System.Windows.Forms.TextBox countryTBox;
        private System.Windows.Forms.TextBox postalCodeTbox;
        private System.Windows.Forms.TextBox phoneTbox;
        private System.Windows.Forms.Button updateBranchBtn;
        private System.Windows.Forms.Label queryResultlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}