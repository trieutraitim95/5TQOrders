using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_5TQOrders
{
    public partial class frmMain : Form
    {
        public int scWidth = SystemInformation.VirtualScreen.Width;
        public int scHeight = SystemInformation.VirtualScreen.Height;
        private ucLogin _login;
        private ucTable _table;
        private ucChose ucchose;
        private ucChoseNew ucchosenew;
        private Button btnLogout;
        private Button btnSystem;
        private Button btnAbout;
        private Panel pl;
        private String user;

        public String User
        {
            get { return user; }
            set { user = value; }
        }
        public frmMain()
        {
            InitializeComponent();
            _login = new ucLogin(this);
            _table = new ucTable(this);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            showLogin();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        public void showLogin()
        {
            Controls.Add(_login);
            _login.Location = new Point(((scWidth - _login.Size.Width) / 2), ((scHeight - _login.Size.Height) / 2));
            _login.ClearAll();
           
        }
        public void removeLogin()
        {
            Controls.Remove(_login);
        }
        public void showTable()
        {
            Controls.Add(_table);
            _table.Location = new Point(((scWidth - _table.Size.Width) / 2), ((scHeight - _table.Size.Height) / 2));
            this.btnLogout = new Button();
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.BackColor = Color.Red;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Width = 200;
            this.btnLogout.Height = 60;
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Location = new Point(scWidth - this.btnLogout.Width - 10, scHeight - this.btnLogout.Height - 10);
            this.btnSystem = new Button();
            this.btnSystem.Text = "Hệ thống";
            this.btnSystem.BackColor = Color.DarkViolet;
            this.btnSystem.FlatStyle = FlatStyle.Flat;
            this.btnSystem.Width = 200;
            this.btnSystem.Height = 60;
            this.btnSystem.ForeColor = Color.White;
            this.btnSystem.Location = new Point(scWidth - this.btnSystem.Width -10 - this.btnLogout.Width - 10, scHeight - this.btnSystem.Height - 10);
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_click);
            this.btnAbout = new Button();
            this.btnAbout.Text = "Giới thiệu";
            this.btnAbout.BackColor = Color.Green;
            this.btnAbout.FlatStyle = FlatStyle.Flat;
            this.btnAbout.Width = 200;
            this.btnAbout.Height = 60;
            this.btnAbout.ForeColor = Color.White;
            this.btnAbout.Location = new Point(scWidth - this.btnAbout.Width - 10 - this.btnLogout.Width - 10 -10 -this.btnSystem.Width, scHeight - this.btnAbout.Height - 10);
            this.btnLogout.Click += new System.EventHandler(this.logout);
            Controls.Add(this.btnLogout);
            Controls.Add(this.btnSystem);
            Controls.Add(this.btnAbout);
        }
        public void removeTable()
        {
            Controls.Remove(_table);
            Controls.Remove(this.btnLogout);
            Controls.Remove(this.btnSystem);
            Controls.Remove(this.btnAbout);
        }
        public void showTop(string user)
        {
            pl = new Panel();
            Controls.Add(pl);
            pl.Dock = DockStyle.Top;
            pl.BackColor = Color.BlueViolet;
            pl.Height = 70;
            Label lb = new Label();
            lb.Text = "Nhân viên order:  " + user;
            lb.Height = 25;
            lb.Width = 450;
            lb.Font = new Font("Arial",18F);
            pl.Controls.Add(lb);
            lb.ForeColor = Color.White;
            lb.Location = new Point(((scWidth - lb.Width) / 2), ((pl.Height - lb.Height) / 2));
            pl.Controls.Add(lblTime);
            lblTime.ForeColor = Color.White;
        }
        public void removeTop()
        {
            Controls.Remove(pl);
        }
        public void logout(object sender, EventArgs e)
        {
            showLogin();
            removeTable();
            removeTop();
            lblTime.ForeColor = Color.Black;
            Controls.Add(lblTime);
        }
        public void btnSystem_click(object sender, EventArgs e)
        {
            Quantri f = new Quantri();
            f.Show();
        }
        public void showChose(String num)
        {
            if (_table.checktb(num) == true)
            {
                ucchose = new ucChose(this, _table, _table.getTable(num));
                this.removeTable();
                this.Controls.Add(ucchose);
                ucchose.Width = scWidth;
                ucchose.Height = scHeight;
            }
            else
            {
                ucchosenew = new ucChoseNew(this,_table, num);
                ucchosenew.Width = scWidth;
                ucchosenew.Height = scHeight;
                this.removeTable();
                this.Controls.Add(ucchosenew);
            }
        }
        public void removeChose()
        {
            Controls.Remove(ucchose);
            Controls.Remove(ucchosenew);
        }
        
    }
}
