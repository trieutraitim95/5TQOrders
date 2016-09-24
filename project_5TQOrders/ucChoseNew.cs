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
    public partial class ucChoseNew : UserControl
    {
        private frmMain main;
        private String num;
        private ucTable uctable;
        public ucChoseNew(frmMain f,ucTable tb, String num)
        {
            InitializeComponent();
            main = f;
            this.num = num;
            this.uctable = tb;
            label1.Text = "BÀN : " + num;
            panel2.Controls.Add(label1);
            panel2.Height = main.scHeight;
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Tahoma",18);
            label1.Location = new Point(10, 10);
            panel2.Width = main.scWidth / 2;
            btnBack.Location = new Point(main.scWidth/2 - btnBack.Width - 10, main.scHeight - btnBack.Height - 10 - panel1.Height);
            label7.Location = new Point((panel2.Width - label7.Width) / 2,label7.Location.Y);
            label8.Location = new Point((main.scWidth -panel2.Width - label8.Width)/2, label7.Location.Y);
            panel4.Location = new Point((panel2.Width - panel4.Width) / 2, panel4.Location.Y);
            txtGiomo.Text = DateTime.Now.ToString("HH:mm:ss");
            txtNhanvien.Text = main.User;
            chiaban();
            btnBack.Location = new Point(panel2.Width - btnBack.Width - 10, main.scHeight - btnBack.Height - 10 - panel1.Height);
            btnOK.Location = new Point(panel2.Width - btnBack.Width*2 - 10, main.scHeight - btnBack.Height - 10 - panel1.Height);
        }
        private void chiaban()
        {
            int w = main.scWidth - panel2.Width;
            int h = main.scHeight - panel2.Height;
            int i = 0;
            int btnw = (w / 4)-10;
            int btnh = 60;
            foreach (Table tb in uctable.LstTable)
            {
                if(i<4)
                {
                    Button btn = new Button();
                    btn.Height = btnh;
                    btn.Width = btnw;
                    btn.Text = tb.Num;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.DarkViolet;
                    btn.ForeColor = Color.White;
                    btn.Location = new Point(10+i * 10+ btnw * i, 200);
                    btn.Click += new System.EventHandler(this.btn_click);
                    panel3.Controls.Add(btn);
                }
                if(i>=4 && i<=7)
                {
                    int j = i - 4;
                    Button btn = new Button();
                    btn.Height = btnh;
                    btn.Width = btnw;
                    btn.Text = tb.Num;
                    btn.Location = new Point(10+j * 10 + btnw *j, 200 + btnh +10);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.DarkViolet;
                    btn.ForeColor = Color.White;
                    btn.Click += new System.EventHandler(this.btn_click);
                    panel3.Controls.Add(btn);
                }
                if (i >= 7 && i <= 11)
                {
                    int j = i - 8;
                    Button btn = new Button();
                    btn.Height = btnh;
                    btn.Width = btnw;
                    btn.Text = tb.Num;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.DarkViolet;
                    btn.ForeColor = Color.White;
                    btn.Location = new Point(10+j * 10 + btnw * j, 200 + btnh * 2 + 20);
                    btn.Click += new System.EventHandler(this.btn_click);
                    panel3.Controls.Add(btn);
                }
                if (i >= 12 && i <= 15)
                {
                    int j = i - 12;
                    Button btn = new Button();
                    btn.Height = btnh;
                    btn.Width = btnw;
                    btn.Text = tb.Num;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.DarkViolet;
                    btn.ForeColor = Color.White;
                    btn.Location = new Point(10+j * 10 + btnw * j, 200 + btnh * 3 + 30);
                    btn.Click += new System.EventHandler(this.btn_click);
                    panel3.Controls.Add(btn);
                }
                i++;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            main.removeChose();
            main.showTable();
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text =="A1")
            {
                changeTable("A1",num);
            }
            if (btn.Text == "A2")
            {
                changeTable("A2", num);
            }
            if (btn.Text == "A3")
            {
                changeTable("A3", num);
            }   
            if (btn.Text == "A4")
            {
                changeTable("A4", num);
            }
            if (btn.Text == "A5")
            {
                changeTable("A5", num);
            }
            if (btn.Text == "A6")
            {
                changeTable("A6", num);
            }
            if (btn.Text == "A7")
            {
                changeTable("A7", num);
            }
            if (btn.Text == "A8")
            {
                changeTable("A8", num);
            }
            if (btn.Text == "A9")
            {
                changeTable("A9", num);
            }
            if (btn.Text == "A10")
            {
                changeTable("A10", num);
            }
            if (btn.Text == "A11")
            {
                changeTable("A11", num);
            }
            if (btn.Text == "A12")
            {
                changeTable("A12", num);
            }
            if (btn.Text == "A13")
            {
                changeTable("A13", num);
            }
            if (btn.Text == "A14")
            {
                changeTable("A14", num);
            }
            if (btn.Text == "A15")
            {
                changeTable("A15", num);
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                uctable.LstTable.Add(new Table(this.num, txtKhachhang.Text, txtGiomo.Text, txtNhanvien.Text,txtSokhach.Value.ToString(),txtSdt.Text));
                main.removeChose();
                main.showTable();
        }
        private void changeTable(String oldNum,String newNum)
        {
            foreach(Table tb in uctable.LstTable)
            {
                if (tb.Num == oldNum) 
                { 
                    tb.Num = newNum;
                    break;
                }               
                
            }
            main.removeChose();
            main.showTable();
        }
    }
}
