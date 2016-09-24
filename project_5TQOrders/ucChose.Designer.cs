namespace project_5TQOrders
{
    partial class ucChose
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "test",
            "1",
            "2",
            "3",
            "4"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGopban = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnDoithongtin = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoamon = new System.Windows.Forms.Button();
            this.btnXoaorder = new System.Windows.Forms.Button();
            this.btnGhichu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvMonAn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(185, 542);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(180, 60);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnGopban);
            this.panel1.Controls.Add(this.btnThanhtoan);
            this.panel1.Controls.Add(this.btnDoithongtin);
            this.panel1.Controls.Add(this.btnCapnhat);
            this.panel1.Controls.Add(this.btnXoamon);
            this.panel1.Controls.Add(this.btnXoaorder);
            this.panel1.Controls.Add(this.btnGhichu);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(563, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 602);
            this.panel1.TabIndex = 2;
            // 
            // btnGopban
            // 
            this.btnGopban.Location = new System.Drawing.Point(185, 410);
            this.btnGopban.Name = "btnGopban";
            this.btnGopban.Size = new System.Drawing.Size(180, 60);
            this.btnGopban.TabIndex = 2;
            this.btnGopban.Text = "Gộp bàn";
            this.btnGopban.UseVisualStyleBackColor = true;
            this.btnGopban.Click += new System.EventHandler(this.btnGopban_Click);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(185, 344);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(180, 60);
            this.btnThanhtoan.TabIndex = 2;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // btnDoithongtin
            // 
            this.btnDoithongtin.Location = new System.Drawing.Point(4, 344);
            this.btnDoithongtin.Name = "btnDoithongtin";
            this.btnDoithongtin.Size = new System.Drawing.Size(180, 60);
            this.btnDoithongtin.TabIndex = 2;
            this.btnDoithongtin.Text = "Thay đổi thông tin";
            this.btnDoithongtin.UseVisualStyleBackColor = true;
            this.btnDoithongtin.Click += new System.EventHandler(this.btnDoithongtin_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.Green;
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapnhat.ForeColor = System.Drawing.Color.White;
            this.btnCapnhat.Location = new System.Drawing.Point(3, 410);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(180, 60);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoamon
            // 
            this.btnXoamon.Location = new System.Drawing.Point(185, 476);
            this.btnXoamon.Name = "btnXoamon";
            this.btnXoamon.Size = new System.Drawing.Size(180, 60);
            this.btnXoamon.TabIndex = 2;
            this.btnXoamon.Text = "Xóa món";
            this.btnXoamon.UseVisualStyleBackColor = true;
            this.btnXoamon.Click += new System.EventHandler(this.btnXoamon_Click);
            // 
            // btnXoaorder
            // 
            this.btnXoaorder.Location = new System.Drawing.Point(3, 476);
            this.btnXoaorder.Name = "btnXoaorder";
            this.btnXoaorder.Size = new System.Drawing.Size(180, 60);
            this.btnXoaorder.TabIndex = 2;
            this.btnXoaorder.Text = "Xóa rỗng Order";
            this.btnXoaorder.UseVisualStyleBackColor = true;
            this.btnXoaorder.Click += new System.EventHandler(this.btnXoaorder_Click);
            // 
            // btnGhichu
            // 
            this.btnGhichu.Location = new System.Drawing.Point(4, 542);
            this.btnGhichu.Name = "btnGhichu";
            this.btnGhichu.Size = new System.Drawing.Size(180, 60);
            this.btnGhichu.TabIndex = 2;
            this.btnGhichu.Text = "Ghi chú";
            this.btnGhichu.UseVisualStyleBackColor = true;
            this.btnGhichu.Click += new System.EventHandler(this.btnGhichu_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 304);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Peru;
            this.panel4.Controls.Add(this.lvMonAn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 298);
            this.panel4.TabIndex = 5;
            // 
            // lvMonAn
            // 
            this.lvMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMonAn.FullRowSelect = true;
            this.lvMonAn.GridLines = true;
            this.lvMonAn.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMonAn.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvMonAn.Location = new System.Drawing.Point(0, 0);
            this.lvMonAn.MultiSelect = false;
            this.lvMonAn.Name = "lvMonAn";
            this.lvMonAn.Size = new System.Drawing.Size(563, 298);
            this.lvMonAn.TabIndex = 0;
            this.lvMonAn.UseCompatibleStateImageBehavior = false;
            this.lvMonAn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "X";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thời gian gọi";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ghi chú";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucChose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucChose";
            this.Size = new System.Drawing.Size(931, 602);
            this.Load += new System.EventHandler(this.ucChose_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lvMonAn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnGopban;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoamon;
        private System.Windows.Forms.Button btnXoaorder;
        private System.Windows.Forms.Button btnGhichu;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnDoithongtin;
    }
}
