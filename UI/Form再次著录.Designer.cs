namespace UI
{
    partial class Form再次著录
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp3 = new System.Windows.Forms.DateTimePicker();
            this.btn_scwj = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_wj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.btn_scaj = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_aj = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btn_scxm = new System.Windows.Forms.Button();
            this.btn_xmnext = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_项目 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp3);
            this.groupBox3.Controls.Add(this.btn_scwj);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.btn_wj);
            this.groupBox3.Location = new System.Drawing.Point(34, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1359, 316);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件";
            // 
            // dtp3
            // 
            this.dtp3.Location = new System.Drawing.Point(840, 270);
            this.dtp3.Name = "dtp3";
            this.dtp3.Size = new System.Drawing.Size(94, 21);
            this.dtp3.TabIndex = 6;
            // 
            // btn_scwj
            // 
            this.btn_scwj.Location = new System.Drawing.Point(689, 271);
            this.btn_scwj.Name = "btn_scwj";
            this.btn_scwj.Size = new System.Drawing.Size(75, 23);
            this.btn_scwj.TabIndex = 3;
            this.btn_scwj.Text = "删除";
            this.btn_scwj.UseVisualStyleBackColor = true;
            this.btn_scwj.Click += new System.EventHandler(this.btn_scwj_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.dataGridView3.Location = new System.Drawing.Point(32, 20);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(1272, 236);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView3_CellBeginEdit);
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "选择";
            this.Column3.Name = "Column3";
            // 
            // btn_wj
            // 
            this.btn_wj.Location = new System.Drawing.Point(579, 271);
            this.btn_wj.Name = "btn_wj";
            this.btn_wj.Size = new System.Drawing.Size(75, 23);
            this.btn_wj.TabIndex = 1;
            this.btn_wj.Text = "保存";
            this.btn_wj.UseVisualStyleBackColor = true;
            this.btn_wj.Click += new System.EventHandler(this.btn_wj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp2);
            this.groupBox2.Controls.Add(this.btn_scaj);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btn_aj);
            this.groupBox2.Controls.Add(this.btn_next);
            this.groupBox2.Location = new System.Drawing.Point(625, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 241);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "案卷";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(534, 206);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(94, 21);
            this.dtp2.TabIndex = 6;
            // 
            // btn_scaj
            // 
            this.btn_scaj.Location = new System.Drawing.Point(414, 204);
            this.btn_scaj.Name = "btn_scaj";
            this.btn_scaj.Size = new System.Drawing.Size(75, 23);
            this.btn_scaj.TabIndex = 4;
            this.btn_scaj.Text = "删除";
            this.btn_scaj.UseVisualStyleBackColor = true;
            this.btn_scaj.Click += new System.EventHandler(this.btn_scaj_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(15, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(698, 178);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_CellBeginEdit);
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "选择";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // btn_aj
            // 
            this.btn_aj.Location = new System.Drawing.Point(163, 204);
            this.btn_aj.Name = "btn_aj";
            this.btn_aj.Size = new System.Drawing.Size(75, 23);
            this.btn_aj.TabIndex = 1;
            this.btn_aj.Text = "保存";
            this.btn_aj.UseVisualStyleBackColor = true;
            this.btn_aj.Click += new System.EventHandler(this.btn_aj_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(302, 204);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "下一步";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.btn_scxm);
            this.groupBox1.Controls.Add(this.btn_xmnext);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_项目);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 241);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "项目";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(472, 206);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(94, 21);
            this.dtp1.TabIndex = 6;
            // 
            // btn_scxm
            // 
            this.btn_scxm.Location = new System.Drawing.Point(363, 204);
            this.btn_scxm.Name = "btn_scxm";
            this.btn_scxm.Size = new System.Drawing.Size(75, 23);
            this.btn_scxm.TabIndex = 5;
            this.btn_scxm.Text = "删除";
            this.btn_scxm.UseVisualStyleBackColor = true;
            this.btn_scxm.Click += new System.EventHandler(this.btn_scxm_Click);
            // 
            // btn_xmnext
            // 
            this.btn_xmnext.Location = new System.Drawing.Point(254, 204);
            this.btn_xmnext.Name = "btn_xmnext";
            this.btn_xmnext.Size = new System.Drawing.Size(75, 23);
            this.btn_xmnext.TabIndex = 3;
            this.btn_xmnext.Text = "下一步";
            this.btn_xmnext.UseVisualStyleBackColor = true;
            this.btn_xmnext.Click += new System.EventHandler(this.btn_xmnext_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(17, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(562, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "选择";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // btn_项目
            // 
            this.btn_项目.Location = new System.Drawing.Point(142, 204);
            this.btn_项目.Name = "btn_项目";
            this.btn_项目.Size = new System.Drawing.Size(75, 23);
            this.btn_项目.TabIndex = 2;
            this.btn_项目.Text = "保存";
            this.btn_项目.UseVisualStyleBackColor = true;
            this.btn_项目.Click += new System.EventHandler(this.btn_项目_Click);
            // 
            // Form再次著录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 613);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form再次著录";
            this.Text = "Form再次著录";
            this.Load += new System.EventHandler(this.Form再次著录_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp3;
        private System.Windows.Forms.Button btn_scwj;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.Button btn_wj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Button btn_scaj;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button btn_aj;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button btn_scxm;
        private System.Windows.Forms.Button btn_xmnext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.Button btn_项目;
    }
}