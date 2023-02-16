namespace Client_Truyenfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbduongdan = new System.Windows.Forms.TextBox();
            this.tbketnoi = new System.Windows.Forms.TextBox();
            this.btduongdan = new System.Windows.Forms.Button();
            this.bttiepnhan = new System.Windows.Forms.Button();
            this.btConn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương Trình Truyền File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nơi lưu file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Connection Status";
            // 
            // tbduongdan
            // 
            this.tbduongdan.Location = new System.Drawing.Point(252, 136);
            this.tbduongdan.Name = "tbduongdan";
            this.tbduongdan.Size = new System.Drawing.Size(223, 22);
            this.tbduongdan.TabIndex = 3;
            // 
            // tbketnoi
            // 
            this.tbketnoi.Location = new System.Drawing.Point(252, 265);
            this.tbketnoi.Name = "tbketnoi";
            this.tbketnoi.Size = new System.Drawing.Size(223, 22);
            this.tbketnoi.TabIndex = 4;
            // 
            // btduongdan
            // 
            this.btduongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btduongdan.Location = new System.Drawing.Point(503, 130);
            this.btduongdan.Name = "btduongdan";
            this.btduongdan.Size = new System.Drawing.Size(112, 37);
            this.btduongdan.TabIndex = 5;
            this.btduongdan.Text = "Browse...";
            this.btduongdan.UseVisualStyleBackColor = true;
            this.btduongdan.Click += new System.EventHandler(this.btduongdan_Click);
            // 
            // bttiepnhan
            // 
            this.bttiepnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttiepnhan.Location = new System.Drawing.Point(503, 194);
            this.bttiepnhan.Name = "bttiepnhan";
            this.bttiepnhan.Size = new System.Drawing.Size(112, 36);
            this.bttiepnhan.TabIndex = 6;
            this.bttiepnhan.Text = "Receive";
            this.bttiepnhan.UseVisualStyleBackColor = true;
            this.bttiepnhan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btConn
            // 
            this.btConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConn.Location = new System.Drawing.Point(503, 257);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(112, 34);
            this.btConn.TabIndex = 7;
            this.btConn.Text = "Connect";
            this.btConn.UseVisualStyleBackColor = true;
            this.btConn.Click += new System.EventHandler(this.btConn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btConn);
            this.Controls.Add(this.bttiepnhan);
            this.Controls.Add(this.btduongdan);
            this.Controls.Add(this.tbketnoi);
            this.Controls.Add(this.tbduongdan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbduongdan;
        private System.Windows.Forms.TextBox tbketnoi;
        private System.Windows.Forms.Button btduongdan;
        private System.Windows.Forms.Button bttiepnhan;
        private System.Windows.Forms.Button btConn;
    }
}

