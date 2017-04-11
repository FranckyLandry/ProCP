namespace Pain_Ball
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
            this.gpRentingSuit = new System.Windows.Forms.GroupBox();
            this.btn_Calculate_Rent = new System.Windows.Forms.Button();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbPaintBallSuit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpOwnsuit = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lbl_Amount_Show = new System.Windows.Forms.Label();
            this.lbl_Total_Amount = new System.Windows.Forms.Label();
            this.tb_Gun_set = new System.Windows.Forms.TextBox();
            this.lbl_gun_set = new System.Windows.Forms.Label();
            this.rdOwnsuit = new System.Windows.Forms.RadioButton();
            this.rdRentSuit = new System.Windows.Forms.RadioButton();
            this.btPay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.gpRentingSuit.SuspendLayout();
            this.gpOwnsuit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpRentingSuit
            // 
            this.gpRentingSuit.Controls.Add(this.btn_Calculate_Rent);
            this.gpRentingSuit.Controls.Add(this.lbAmount);
            this.gpRentingSuit.Controls.Add(this.tbPaintBallSuit);
            this.gpRentingSuit.Controls.Add(this.label6);
            this.gpRentingSuit.Controls.Add(this.label5);
            this.gpRentingSuit.Location = new System.Drawing.Point(338, 138);
            this.gpRentingSuit.Name = "gpRentingSuit";
            this.gpRentingSuit.Size = new System.Drawing.Size(248, 116);
            this.gpRentingSuit.TabIndex = 1;
            this.gpRentingSuit.TabStop = false;
            this.gpRentingSuit.Text = "Renting Suit";
            // 
            // btn_Calculate_Rent
            // 
            this.btn_Calculate_Rent.Location = new System.Drawing.Point(87, 75);
            this.btn_Calculate_Rent.Name = "btn_Calculate_Rent";
            this.btn_Calculate_Rent.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate_Rent.TabIndex = 6;
            this.btn_Calculate_Rent.Text = "Calculate";
            this.btn_Calculate_Rent.UseVisualStyleBackColor = true;
            this.btn_Calculate_Rent.Click += new System.EventHandler(this.btn_Calculate_Rent_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(125, 59);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(73, 13);
            this.lbAmount.TabIndex = 5;
            this.lbAmount.Text = "Amount Show";
            // 
            // tbPaintBallSuit
            // 
            this.tbPaintBallSuit.Location = new System.Drawing.Point(128, 29);
            this.tbPaintBallSuit.Name = "tbPaintBallSuit";
            this.tbPaintBallSuit.Size = new System.Drawing.Size(114, 20);
            this.tbPaintBallSuit.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Paint Ball Suit Number";
            // 
            // gpOwnsuit
            // 
            this.gpOwnsuit.Controls.Add(this.btn_Calculate);
            this.gpOwnsuit.Controls.Add(this.lbl_Amount_Show);
            this.gpOwnsuit.Controls.Add(this.lbl_Total_Amount);
            this.gpOwnsuit.Controls.Add(this.tb_Gun_set);
            this.gpOwnsuit.Controls.Add(this.lbl_gun_set);
            this.gpOwnsuit.Location = new System.Drawing.Point(12, 129);
            this.gpOwnsuit.Name = "gpOwnsuit";
            this.gpOwnsuit.Size = new System.Drawing.Size(277, 107);
            this.gpOwnsuit.TabIndex = 2;
            this.gpOwnsuit.TabStop = false;
            this.gpOwnsuit.Text = "Own Suit";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(80, 80);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(69, 21);
            this.btn_Calculate.TabIndex = 4;
            this.btn_Calculate.Text = "Calculate\r\n";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // lbl_Amount_Show
            // 
            this.lbl_Amount_Show.AutoSize = true;
            this.lbl_Amount_Show.Location = new System.Drawing.Point(109, 58);
            this.lbl_Amount_Show.Name = "lbl_Amount_Show";
            this.lbl_Amount_Show.Size = new System.Drawing.Size(73, 13);
            this.lbl_Amount_Show.TabIndex = 3;
            this.lbl_Amount_Show.Text = "Amount Show";
            // 
            // lbl_Total_Amount
            // 
            this.lbl_Total_Amount.AutoSize = true;
            this.lbl_Total_Amount.Location = new System.Drawing.Point(16, 59);
            this.lbl_Total_Amount.Name = "lbl_Total_Amount";
            this.lbl_Total_Amount.Size = new System.Drawing.Size(76, 13);
            this.lbl_Total_Amount.TabIndex = 2;
            this.lbl_Total_Amount.Text = "Total Amount :";
            // 
            // tb_Gun_set
            // 
            this.tb_Gun_set.Location = new System.Drawing.Point(144, 19);
            this.tb_Gun_set.Name = "tb_Gun_set";
            this.tb_Gun_set.Size = new System.Drawing.Size(86, 20);
            this.tb_Gun_set.TabIndex = 1;
            // 
            // lbl_gun_set
            // 
            this.lbl_gun_set.AutoSize = true;
            this.lbl_gun_set.Location = new System.Drawing.Point(13, 22);
            this.lbl_gun_set.Name = "lbl_gun_set";
            this.lbl_gun_set.Size = new System.Drawing.Size(125, 13);
            this.lbl_gun_set.TabIndex = 0;
            this.lbl_gun_set.Text = "Total Number of Gun Set";
            // 
            // rdOwnsuit
            // 
            this.rdOwnsuit.AutoSize = true;
            this.rdOwnsuit.Location = new System.Drawing.Point(32, 97);
            this.rdOwnsuit.Name = "rdOwnsuit";
            this.rdOwnsuit.Size = new System.Drawing.Size(71, 17);
            this.rdOwnsuit.TabIndex = 4;
            this.rdOwnsuit.Text = "Own Suit:";
            this.rdOwnsuit.UseVisualStyleBackColor = true;
            this.rdOwnsuit.CheckedChanged += new System.EventHandler(this.rdOwnsuit_CheckedChanged);
            // 
            // rdRentSuit
            // 
            this.rdRentSuit.AutoSize = true;
            this.rdRentSuit.Location = new System.Drawing.Point(156, 97);
            this.rdRentSuit.Name = "rdRentSuit";
            this.rdRentSuit.Size = new System.Drawing.Size(69, 17);
            this.rdRentSuit.TabIndex = 5;
            this.rdRentSuit.Text = "Rent Suit";
            this.rdRentSuit.UseVisualStyleBackColor = true;
            this.rdRentSuit.CheckedChanged += new System.EventHandler(this.rdRentSuit_CheckedChanged);
            // 
            // btPay
            // 
            this.btPay.Location = new System.Drawing.Point(191, 268);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(98, 33);
            this.btPay.TabIndex = 7;
            this.btPay.Text = "Pay";
            this.btPay.UseVisualStyleBackColor = true;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Pain_Ball.Properties.Resources._14660720_military_grunge_with_stars_ans_stains;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pain_Ball.Properties.Resources.paintballsuit;
            this.pictureBox2.Location = new System.Drawing.Point(25, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pain_Ball.Properties.Resources.CasquePaintBall;
            this.pictureBox4.Location = new System.Drawing.Point(350, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pain_Ball.Properties.Resources.US_Army_Project_Salvo_Paintball_Gun_MEGA_Set;
            this.pictureBox3.Location = new System.Drawing.Point(190, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pain_Ball.Properties.Resources._1604521_721736941192230_981915106_n;
            this.pictureBox1.Location = new System.Drawing.Point(514, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(361, 268);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(101, 33);
            this.btn_Return.TabIndex = 8;
            this.btn_Return.Text = "End Time";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(13, 241);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(36, 13);
            this.lbl_Note.TabIndex = 9;
            this.lbl_Note.Text = "Note :";
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Location = new System.Drawing.Point(64, 241);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(27, 13);
            this.lbl_Msg.TabIndex = 10;
            this.lbl_Msg.Text = "Msg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 313);
            this.Controls.Add(this.lbl_Msg);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btPay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdOwnsuit);
            this.Controls.Add(this.rdRentSuit);
            this.Controls.Add(this.gpOwnsuit);
            this.Controls.Add(this.gpRentingSuit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpRentingSuit.ResumeLayout(false);
            this.gpRentingSuit.PerformLayout();
            this.gpOwnsuit.ResumeLayout(false);
            this.gpOwnsuit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpRentingSuit;
        private System.Windows.Forms.GroupBox gpOwnsuit;
        private System.Windows.Forms.Label lbl_gun_set;
        private System.Windows.Forms.RadioButton rdOwnsuit;
        private System.Windows.Forms.RadioButton rdRentSuit;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbPaintBallSuit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.TextBox tb_Gun_set;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_Amount_Show;
        private System.Windows.Forms.Label lbl_Total_Amount;
        private System.Windows.Forms.Button btn_Calculate_Rent;
    }
}

