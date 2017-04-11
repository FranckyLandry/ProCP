namespace GUI2
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
            this.btCreditRFID = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAccountClient = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAmountRFID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRFIDNR = new System.Windows.Forms.Label();
            this.lbEnterAmount = new System.Windows.Forms.Label();
            this.tbEnterMoney = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCreditRFID
            // 
            this.btCreditRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreditRFID.Location = new System.Drawing.Point(318, 273);
            this.btCreditRFID.Name = "btCreditRFID";
            this.btCreditRFID.Size = new System.Drawing.Size(200, 48);
            this.btCreditRFID.TabIndex = 3;
            this.btCreditRFID.Text = "Add money on your RFID";
            this.btCreditRFID.UseVisualStyleBackColor = true;
            this.btCreditRFID.Click += new System.EventHandler(this.btCreditRFID_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI2.Properties.Resources.caea6cb8c5bb4d119052d38fd3a3d0e3;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI2.Properties.Resources._1604521_721736941192230_981915106_n;
            this.pictureBox1.Location = new System.Drawing.Point(544, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAccountClient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbAmountRFID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbFullName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbRFIDNR);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(219, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details Info";
            // 
            // lbAccountClient
            // 
            this.lbAccountClient.AutoSize = true;
            this.lbAccountClient.Location = new System.Drawing.Point(144, 119);
            this.lbAccountClient.Name = "lbAccountClient";
            this.lbAccountClient.Size = new System.Drawing.Size(155, 20);
            this.lbAccountClient.TabIndex = 7;
            this.lbAccountClient.Text = "AccontNumberShow";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Account Number:";
            // 
            // lbAmountRFID
            // 
            this.lbAmountRFID.AutoSize = true;
            this.lbAmountRFID.Location = new System.Drawing.Point(120, 87);
            this.lbAmountRFID.Name = "lbAmountRFID";
            this.lbAmountRFID.Size = new System.Drawing.Size(148, 20);
            this.lbAmountRFID.TabIndex = 5;
            this.lbAmountRFID.Text = "Amount RFIDShow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount RFID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "RFID Number:";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(121, 28);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(91, 20);
            this.lbFullName.TabIndex = 3;
            this.lbFullName.Text = "NameShow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Full Name:";
            // 
            // lbRFIDNR
            // 
            this.lbRFIDNR.AutoSize = true;
            this.lbRFIDNR.Location = new System.Drawing.Point(124, 55);
            this.lbRFIDNR.Name = "lbRFIDNR";
            this.lbRFIDNR.Size = new System.Drawing.Size(88, 20);
            this.lbRFIDNR.TabIndex = 1;
            this.lbRFIDNR.Text = "RFIDShow";
            // 
            // lbEnterAmount
            // 
            this.lbEnterAmount.AutoSize = true;
            this.lbEnterAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterAmount.Location = new System.Drawing.Point(256, 210);
            this.lbEnterAmount.Name = "lbEnterAmount";
            this.lbEnterAmount.Size = new System.Drawing.Size(101, 18);
            this.lbEnterAmount.TabIndex = 7;
            this.lbEnterAmount.Text = "Enter amount:";
            // 
            // tbEnterMoney
            // 
            this.tbEnterMoney.Location = new System.Drawing.Point(408, 211);
            this.tbEnterMoney.Name = "tbEnterMoney";
            this.tbEnterMoney.Size = new System.Drawing.Size(100, 20);
            this.tbEnterMoney.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(23, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 141);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SKYWORLD MEMBERS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User_ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbEnterMoney);
            this.Controls.Add(this.lbEnterAmount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCreditRFID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "TRANSFER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btCreditRFID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAccountClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAmountRFID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbRFIDNR;
        private System.Windows.Forms.Label lbEnterAmount;
        private System.Windows.Forms.TextBox tbEnterMoney;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

