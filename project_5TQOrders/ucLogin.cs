using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_5TQOrders
{
    public partial class ucLogin : UserControl
    {
        bool uFocus = true;
        bool pFocus = false;
        frmMain main;
        public ucLogin(frmMain f)
        {
            InitializeComponent();
            main = f;
        }
        public void ClearAll()
        {
            txtU.Clear();
            txtP.Clear();
        }
        private void ucLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                if (txtU.Focused == true)
                    this.txtU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                else
                    this.txtU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                if (txtP.Focused == true)
                    this.txtP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
                else
                    this.txtP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        }
        private void doinput(string x)
        {
            if(uFocus==true)
            {
                txtU.Focus();
                if (x == "d")
                    txtU.Clear();
                else
                    txtU.Text += x;
            }
            else
            {
                txtP.Focus();
                if (x == "d")
                    txtP.Clear();
                else
                    txtP.Text += x;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtU.Focus();
            uFocus = true;
            pFocus = false;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            txtU.Focus();
            uFocus = true;
            pFocus = false;
        }

        private void txtU_Click(object sender, EventArgs e)
        {
            txtU.Focus();
            uFocus = true;
            pFocus = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtP.Focus();
            uFocus = false;
            pFocus = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            txtP.Focus();
            uFocus = false;
            pFocus = true;
        }

        private void txtP_Click(object sender, EventArgs e)
        {
            txtP.Focus();
            uFocus = false;
            pFocus = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doinput("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doinput("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doinput("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            doinput("6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            doinput("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doinput("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            doinput("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            doinput("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            doinput("9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            doinput("d");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            doinput("0");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            doinput(".");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SQLDataContext db = new SQLDataContext();
            var log = from nd in db.NguoiDungs
                      where nd.username == txtU.Text && nd.pass == txtP.Text
                      select nd;
            if (log.Any())
            {
                main.removeLogin();
                main.showTable();
                String name = log.First().name;
                main.showTop(name);
                main.User = name;
            }
            else
            {
                MessageBox.Show("Lỗi đăng nhập! ID hoặc mật khẩu không chính xác!");
            }
        }

        private void txtU_TextChanged(object sender, EventArgs e)
        {
            if(txtU.Text =="000000"||txtU.Text == "quit")
            {
                main.Close();
            }
        }
    }
}
