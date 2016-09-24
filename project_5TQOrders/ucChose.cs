using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project_5TQOrders
{
    public partial class ucChose : UserControl
    {
        frmMain main;
        Table tb;
        ucTable uctable;
        List<Button> btnMa = new List<Button>();
        bool isloaddanhmuc = false;
        public ucChose(frmMain f,ucTable uctb,Table tb)
        {
            InitializeComponent();
            this.main = f;
            this.tb = tb;
            this.uctable = uctb;
            panel1.Width = btnBack.Width * 2 + 20;
            btnBack.Location = new Point(panel1.Width - btnBack.Width - 10, main.scHeight - btnBack.Height - 10);
            panel2.Height = main.scHeight / 2;          
            panel4.Dock = DockStyle.Fill;
            lvMonAn.Width = main.scWidth - panel1.Width;
            lvMonAn.Location = new Point(0, 65);
            lvMonAn.Height = main.scHeight - panel2.Height - 65;
            int partwidth = lvMonAn.Width / 100;
            this.columnHeader1.Width = partwidth * 45;
            this.columnHeader2.Width = partwidth * 5;
            this.columnHeader3.Width = partwidth * 15;
            this.columnHeader4.Width = partwidth * 15;
            this.columnHeader5.Width = partwidth * 30; 
            timer1.Start();
            for (int i = 0; i < 20; i++) btnMa.Add(new Button());
            createButton();
            loaddanhmuc();
            loadData();
            btnGhichu.Location = new Point(10, btnBack.Location.Y - 60 - 2);
            btnXoamon.Location = new Point(btnBack.Location.X, btnBack.Location.Y - 60 - 2);
            btnGopban.Location = new Point(btnBack.Location.X, btnBack.Location.Y - 120 - 4);
            btnThanhtoan.Location = new Point(btnBack.Location.X, btnBack.Location.Y-180-6);
            btnXoaorder.Location = new Point(10, btnBack.Location.Y-120 - 4);
            btnDoithongtin.Location = new Point(10, btnBack.Location.Y - 180 - 6);
            btnCapnhat.Location = new Point(10, btnBack.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.removeChose();
            main.showTable();
            tb.LstGoimon.Clear();
        }

        private void ucChose_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Parse(tb.Time);
            String timeUse = (DateTime.Now - time).Hours+":"+(DateTime.Now - time).Minutes+":"+(DateTime.Now - time).Seconds;
            label1.Text = "Bàn : " + tb.Num + "\nKhách hàng : " + tb.Khachhang + "\nSố khách : " + tb.Soluong + "\nThời gian mở : " + tb.Time + "\nThời gian sử dụng : " + timeUse + "\nPhí : " + tb.tinhtien();
        }
        public void loadData()
        {
            lvMonAn.Items.Clear();
           foreach(Food ma in tb.LstMonan)
           {
               ListViewItem item = new ListViewItem(ma.Tenmonan);
               item.SubItems.Add(ma.Soluong.ToString());
               item.SubItems.Add(ma.Gia.ToString());
               item.SubItems.Add(ma.Time);
               item.SubItems.Add(ma.Ghichu);
               lvMonAn.Items.Add(item);
           }
           foreach (Food ma in tb.LstGoimon)
           {
               ListViewItem item = new ListViewItem(ma.Tenmonan);
               item.SubItems.Add(ma.Soluong.ToString());
               item.SubItems.Add(ma.Gia.ToString());
               item.SubItems.Add(ma.Time);
               item.SubItems.Add(ma.Ghichu);
               item.ForeColor = Color.Red;
               lvMonAn.Items.Add(item);
           }
        }
        
        private void createButton()
        {
            int w = main.scWidth - panel1.Width -10;
            int h = panel2.Height;
            int i = 0;
            int btnw = (w / 5) - 5;
            int btnh = (h / 4) - 5;
            foreach (Button btn in btnMa)
            {
                btn.Visible = false;
                btn.Click += new System.EventHandler(this.btnDanhmuc_click);
                if (i < 5)
                {
                    btn.Height = btnh;
                    btn.Width = btnw;
                    btn.Text = null;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = Color.White;
                    btn.Location = new Point(5 + i * 5 + btnw * i, 5);
                    panel2.Controls.Add(btn);
                }
                if (i >= 5&&i<10)
                {
                    int j = i - 5;
                    btn.Height = btnh;
                    btn.Width = btnw;
                    btn.Text = null;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = Color.White;
                    btn.Location = new Point(5 + j * 5 + btnw * j, btn.Height+10);
                    panel2.Controls.Add(btn);
                }
                if (i >= 10 && i < 15)
                {
                    int j = i -10;
                    btn.Height = btnh;
                    btn.Width = btnw;
                    btn.Text = null;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = Color.White;
                    btn.Location = new Point(5 + j * 5 + btnw * j, btn.Height*2 +15);
                    panel2.Controls.Add(btn);
                }
                if (i >= 15 && i < 19)
                {
                    int j = i - 15;
                    btn.Height = btnh;
                    btn.Width = btnw;
                    btn.Text = null;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = Color.White;
                    btn.Location = new Point(5 + j * 5 + btnw * j, btn.Height*3 + 20);
                    panel2.Controls.Add(btn);
                }
                if(i==19)
                {
                    int j = i - 15;
                    btn.Height = btnh;
                    btn.Width = btnw;
                    btn.Text = "Trở lại";
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.Location = new Point(5 + j * 5 + btnw * j, btn.Height * 3 + 20);
                    btn.Visible = true;
                    btn.Font = new Font("Tahoma",20);
                    panel2.Controls.Add(btn);
                }
                i++;
            }
           
        }
        private void loaddanhmuc()
        {
            isloaddanhmuc = true;
            setNullAllButton();
            SQLDataContext db = new SQLDataContext();
            var arr = from list in db.LoaiMonAns
                      select list.LoaiMonAn1;
            int i =0;
            foreach(Button btn in btnMa)
            {
                
                if(i<arr.ToList().Count)
                {
                    if(btn != btnMa.Last())
                    {
                        btn.Click += new System.EventHandler(this.btnDanhmuc_click);
                        btn.Text = arr.ToList().ElementAt(i).ToString();
                        btn.BackColor = Color.DarkBlue;
                        btn.ForeColor = Color.White;
                        btn.Visible = true;
                    }
                }
                i++;
            }
        }
      
        private void loadmonan(string tendanhmuc)
        {
            setNullAllButton();
            SQLDataContext db = new SQLDataContext();
            var lma = db.LoaiMonAns.FirstOrDefault(m => m.LoaiMonAn1.ToLower().Equals(tendanhmuc)).Id;
            var arr = db.MonAns.Where(n=> n.MaLoaiMonAn == lma).Select(n=>n.TenMonAn);
            int i = 0;
            foreach (Button btn in btnMa)
            {

                if (i < arr.ToList().Count)
                {
                    if(btn != btnMa.Last())
                    {
                        btn.Click += new System.EventHandler(this.goiMon);
                        btn.Text = arr.ToList().ElementAt(i).ToString();
                        btn.BackColor = Color.DarkBlue;
                        btn.ForeColor = Color.White;
                        btn.Visible = true;
                    }
                }
                i++;
            }
        }
        string m = "";
        public void goiMon(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            SQLDataContext db = new SQLDataContext();
            if(btn.Text.Equals(m))
            {
                tb.LstGoimon.Last().Soluong += 1;
            }
            else
            {
                m = btn.Text;
                Food food = new Food();
                food.Tenmonan = m;
                food.Soluong = 1;
                food.Time = DateTime.Now.ToString("HH:mm:ss");
                var gia = db.MonAns.First(n => n.TenMonAn.ToLower().Equals(m.ToLower())).Gia;
                food.Gia = gia;
                tb.LstGoimon.Add(food);
            }
            loadData();
            
        }
        public void setNullAllButton()
        {
            foreach (Button btn in btnMa)
            {
                if(btn != btnMa.Last())
                {
                    btn.Text = null;
                    btn.Visible = false;
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = Color.White;
                    btn.Click -= new System.EventHandler(this.btnDanhmuc_click);
                    btn.Click -= new System.EventHandler(this.goiMon);
                }
            }
        }
        private void btnDanhmuc_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text.ToString().Equals("Trở lại")==false)
            {
                loadmonan(btn.Text);
                isloaddanhmuc = false;
            }
            else
            {
                if(isloaddanhmuc == false)
                loaddanhmuc();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            foreach (Food ma in tb.LstGoimon)
                tb.LstMonan.Add(ma);
            tb.LstGoimon.Clear();
            loadData();
            
        }

        private void btnXoaorder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa order bàn này?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tb.LstMonan.Clear();
                loadData();
            }
            
        }

        private void btnXoamon_Click(object sender, EventArgs e)
        {
            if(lvMonAn.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này khỏi order?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lvMonAn.SelectedItems)
                    {
                        if (item.ForeColor != Color.Red)
                            tb.LstMonan.RemoveAt(item.Index);
                        else
                            tb.LstGoimon.RemoveAt(item.Index - tb.LstMonan.Count);
                    }
                    loadData();
                }
            }
                
        }

        private void btnDoithongtin_Click(object sender, EventArgs e)
        {
            new EditInfoTable(tb).Show();
        }

        private void btnGhichu_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMonAn.SelectedItems)
            {
                if (item.ForeColor != Color.Red)
                    new Ghichumonan(tb.LstMonan.ElementAt(item.Index),this).Show();
                else
                    new Ghichumonan(tb.LstGoimon.ElementAt(item.Index - tb.LstMonan.Count),this).Show();
            }
            
        }

        private void btnGopban_Click(object sender, EventArgs e)
        {
            new Gopban(uctable,tb,main).Show();
        }
       private void MakeTable(DataTable dt,String[] columns)
        {
            for(int i =0;i<columns.Count();i++)
            {
                DataColumn col = new DataColumn(columns[i],System.Type.GetType("System.Interger"));
                dt.Columns.Add(col);
            }
        }
        WebBrowser wbr = new WebBrowser();
        DataSet ds = new DataSet();
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thanh toán bàn này?", "Cảnh báo", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                new Hoadon(tb).Show();
                main.removeChose();
                main.showTable();
                uctable.LstTable.Remove(tb);
            }
        }
    }
}
