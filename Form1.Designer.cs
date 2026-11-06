namespace LuckyCafe_Order
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoTea = new System.Windows.Forms.RadioButton();
            this.rdoCoffee = new System.Windows.Forms.RadioButton();
            this.rdoJuice = new System.Windows.Forms.RadioButton();
            this.grpDrink_types = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkStudent_Member = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad_FromFile = new System.Windows.Forms.Button();
            this.btnSave_File = new System.Windows.Forms.Button();
            this.Order_List = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblLucky_Message = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpDrink_types.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lucky Cafe Order";
            // 
            // txtCustomer_Name
            // 
            this.txtCustomer_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer_Name.Location = new System.Drawing.Point(35, 186);
            this.txtCustomer_Name.Multiline = true;
            this.txtCustomer_Name.Name = "txtCustomer_Name";
            this.txtCustomer_Name.Size = new System.Drawing.Size(476, 36);
            this.txtCustomer_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customar Information";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(585, 444);
            this.listBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customar Name :";
            // 
            // rdoTea
            // 
            this.rdoTea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTea.Location = new System.Drawing.Point(16, 37);
            this.rdoTea.Name = "rdoTea";
            this.rdoTea.Size = new System.Drawing.Size(104, 24);
            this.rdoTea.TabIndex = 5;
            this.rdoTea.Text = "Tea ($1)";
            this.rdoTea.UseVisualStyleBackColor = false;
            // 
            // rdoCoffee
            // 
            this.rdoCoffee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoCoffee.Location = new System.Drawing.Point(16, 78);
            this.rdoCoffee.Name = "rdoCoffee";
            this.rdoCoffee.Size = new System.Drawing.Size(148, 24);
            this.rdoCoffee.TabIndex = 6;
            this.rdoCoffee.Text = "Coffee ($2)";
            this.rdoCoffee.UseVisualStyleBackColor = false;
            // 
            // rdoJuice
            // 
            this.rdoJuice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdoJuice.Location = new System.Drawing.Point(16, 119);
            this.rdoJuice.Name = "rdoJuice";
            this.rdoJuice.Size = new System.Drawing.Size(104, 24);
            this.rdoJuice.TabIndex = 7;
            this.rdoJuice.Text = "Juice ($3)";
            this.rdoJuice.UseVisualStyleBackColor = false;
            // 
            // grpDrink_types
            // 
            this.grpDrink_types.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDrink_types.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpDrink_types.Controls.Add(this.rdoCoffee);
            this.grpDrink_types.Controls.Add(this.rdoTea);
            this.grpDrink_types.Controls.Add(this.rdoJuice);
            this.grpDrink_types.Location = new System.Drawing.Point(38, 261);
            this.grpDrink_types.Name = "grpDrink_types";
            this.grpDrink_types.Size = new System.Drawing.Size(473, 167);
            this.grpDrink_types.TabIndex = 9;
            this.grpDrink_types.TabStop = false;
            this.grpDrink_types.Text = "  Drink Type       ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(139, 441);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(77, 41);
            this.txtQuantity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // chkStudent_Member
            // 
            this.chkStudent_Member.AutoSize = true;
            this.chkStudent_Member.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkStudent_Member.Location = new System.Drawing.Point(274, 455);
            this.chkStudent_Member.Name = "chkStudent_Member";
            this.chkStudent_Member.Size = new System.Drawing.Size(226, 24);
            this.chkStudent_Member.TabIndex = 12;
            this.chkStudent_Member.Text = "Student Member (10% Off)";
            this.chkStudent_Member.UseVisualStyleBackColor = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 557);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(282, 48);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate Order";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(971, 557);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(282, 48);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad_FromFile
            // 
            this.btnLoad_FromFile.Location = new System.Drawing.Point(647, 557);
            this.btnLoad_FromFile.Name = "btnLoad_FromFile";
            this.btnLoad_FromFile.Size = new System.Drawing.Size(282, 48);
            this.btnLoad_FromFile.TabIndex = 15;
            this.btnLoad_FromFile.Text = "Load From File";
            this.btnLoad_FromFile.UseVisualStyleBackColor = true;
            this.btnLoad_FromFile.Click += new System.EventHandler(this.btnLoad_FromFile_Click);
            // 
            // btnSave_File
            // 
            this.btnSave_File.Location = new System.Drawing.Point(329, 557);
            this.btnSave_File.Name = "btnSave_File";
            this.btnSave_File.Size = new System.Drawing.Size(282, 48);
            this.btnSave_File.TabIndex = 16;
            this.btnSave_File.Text = "Save File";
            this.btnSave_File.UseVisualStyleBackColor = true;
            this.btnSave_File.Click += new System.EventHandler(this.btnSave_File_Click);
            // 
            // Order_List
            // 
            this.Order_List.FormattingEnabled = true;
            this.Order_List.ItemHeight = 20;
            this.Order_List.Location = new System.Drawing.Point(638, 120);
            this.Order_List.Name = "Order_List";
            this.Order_List.Size = new System.Drawing.Size(618, 404);
            this.Order_List.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "  "});
            this.listBox2.Location = new System.Drawing.Point(27, 624);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1230, 84);
            this.listBox2.TabIndex = 19;
            // 
            // lblLucky_Message
            // 
            this.lblLucky_Message.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLucky_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucky_Message.ForeColor = System.Drawing.Color.Chocolate;
            this.lblLucky_Message.Location = new System.Drawing.Point(31, 671);
            this.lblLucky_Message.Name = "lblLucky_Message";
            this.lblLucky_Message.Size = new System.Drawing.Size(485, 31);
            this.lblLucky_Message.TabIndex = 20;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPrice.Location = new System.Drawing.Point(34, 631);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(482, 31);
            this.lblPrice.TabIndex = 21;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiscount.Location = new System.Drawing.Point(643, 292);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(308, 168);
            this.lblDiscount.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 731);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblLucky_Message);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Order_List);
            this.Controls.Add(this.btnSave_File);
            this.Controls.Add(this.btnLoad_FromFile);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkStudent_Member);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.grpDrink_types);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomer_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Drink Type";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDrink_types.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoTea;
        private System.Windows.Forms.RadioButton rdoCoffee;
        private System.Windows.Forms.RadioButton rdoJuice;
        private System.Windows.Forms.GroupBox grpDrink_types;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkStudent_Member;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad_FromFile;
        private System.Windows.Forms.Button btnSave_File;
        private System.Windows.Forms.ListBox Order_List;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblLucky_Message;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

