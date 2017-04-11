namespace Paint_Ball_Details
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
            this.lbl_team_leader_rfid_nr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Start_time = new System.Windows.Forms.Label();
            this.tb_team_leader_name = new System.Windows.Forms.TextBox();
            this.lbl_end_time = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listbTeamMemmber = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btStartTime = new System.Windows.Forms.Button();
            this.btEndTime = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbWinOrLose = new System.Windows.Forms.TextBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.tb_team_name = new System.Windows.Forms.TextBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.Scan_For_team_leader = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name  :";
            // 
            // lbl_team_leader_rfid_nr
            // 
            this.lbl_team_leader_rfid_nr.AutoSize = true;
            this.lbl_team_leader_rfid_nr.Location = new System.Drawing.Point(126, 124);
            this.lbl_team_leader_rfid_nr.Name = "lbl_team_leader_rfid_nr";
            this.lbl_team_leader_rfid_nr.Size = new System.Drawing.Size(85, 13);
            this.lbl_team_leader_rfid_nr.TabIndex = 11;
            this.lbl_team_leader_rfid_nr.Text = "teamleaderrfid nr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "RFID NR  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Team Leader   :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_Start_time
            // 
            this.lbl_Start_time.AutoSize = true;
            this.lbl_Start_time.Location = new System.Drawing.Point(126, 53);
            this.lbl_Start_time.Name = "lbl_Start_time";
            this.lbl_Start_time.Size = new System.Drawing.Size(60, 13);
            this.lbl_Start_time.TabIndex = 15;
            this.lbl_Start_time.Text = "Time Show";
            // 
            // tb_team_leader_name
            // 
            this.tb_team_leader_name.Enabled = false;
            this.tb_team_leader_name.Location = new System.Drawing.Point(129, 78);
            this.tb_team_leader_name.Name = "tb_team_leader_name";
            this.tb_team_leader_name.Size = new System.Drawing.Size(100, 20);
            this.tb_team_leader_name.TabIndex = 17;
            // 
            // lbl_end_time
            // 
            this.lbl_end_time.AutoSize = true;
            this.lbl_end_time.Location = new System.Drawing.Point(126, 166);
            this.lbl_end_time.Name = "lbl_end_time";
            this.lbl_end_time.Size = new System.Drawing.Size(30, 13);
            this.lbl_end_time.TabIndex = 20;
            this.lbl_end_time.Text = "Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Team Members";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Score  :\r\n";
            // 
            // listbTeamMemmber
            // 
            this.listbTeamMemmber.FormattingEnabled = true;
            this.listbTeamMemmber.Location = new System.Drawing.Point(365, 101);
            this.listbTeamMemmber.Name = "listbTeamMemmber";
            this.listbTeamMemmber.Size = new System.Drawing.Size(131, 95);
            this.listbTeamMemmber.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Paint_Ball_Details.Properties.Resources.background_logo;
            this.pictureBox1.Location = new System.Drawing.Point(556, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 161);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btStartTime
            // 
            this.btStartTime.Location = new System.Drawing.Point(20, 48);
            this.btStartTime.Name = "btStartTime";
            this.btStartTime.Size = new System.Drawing.Size(75, 23);
            this.btStartTime.TabIndex = 30;
            this.btStartTime.Text = "Start Time";
            this.btStartTime.UseVisualStyleBackColor = true;
            this.btStartTime.Click += new System.EventHandler(this.btStartTime_Click);
            // 
            // btEndTime
            // 
            this.btEndTime.Location = new System.Drawing.Point(12, 161);
            this.btEndTime.Name = "btEndTime";
            this.btEndTime.Size = new System.Drawing.Size(75, 23);
            this.btEndTime.TabIndex = 31;
            this.btEndTime.Text = "End Time";
            this.btEndTime.UseVisualStyleBackColor = true;
            this.btEndTime.Click += new System.EventHandler(this.btEndTime_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Result  :";
            // 
            // tbWinOrLose
            // 
            this.tbWinOrLose.Location = new System.Drawing.Point(259, 243);
            this.tbWinOrLose.Name = "tbWinOrLose";
            this.tbWinOrLose.Size = new System.Drawing.Size(100, 20);
            this.tbWinOrLose.TabIndex = 32;
            this.tbWinOrLose.Text = "Win or Lose";
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(350, 39);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(80, 20);
            this.tbScore.TabIndex = 33;
            this.tbScore.Text = "0";
            // 
            // tb_team_name
            // 
            this.tb_team_name.Location = new System.Drawing.Point(119, 24);
            this.tb_team_name.Name = "tb_team_name";
            this.tb_team_name.Size = new System.Drawing.Size(100, 20);
            this.tb_team_name.TabIndex = 34;
            this.tb_team_name.Text = "Team Name";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(386, 207);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(110, 23);
            this.btn_scan.TabIndex = 35;
            this.btn_scan.Text = "Scan for members";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // Scan_For_team_leader
            // 
            this.Scan_For_team_leader.Location = new System.Drawing.Point(235, 76);
            this.Scan_For_team_leader.Name = "Scan_For_team_leader";
            this.Scan_For_team_leader.Size = new System.Drawing.Size(75, 23);
            this.Scan_For_team_leader.TabIndex = 36;
            this.Scan_For_team_leader.Text = "Scan";
            this.Scan_For_team_leader.UseVisualStyleBackColor = true;
            this.Scan_For_team_leader.Click += new System.EventHandler(this.Scan_For_team_leader_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.Location = new System.Drawing.Point(556, 259);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(75, 23);
            this.Btn_save.TabIndex = 37;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 297);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Scan_For_team_leader);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.tb_team_name);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbWinOrLose);
            this.Controls.Add(this.btEndTime);
            this.Controls.Add(this.btStartTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listbTeamMemmber);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_end_time);
            this.Controls.Add(this.tb_team_leader_name);
            this.Controls.Add(this.lbl_Start_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_team_leader_rfid_nr);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Paint Ball Details";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_team_leader_rfid_nr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Start_time;
        private System.Windows.Forms.TextBox tb_team_leader_name;
        private System.Windows.Forms.Label lbl_end_time;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listbTeamMemmber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btStartTime;
        private System.Windows.Forms.Button btEndTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbWinOrLose;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.TextBox tb_team_name;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button Scan_For_team_leader;
        private System.Windows.Forms.Button Btn_save;
    }
}

