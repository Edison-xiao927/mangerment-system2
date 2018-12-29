namespace UI
{
    partial class Form扫描
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
            this.pnlprogress = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.btnupload = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_Dev = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlprogress.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlprogress
            // 
            this.pnlprogress.Controls.Add(this.lblSize);
            this.pnlprogress.Controls.Add(this.lblState);
            this.pnlprogress.Controls.Add(this.lblSpeed);
            this.pnlprogress.Controls.Add(this.lblTime);
            this.pnlprogress.Controls.Add(this.label1);
            this.pnlprogress.Controls.Add(this.progressBar1);
            this.pnlprogress.Location = new System.Drawing.Point(246, 234);
            this.pnlprogress.Margin = new System.Windows.Forms.Padding(2);
            this.pnlprogress.Name = "pnlprogress";
            this.pnlprogress.Size = new System.Drawing.Size(666, 65);
            this.pnlprogress.TabIndex = 12;
            this.pnlprogress.Visible = false;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.Red;
            this.lblSize.Location = new System.Drawing.Point(415, 35);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(53, 12);
            this.lblSize.TabIndex = 26;
            this.lblSize.Text = "提示信息";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(415, 9);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(53, 12);
            this.lblState.TabIndex = 25;
            this.lblState.Text = "提示信息";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.ForeColor = System.Drawing.Color.Red;
            this.lblSpeed.Location = new System.Drawing.Point(252, 35);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(53, 12);
            this.lblSpeed.TabIndex = 24;
            this.lblSpeed.Text = "提示信息";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(252, 9);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 12);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "提示信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "完成进度";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(65, 15);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 15);
            this.progressBar1.TabIndex = 21;
            // 
            // pnlImage
            // 
            this.pnlImage.AutoScroll = true;
            this.pnlImage.Location = new System.Drawing.Point(234, 323);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(2);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(678, 361);
            this.pnlImage.TabIndex = 11;
            this.pnlImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlImage_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCode);
            this.groupBox3.Controls.Add(this.btnSeach);
            this.groupBox3.Controls.Add(this.btnupload);
            this.groupBox3.Controls.Add(this.btnScan);
            this.groupBox3.Location = new System.Drawing.Point(246, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(666, 50);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "扫描操作";
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(19, 15);
            this.btnCode.Margin = new System.Windows.Forms.Padding(2);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(89, 29);
            this.btnCode.TabIndex = 13;
            this.btnCode.Text = "上传二维码";
            this.btnCode.UseVisualStyleBackColor = true;
            // 
            // btnSeach
            // 
            this.btnSeach.Location = new System.Drawing.Point(205, 15);
            this.btnSeach.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(76, 29);
            this.btnSeach.TabIndex = 12;
            this.btnSeach.Text = "查看扫描件";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(298, 15);
            this.btnupload.Margin = new System.Windows.Forms.Padding(2);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(66, 29);
            this.btnupload.TabIndex = 11;
            this.btnupload.Text = "提交";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(122, 15);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(68, 29);
            this.btnScan.TabIndex = 10;
            this.btnScan.Text = "开始扫描";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_Dev);
            this.groupBox1.Location = new System.Drawing.Point(246, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 59);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "扫描源";
            // 
            // combo_Dev
            // 
            this.combo_Dev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Dev.FormattingEnabled = true;
            this.combo_Dev.Location = new System.Drawing.Point(19, 27);
            this.combo_Dev.Name = "combo_Dev";
            this.combo_Dev.Size = new System.Drawing.Size(631, 20);
            this.combo_Dev.TabIndex = 0;
            this.combo_Dev.SelectedIndexChanged += new System.EventHandler(this.combo_Dev_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(811, 50);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form扫描
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 721);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlprogress);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form扫描";
            this.Text = "Form扫描";
            this.Load += new System.EventHandler(this.Form扫描_Load);
            this.pnlprogress.ResumeLayout(false);
            this.pnlprogress.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlprogress;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_Dev;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}