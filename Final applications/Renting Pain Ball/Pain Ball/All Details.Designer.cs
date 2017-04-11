namespace Pain_Ball
{
    partial class All_Details
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
            this.lbRifdShow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAmountShow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Start_Time = new System.Windows.Forms.Label();
            this.gpePayDetails = new System.Windows.Forms.GroupBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Name_Show = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_Amount_Paid = new System.Windows.Forms.Label();
            this.lbl_Amount_Show = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpePayDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RIFD NR:";
            // 
            // lbRifdShow
            // 
            this.lbRifdShow.AutoSize = true;
            this.lbRifdShow.Location = new System.Drawing.Point(111, 16);
            this.lbRifdShow.Name = "lbRifdShow";
            this.lbRifdShow.Size = new System.Drawing.Size(65, 13);
            this.lbRifdShow.TabIndex = 1;
            this.lbRifdShow.Text = "RIFD Show:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " Total Amount";
            // 
            // lbAmountShow
            // 
            this.lbAmountShow.AutoSize = true;
            this.lbAmountShow.Location = new System.Drawing.Point(111, 55);
            this.lbAmountShow.Name = "lbAmountShow";
            this.lbAmountShow.Size = new System.Drawing.Size(73, 13);
            this.lbAmountShow.TabIndex = 3;
            this.lbAmountShow.Text = "Amount Show";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pain_Ball.Properties.Resources._1604521_721736941192230_981915106_n;
            this.pictureBox1.Location = new System.Drawing.Point(337, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start Time:";
            // 
            // lbl_Start_Time
            // 
            this.lbl_Start_Time.AutoSize = true;
            this.lbl_Start_Time.Location = new System.Drawing.Point(111, 74);
            this.lbl_Start_Time.Name = "lbl_Start_Time";
            this.lbl_Start_Time.Size = new System.Drawing.Size(83, 13);
            this.lbl_Start_Time.TabIndex = 6;
            this.lbl_Start_Time.Text = "Start Time show";
            // 
            // gpePayDetails
            // 
            this.gpePayDetails.Controls.Add(this.lbl_Amount_Show);
            this.gpePayDetails.Controls.Add(this.lbl_Amount_Paid);
            this.gpePayDetails.Controls.Add(this.btn_Close);
            this.gpePayDetails.Controls.Add(this.lbl_Name_Show);
            this.gpePayDetails.Controls.Add(this.lbl_Name);
            this.gpePayDetails.Controls.Add(this.btn_Cancel);
            this.gpePayDetails.Controls.Add(this.btn_OK);
            this.gpePayDetails.Controls.Add(this.label3);
            this.gpePayDetails.Controls.Add(this.lbl_Start_Time);
            this.gpePayDetails.Controls.Add(this.lbRifdShow);
            this.gpePayDetails.Controls.Add(this.label2);
            this.gpePayDetails.Controls.Add(this.label1);
            this.gpePayDetails.Controls.Add(this.lbAmountShow);
            this.gpePayDetails.Location = new System.Drawing.Point(12, 12);
            this.gpePayDetails.Name = "gpePayDetails";
            this.gpePayDetails.Size = new System.Drawing.Size(249, 161);
            this.gpePayDetails.TabIndex = 7;
            this.gpePayDetails.TabStop = false;
            this.gpePayDetails.Text = "Pay Details";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(69, 138);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Name_Show
            // 
            this.lbl_Name_Show.AutoSize = true;
            this.lbl_Name_Show.Location = new System.Drawing.Point(114, 39);
            this.lbl_Name_Show.Name = "lbl_Name_Show";
            this.lbl_Name_Show.Size = new System.Drawing.Size(68, 13);
            this.lbl_Name_Show.TabIndex = 10;
            this.lbl_Name_Show.Text = "Name_Show";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(6, 39);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 13);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Name :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(133, 109);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(9, 109);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_Amount_Paid
            // 
            this.lbl_Amount_Paid.AutoSize = true;
            this.lbl_Amount_Paid.Location = new System.Drawing.Point(7, 91);
            this.lbl_Amount_Paid.Name = "lbl_Amount_Paid";
            this.lbl_Amount_Paid.Size = new System.Drawing.Size(100, 13);
            this.lbl_Amount_Paid.TabIndex = 12;
            this.lbl_Amount_Paid.Text = "Amount to be Paid :";
            // 
            // lbl_Amount_Show
            // 
            this.lbl_Amount_Show.AutoSize = true;
            this.lbl_Amount_Show.Location = new System.Drawing.Point(114, 91);
            this.lbl_Amount_Show.Name = "lbl_Amount_Show";
            this.lbl_Amount_Show.Size = new System.Drawing.Size(73, 13);
            this.lbl_Amount_Show.TabIndex = 13;
            this.lbl_Amount_Show.Text = "Amount Show";
            this.lbl_Amount_Show.Click += new System.EventHandler(this.lbl_Amount_Show_Click);
            // 
            // All_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 177);
            this.Controls.Add(this.gpePayDetails);
            this.Controls.Add(this.pictureBox1);
            this.Name = "All_Details";
            this.Text = "All_Details";
            this.Deactivate += new System.EventHandler(this.All_Details_Deactivate);
            this.Load += new System.EventHandler(this.All_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpePayDetails.ResumeLayout(false);
            this.gpePayDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRifdShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAmountShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Start_Time;
        private System.Windows.Forms.GroupBox gpePayDetails;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_Name_Show;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Amount_Show;
        private System.Windows.Forms.Label lbl_Amount_Paid;
    }
}