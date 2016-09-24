using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_5TQOrders
{
    public partial class Gopban : Form
    {
        ucTable uctable;
        Table tb;
        frmMain main;
        public Gopban(ucTable uctb,Table tb,frmMain f)
        {
            uctable = uctb;
            main = f;
            this.tb = tb;
            InitializeComponent();
            chiaban();
        }

        private void Gopban_Load(object sender, EventArgs e)
        {

        }
        private void chiaban()
        {
            int w = this.Width;
            int h = this.Height;
            int i = 0;
            int btnw = (w / 4) - 10;
            int btnh = 60;
            foreach (Table tb in uctable.LstTable)
            {
                if(this.tb.Num.Equals(tb.Num))
                {
                    continue;
                }
                else
                {
                    if (i < 4)
                    {
                        Button btn = new Button();
                        btn.Height = btnh;
                        btn.Width = btnw;
                        btn.Text = tb.Num;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.DarkViolet;
                        btn.ForeColor = Color.White;
                        btn.Location = new Point(10 + i * 10 + btnw * i, 10);
                        btn.Click += new System.EventHandler(this.btnlick);
                        this.Controls.Add(btn);
                    }
                    if (i >= 4 && i <= 7)
                    {
                        int j = i - 4;
                        Button btn = new Button();
                        btn.Height = btnh;
                        btn.Width = btnw;
                        btn.Text = tb.Num;
                        btn.Location = new Point(10 + j * 10 + btnw * j, 10 + btnh + 10);
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.DarkViolet;
                        btn.ForeColor = Color.White;
                        btn.Click += new System.EventHandler(this.btnlick);
                        this.Controls.Add(btn);
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
                        btn.Location = new Point(10 + j * 10 + btnw * j, 10 + btnh * 2 + 20);
                        btn.Click += new System.EventHandler(this.btnlick);
                        this.Controls.Add(btn);
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
                        btn.Click += new System.EventHandler(this.btnlick);
                        btn.Location = new Point(10 + j * 10 + btnw * j, 10 + btnh * 3 + 30);
                        this.Controls.Add(btn);
                    }
                    i++;
                }
            }
        }
        private void gopban(Table tb,String num)
        {
            foreach(Table table in uctable.LstTable)
            {
                if(table.Num==num)
                {
                    foreach(Food ma in tb.LstMonan)
                    {
                        table.LstMonan.Add(ma);
                    }
                    int soluong = int.Parse(table.Soluong) + int.Parse(tb.Soluong);
                    table.Soluong = soluong.ToString();
                    uctable.LstTable.Remove(tb);
                    break;
                }
            }
        }
        private void btnlick(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            gopban(tb, btn.Text);
            main.removeChose();
            main.showTable();
            this.Close();
        }
    }
}
