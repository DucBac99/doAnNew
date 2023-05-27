namespace doAnNew
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.turnOnButton = new System.Windows.Forms.Button();
            this.turnOffButton = new System.Windows.Forms.Button();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(110, 36);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(140, 29);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Kết nối với AWS";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(295, 45);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(92, 20);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Chưa kết nối";
            // 
            // turnOnButton
            // 
            this.turnOnButton.Location = new System.Drawing.Point(6, 86);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(94, 29);
            this.turnOnButton.TabIndex = 2;
            this.turnOnButton.Text = "Bật Đèn";
            this.turnOnButton.UseVisualStyleBackColor = true;
            // 
            // turnOffButton
            // 
            this.turnOffButton.Location = new System.Drawing.Point(136, 86);
            this.turnOffButton.Name = "turnOffButton";
            this.turnOffButton.Size = new System.Drawing.Size(94, 29);
            this.turnOffButton.TabIndex = 3;
            this.turnOffButton.Text = "Tắt Đèn";
            this.turnOffButton.UseVisualStyleBackColor = true;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(169, 95);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(47, 20);
            this.temperatureLabel.TabIndex = 4;
            this.temperatureLabel.Text = "28 độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhiệt độ đo được:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.turnOnButton);
            this.groupBox1.Controls.Add(this.turnOffButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khối điều khiển";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.temperatureLabel);
            this.groupBox2.Location = new System.Drawing.Point(284, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 125);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khối cảm  biến";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.connectButton);
            this.groupBox3.Controls.Add(this.statusLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 75);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khối kết nối";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Điều khiển Led";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đo nhiệt độ từ cảm biến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(106, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "HỌC VIỆN KỸ THUẬT QUÂN SỰ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(148, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đồ Án Tốt Nghiệp Đại Học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(45, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(473, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nghiên cứu, khai thác bộ Network Stack cho hệ vi điều khiển";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(126, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "phục vụ các bài toán IoT và IoT Cloud";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "GV hướng dẫn: Nguyễn Hữu Thọ - Đàm Đức Thuận";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "SV thực hiện: Nguyễn Đức Bắc - Nguyễn Quốc Khánh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 487);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AWS IoT Core MQTT Cyclone TCP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button connectButton;
        private Label statusLabel;
        private Button turnOnButton;
        private Button turnOffButton;
        private Label temperatureLabel;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}