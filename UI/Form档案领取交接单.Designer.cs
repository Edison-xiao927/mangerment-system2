namespace UI
{
    partial class Form档案领取交接单
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBoxNX = new System.Windows.Forms.TextBox();
            this.dateTimePickerlLQSJ = new System.Windows.Forms.DateTimePicker();
            this.textBoxDH = new System.Windows.Forms.TextBox();
            this.textBoxXMDW = new System.Windows.Forms.TextBox();
            this.textBoxLQPCH = new System.Windows.Forms.TextBox();
            this.textBoxGDFS = new System.Windows.Forms.TextBox();
            this.textBoxDALX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerRQ2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRQ1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxJGDW = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "打印";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.textBoxNX);
            this.groupBox2.Controls.Add(this.dateTimePickerlLQSJ);
            this.groupBox2.Controls.Add(this.textBoxDH);
            this.groupBox2.Controls.Add(this.textBoxXMDW);
            this.groupBox2.Controls.Add(this.textBoxLQPCH);
            this.groupBox2.Controls.Add(this.textBoxGDFS);
            this.groupBox2.Controls.Add(this.textBoxDALX);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(151, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 395);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "档案领取交接单";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(44, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(753, 182);
            this.dataGridView1.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "问题表述";
            this.Column2.Items.AddRange(new object[] {
            "缺页",
            "散卷",
            "实体与目录不一致",
            "档案涉密",
            "实体破损",
            "实体残缺"});
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // textBoxNX
            // 
            this.textBoxNX.Enabled = false;
            this.textBoxNX.Location = new System.Drawing.Point(540, 98);
            this.textBoxNX.Name = "textBoxNX";
            this.textBoxNX.Size = new System.Drawing.Size(100, 21);
            this.textBoxNX.TabIndex = 22;
            // 
            // dateTimePickerlLQSJ
            // 
            this.dateTimePickerlLQSJ.Location = new System.Drawing.Point(540, 39);
            this.dateTimePickerlLQSJ.Name = "dateTimePickerlLQSJ";
            this.dateTimePickerlLQSJ.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerlLQSJ.TabIndex = 21;
            // 
            // textBoxDH
            // 
            this.textBoxDH.Enabled = false;
            this.textBoxDH.Location = new System.Drawing.Point(119, 150);
            this.textBoxDH.Name = "textBoxDH";
            this.textBoxDH.Size = new System.Drawing.Size(103, 21);
            this.textBoxDH.TabIndex = 19;
            // 
            // textBoxXMDW
            // 
            this.textBoxXMDW.Enabled = false;
            this.textBoxXMDW.Location = new System.Drawing.Point(119, 42);
            this.textBoxXMDW.Name = "textBoxXMDW";
            this.textBoxXMDW.Size = new System.Drawing.Size(103, 21);
            this.textBoxXMDW.TabIndex = 18;
            // 
            // textBoxLQPCH
            // 
            this.textBoxLQPCH.Enabled = false;
            this.textBoxLQPCH.Location = new System.Drawing.Point(313, 42);
            this.textBoxLQPCH.Name = "textBoxLQPCH";
            this.textBoxLQPCH.Size = new System.Drawing.Size(103, 21);
            this.textBoxLQPCH.TabIndex = 17;
            // 
            // textBoxGDFS
            // 
            this.textBoxGDFS.Enabled = false;
            this.textBoxGDFS.Location = new System.Drawing.Point(313, 98);
            this.textBoxGDFS.Name = "textBoxGDFS";
            this.textBoxGDFS.Size = new System.Drawing.Size(103, 21);
            this.textBoxGDFS.TabIndex = 16;
            // 
            // textBoxDALX
            // 
            this.textBoxDALX.Enabled = false;
            this.textBoxDALX.Location = new System.Drawing.Point(119, 98);
            this.textBoxDALX.Name = "textBoxDALX";
            this.textBoxDALX.Size = new System.Drawing.Size(103, 21);
            this.textBoxDALX.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目单位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "档案类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "年限";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "项目号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "领取时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "领取批次号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "归档方式";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dateTimePickerRQ2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePickerRQ1);
            this.groupBox1.Controls.Add(this.textBoxJGDW);
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(151, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 175);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "双方确认栏";
            // 
            // dateTimePickerRQ2
            // 
            this.dateTimePickerRQ2.Location = new System.Drawing.Point(452, 94);
            this.dateTimePickerRQ2.Name = "dateTimePickerRQ2";
            this.dateTimePickerRQ2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerRQ2.TabIndex = 24;
            // 
            // dateTimePickerRQ1
            // 
            this.dateTimePickerRQ1.Location = new System.Drawing.Point(119, 94);
            this.dateTimePickerRQ1.Name = "dateTimePickerRQ1";
            this.dateTimePickerRQ1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerRQ1.TabIndex = 23;
            this.dateTimePickerRQ1.Value = new System.DateTime(2018, 10, 25, 0, 0, 0, 0);
            // 
            // textBoxJGDW
            // 
            this.textBoxJGDW.Location = new System.Drawing.Point(452, 46);
            this.textBoxJGDW.Name = "textBoxJGDW";
            this.textBoxJGDW.Size = new System.Drawing.Size(160, 21);
            this.textBoxJGDW.TabIndex = 14;
            // 
            // textBox
            // 
            this.textBox.Enabled = false;
            this.textBox.Location = new System.Drawing.Point(119, 46);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(139, 21);
            this.textBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "日期";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "项目单位";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "加工单位";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 17;
            // 
            // Form档案领取交接单
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "Form档案领取交接单";
            this.Text = "Form档案领取交接单";
            this.Load += new System.EventHandler(this.Form档案领取交接单_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNX;
        private System.Windows.Forms.DateTimePicker dateTimePickerlLQSJ;
        private System.Windows.Forms.TextBox textBoxDH;
        private System.Windows.Forms.TextBox textBoxXMDW;
        private System.Windows.Forms.TextBox textBoxLQPCH;
        private System.Windows.Forms.TextBox textBoxGDFS;
        private System.Windows.Forms.TextBox textBoxDALX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerRQ2;
        private System.Windows.Forms.DateTimePicker dateTimePickerRQ1;
        private System.Windows.Forms.TextBox textBoxJGDW;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
    }
}