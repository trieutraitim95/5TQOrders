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
    public partial class EditInfoTable : Form
    {
        Table tb;
        public EditInfoTable(Table tb)
        {
            InitializeComponent();
            this.tb = tb;
        }

        private void EditInfoTable_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Bàn " + tb.Num;
            txtTenkhach.Text = tb.Khachhang;
            txtSodienthoai.Text = tb.Sdt;
            txtSokhach.Value = int.Parse(tb.Soluong);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb.Soluong = txtSokhach.Value.ToString();
            tb.Sdt = txtSodienthoai.Text;
            tb.Khachhang = txtTenkhach.Text;
            this.Close();
        }

    }
}
