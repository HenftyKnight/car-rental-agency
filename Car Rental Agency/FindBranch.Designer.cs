
namespace Car_Rental_Agency
{
    partial class FindBranch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBranchTextBox = new System.Windows.Forms.TextBox();
            this.branchNameLabel = new System.Windows.Forms.Label();
            this.searchBranchbtn = new System.Windows.Forms.Button();
            this.branchInfodataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.branchNameResultLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.branchIDsearchBtn = new System.Windows.Forms.Button();
            this.branchIDLabel = new System.Windows.Forms.Label();
            this.branchIDtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.branchIDResultlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchInfodataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBranchbtn);
            this.groupBox1.Controls.Add(this.branchNameLabel);
            this.groupBox1.Controls.Add(this.searchBranchTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(36, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branch Name";
            // 
            // searchBranchTextBox
            // 
            this.searchBranchTextBox.Location = new System.Drawing.Point(112, 57);
            this.searchBranchTextBox.Multiline = true;
            this.searchBranchTextBox.Name = "searchBranchTextBox";
            this.searchBranchTextBox.Size = new System.Drawing.Size(163, 24);
            this.searchBranchTextBox.TabIndex = 0;
            // 
            // branchNameLabel
            // 
            this.branchNameLabel.AutoSize = true;
            this.branchNameLabel.Location = new System.Drawing.Point(6, 57);
            this.branchNameLabel.Name = "branchNameLabel";
            this.branchNameLabel.Size = new System.Drawing.Size(106, 20);
            this.branchNameLabel.TabIndex = 1;
            this.branchNameLabel.Text = "Branch Name";
            // 
            // searchBranchbtn
            // 
            this.searchBranchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBranchbtn.ForeColor = System.Drawing.Color.Black;
            this.searchBranchbtn.Location = new System.Drawing.Point(147, 96);
            this.searchBranchbtn.Name = "searchBranchbtn";
            this.searchBranchbtn.Size = new System.Drawing.Size(87, 29);
            this.searchBranchbtn.TabIndex = 2;
            this.searchBranchbtn.Text = "Search";
            this.searchBranchbtn.UseVisualStyleBackColor = true;
            // 
            // branchInfodataGridView
            // 
            this.branchInfodataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.branchInfodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchInfodataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.branchInfodataGridView.Location = new System.Drawing.Point(351, 69);
            this.branchInfodataGridView.Name = "branchInfodataGridView";
            this.branchInfodataGridView.Size = new System.Drawing.Size(868, 367);
            this.branchInfodataGridView.TabIndex = 1;
            this.branchInfodataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Find Branch";
            // 
            // branchNameResultLabel
            // 
            this.branchNameResultLabel.AutoSize = true;
            this.branchNameResultLabel.BackColor = System.Drawing.Color.Black;
            this.branchNameResultLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchNameResultLabel.ForeColor = System.Drawing.Color.Snow;
            this.branchNameResultLabel.Location = new System.Drawing.Point(388, 448);
            this.branchNameResultLabel.Name = "branchNameResultLabel";
            this.branchNameResultLabel.Size = new System.Drawing.Size(0, 29);
            this.branchNameResultLabel.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.branchIDsearchBtn);
            this.groupBox2.Controls.Add(this.branchIDLabel);
            this.groupBox2.Controls.Add(this.branchIDtextbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(36, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BranchID";
            // 
            // branchIDsearchBtn
            // 
            this.branchIDsearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDsearchBtn.ForeColor = System.Drawing.Color.Black;
            this.branchIDsearchBtn.Location = new System.Drawing.Point(147, 99);
            this.branchIDsearchBtn.Name = "branchIDsearchBtn";
            this.branchIDsearchBtn.Size = new System.Drawing.Size(87, 29);
            this.branchIDsearchBtn.TabIndex = 2;
            this.branchIDsearchBtn.Text = "Search";
            this.branchIDsearchBtn.UseVisualStyleBackColor = true;
            // 
            // branchIDLabel
            // 
            this.branchIDLabel.AutoSize = true;
            this.branchIDLabel.Location = new System.Drawing.Point(6, 53);
            this.branchIDLabel.Name = "branchIDLabel";
            this.branchIDLabel.Size = new System.Drawing.Size(77, 20);
            this.branchIDLabel.TabIndex = 1;
            this.branchIDLabel.Text = "BranchID";
            // 
            // branchIDtextbox
            // 
            this.branchIDtextbox.Location = new System.Drawing.Point(100, 50);
            this.branchIDtextbox.Multiline = true;
            this.branchIDtextbox.Name = "branchIDtextbox";
            this.branchIDtextbox.Size = new System.Drawing.Size(163, 24);
            this.branchIDtextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(408, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // branchIDResultlabel
            // 
            this.branchIDResultlabel.AutoSize = true;
            this.branchIDResultlabel.BackColor = System.Drawing.Color.Black;
            this.branchIDResultlabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchIDResultlabel.Location = new System.Drawing.Point(347, 448);
            this.branchIDResultlabel.Name = "branchIDResultlabel";
            this.branchIDResultlabel.Size = new System.Drawing.Size(0, 29);
            this.branchIDResultlabel.TabIndex = 7;
            // 
            // UpdateBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1244, 493);
            this.Controls.Add(this.branchIDResultlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.branchNameResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.branchInfodataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateBranch";
            this.Text = "UpdateBranch";
            this.Load += new System.EventHandler(this.UpdateBranch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchInfodataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchBranchbtn;
        private System.Windows.Forms.Label branchNameLabel;
        private System.Windows.Forms.TextBox searchBranchTextBox;
        private System.Windows.Forms.DataGridView branchInfodataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label branchNameResultLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label branchIDLabel;
        private System.Windows.Forms.TextBox branchIDtextbox;
        private System.Windows.Forms.Button branchIDsearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label branchIDResultlabel;
    }
}