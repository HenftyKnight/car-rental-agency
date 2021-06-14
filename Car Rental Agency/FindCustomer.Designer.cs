
namespace Car_Rental_Agency
{
    partial class FindCustomer
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterlabel = new System.Windows.Forms.Label();
            this.membershipComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.membershiplabel = new System.Windows.Forms.Label();
            this.citylabel = new System.Windows.Forms.Label();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fnSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fncityComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchbtn);
            this.groupBox2.Controls.Add(this.citylabel);
            this.groupBox2.Controls.Add(this.membershiplabel);
            this.groupBox2.Controls.Add(this.cityComboBox);
            this.groupBox2.Controls.Add(this.membershipComboBox);
            this.groupBox2.Controls.Add(this.filterlabel);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By Membership";
            // 
            // filterlabel
            // 
            this.filterlabel.AutoSize = true;
            this.filterlabel.Location = new System.Drawing.Point(23, 40);
            this.filterlabel.Name = "filterlabel";
            this.filterlabel.Size = new System.Drawing.Size(34, 13);
            this.filterlabel.TabIndex = 0;
            this.filterlabel.Text = "Filters";
            // 
            // membershipComboBox
            // 
            this.membershipComboBox.FormattingEnabled = true;
            this.membershipComboBox.Location = new System.Drawing.Point(72, 56);
            this.membershipComboBox.Name = "membershipComboBox";
            this.membershipComboBox.Size = new System.Drawing.Size(121, 21);
            this.membershipComboBox.TabIndex = 1;
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(223, 56);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 21);
            this.cityComboBox.TabIndex = 2;
            // 
            // membershiplabel
            // 
            this.membershiplabel.AutoSize = true;
            this.membershiplabel.Location = new System.Drawing.Point(69, 40);
            this.membershiplabel.Name = "membershiplabel";
            this.membershiplabel.Size = new System.Drawing.Size(93, 13);
            this.membershiplabel.TabIndex = 3;
            this.membershiplabel.Text = "MemberShip Type";
            // 
            // citylabel
            // 
            this.citylabel.AutoSize = true;
            this.citylabel.Location = new System.Drawing.Point(220, 40);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(24, 13);
            this.citylabel.TabIndex = 4;
            this.citylabel.Text = "City";
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Location = new System.Drawing.Point(414, 73);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.Size = new System.Drawing.Size(666, 441);
            this.CustomerDataGridView.TabIndex = 2;
            this.CustomerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchbtn
            // 
            this.searchbtn.ForeColor = System.Drawing.Color.Black;
            this.searchbtn.Location = new System.Drawing.Point(169, 83);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 5;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnameTextBox);
            this.groupBox1.Controls.Add(this.fNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fnSearchBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fncityComboBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 195);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "By Name";
            // 
            // fnSearchBtn
            // 
            this.fnSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.fnSearchBtn.Location = new System.Drawing.Point(159, 152);
            this.fnSearchBtn.Name = "fnSearchBtn";
            this.fnSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.fnSearchBtn.TabIndex = 5;
            this.fnSearchBtn.Text = "Search";
            this.fnSearchBtn.UseVisualStyleBackColor = true;
            this.fnSearchBtn.Click += new System.EventHandler(this.fnSearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "City";
            // 
            // fncityComboBox
            // 
            this.fncityComboBox.FormattingEnabled = true;
            this.fncityComboBox.Location = new System.Drawing.Point(223, 56);
            this.fncityComboBox.Name = "fncityComboBox";
            this.fncityComboBox.Size = new System.Drawing.Size(121, 21);
            this.fncityComboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "First Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(72, 66);
            this.fNameTextBox.Multiline = true;
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fNameTextBox.TabIndex = 4;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Location = new System.Drawing.Point(72, 114);
            this.lnameTextBox.Multiline = true;
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lnameTextBox.TabIndex = 10;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(117, 482);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Find Customer";
            // 
            // FindCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1085, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CustomerDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindCustomer";
            this.Text = "FindCustomer";
            this.Load += new System.EventHandler(this.Employee_customers_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label filterlabel;
        private System.Windows.Forms.Label citylabel;
        private System.Windows.Forms.Label membershiplabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox membershipComboBox;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.DataGridView CustomerDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fnSearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fncityComboBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label2;
    }
}