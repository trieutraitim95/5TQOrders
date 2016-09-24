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
    public partial class Hoadon : Form
    {
        Table tb;
        int tong;
        public Hoadon(Table tb)
        {
            this.tb = tb;
            InitializeComponent();
            int h = 0;
            int i=1;
            if(tb.LstMonan.Count>2)
            {
                for (int j = 0; j < tb.LstMonan.Count;j++)
                {
                    for(int z =i+1;z<tb.LstMonan.Count;z++)
                    {
                        if(tb.LstMonan.ElementAt(j).Tenmonan == tb.LstMonan.ElementAt(z).Tenmonan)
                        {
                            tb.LstMonan.ElementAt(j).Soluong += tb.LstMonan.ElementAt(z).Soluong;
                            tb.LstMonan.Remove(tb.LstMonan.ElementAt(z));
                        }
                    }
                }
            }
                foreach (Food ma in tb.LstMonan)
                {
                    h += 25;
                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(ma.Tenmonan);
                    item.SubItems.Add(ma.Soluong.ToString());
                    item.SubItems.Add(ma.Gia.ToString());
                    item.SubItems.Add((int)ma.Soluong * (int)ma.Gia + "");
                    listView1.Items.Add(item);
                    i++;
                }
            listView1.Height += h;
            this.Height += h;
            txtKhachhang.Text = tb.Khachhang;
            txtSokhach.Text = tb.Soluong;
            txtGiovao.Text = tb.Time;
            txtNgay.Text = tb.Date;
            label9.Text += " "+tb.tinhtien();
            label8.Text += " " + int.Parse(tb.tinhtien()) * 10 / 100 + "";
            tong = int.Parse(tb.tinhtien()) + int.Parse(tb.tinhtien()) * 10 / 100;
            label7.Text += " " + tong + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            KhachHang kh = new KhachHang();
            kh.Tenkhachhang = tb.Khachhang;
            kh.SoDienThoai = tb.Sdt;
            kh.Tongsotien = tong;
            SQLDataContext db = new SQLDataContext();
            db.KhachHangs.InsertOnSubmit(kh);
            db.SubmitChanges();
        }
        
    }
}
