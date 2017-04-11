namespace CoffeShop
{
    partial class CoffeeShopKassa
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.lbl_amount_to_pay = new System.Windows.Forms.Label();
            this.lbl_Person_Name = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.lbTotalAmountShow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.lbRFIDNR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeShop.Properties.Resources._1604521_721736941192230_981915106_n;
            this.pictureBox1.Location = new System.Drawing.Point(355, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lbl_Money);
            this.groupBox2.Controls.Add(this.lbl_amount_to_pay);
            this.groupBox2.Controls.Add(this.lbl_Person_Name);
            this.groupBox2.Controls.Add(this.lbl_Name);
            this.groupBox2.Controls.Add(this.btClose);
            this.groupBox2.Controls.Add(this.lbTotalAmountShow);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btCancel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btOK);
            this.groupBox2.Controls.Add(this.lbRFIDNR);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details Info";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Location = new System.Drawing.Point(134, 115);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(56, 20);
            this.lbl_Money.TabIndex = 12;
            this.lbl_Money.Text = "Money";
            // 
            // lbl_amount_to_pay
            // 
            this.lbl_amount_to_pay.AutoSize = true;
            this.lbl_amount_to_pay.Location = new System.Drawing.Point(11, 115);
            this.lbl_amount_to_pay.Name = "lbl_amount_to_pay";
            this.lbl_amount_to_pay.Size = new System.Drawing.Size(117, 20);
            this.lbl_amount_to_pay.TabIndex = 11;
            this.lbl_amount_to_pay.Text = "Amount To Pay";
            // 
            // lbl_Person_Name
            // 
            this.lbl_Person_Name.AutoSize = true;
            this.lbl_Person_Name.Location = new System.Drawing.Point(120, 58);
            this.lbl_Person_Name.Name = "lbl_Person_Name";
            this.lbl_Person_Name.Size = new System.Drawing.Size(110, 20);
            this.lbl_Person_Name.TabIndex = 10;
            this.lbl_Person_Name.Text = "Person_Name";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(11, 58);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(51, 20);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Name";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(92, 185);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 32);
            this.btClose.TabIndex = 8;
            this.btClose.Text = "Close\r\n";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbTotalAmountShow
            // 
            this.lbTotalAmountShow.AutoSize = true;
            this.lbTotalAmountShow.Location = new System.Drawing.Point(120, 86);
            this.lbTotalAmountShow.Name = "lbTotalAmountShow";
            this.lbTotalAmountShow.Size = new System.Drawing.Size(144, 20);
            this.lbTotalAmountShow.TabIndex = 7;
            this.lbTotalAmountShow.Text = "TotalAmount Show";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Amount:";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(144, 138);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 30);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RFID Number:";
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(23, 138);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 30);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click_1);
            // 
            // lbRFIDNR
            // 
            this.lbRFIDNR.AutoSize = true;
            this.lbRFIDNR.Location = new System.Drawing.Point(120, 22);
            this.lbRFIDNR.Name = "lbRFIDNR";
            this.lbRFIDNR.Size = new System.Drawing.Size(88, 20);
            this.lbRFIDNR.TabIndex = 1;
            this.lbRFIDNR.Text = "RFIDShow";
            // 
            // CoffeeShopKassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeShop.Properties.Resources.secondkassa;
            this.ClientSize = new System.Drawing.Size(454, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CoffeeShopKassa";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "CoffeeShopKassa";
            this.Deactivate += new System.EventHandler(this.CoffeeShopKassa_Deactivate);
            this.Load += new System.EventHandler(this.CoffeeShopKassa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTotalAmountShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbRFIDNR;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbl_Person_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Label lbl_amount_to_pay;
    }
}