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
    public partial class ucTable : UserControl
    {
        private List<Table> lstTable = new List<Table>();
        public List<Table> LstTable
        {
            get { return lstTable; }
            set { lstTable = value; }
        }
        frmMain main;
        public bool checktb(String num)
        {
            foreach(Table tb in lstTable)
            {
                if (tb.Num == num) return true;
            }
            return false;
        }
        public ucTable(frmMain f)
        {
            main = f;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Table tb in lstTable)
            {
                showTb(tb);
            }
            if (checktb("A1") == false)
            {
                btnA1.Text = "A1";
                btnA1.Image = Properties.Resources.table;
                btnA1.ForeColor = Color.White;
            }
            if (checktb("A2") == false)
            {
                btnA2.Text = "A2";
                btnA2.Image = Properties.Resources.table;
                btnA2.ForeColor = Color.White;
            }
            if (checktb("A3") == false)
            {
                btnA3.Text = "A3";
                btnA3.Image = Properties.Resources.table;
                btnA3.ForeColor = Color.White;
            }
            if (checktb("A4") == false)
            {
                btnA4.Text = "A4";
                btnA4.Image = Properties.Resources.table;
                btnA4.ForeColor = Color.White;
            }
            if (checktb("A5") == false)
            {
                btnA5.Text = "A5";
                btnA5.Image = Properties.Resources.table;
                btnA5.ForeColor = Color.White;
            }
            if (checktb("A6") == false)
            {
                btnA6.Text = "A6";
                btnA6.Image = Properties.Resources.table;
                btnA6.ForeColor = Color.White;
            }
            if (checktb("A7") == false)
            {
                btnA7.Text = "A7";
                btnA7.Image = Properties.Resources.table;
                btnA7.ForeColor = Color.White;
            }
            if (checktb("A8") == false)
            {
                btnA8.Text = "A8";
                btnA8.Image = Properties.Resources.table;
                btnA8.ForeColor = Color.White;
            }
            if (checktb("A9") == false)
            {
                btnA9.Text = "A9";
                btnA9.Image = Properties.Resources.table;
                btnA9.ForeColor = Color.White;
            }
            if (checktb("A10") == false)
            {
                btnA10.Text = "A10";
                btnA10.Image = Properties.Resources.table;
                btnA10.ForeColor = Color.White;
            }
            if (checktb("A11") == false)
            {
                btnA11.Text = "A11";
                btnA11.Image = Properties.Resources.table;
                btnA11.ForeColor = Color.White;
            }
            if (checktb("A12") == false)
            {
                btnA12.Text = "A12";
                btnA12.Image = Properties.Resources.table;
                btnA12.ForeColor = Color.White;
            }
            if (checktb("A13") == false)
            {
                btnA13.Text = "A13";
                btnA13.Image = Properties.Resources.table;
                btnA13.ForeColor = Color.White;
            }
            if (checktb("A14") == false)
            {
                btnA14.Text = "A14";
                btnA14.Image = Properties.Resources.table;
                btnA14.ForeColor = Color.White;
            }
            if (checktb("A15") == false)
            {
                btnA15.Text = "A15";
                btnA15.Image = Properties.Resources.table;
                btnA15.ForeColor = Color.White;
            }
        }
        public void showTb(Table tb)
        {
            
            if(tb.Num == "A1")
            {
                btnA1.Text = "A1" +System.Environment.NewLine + tb.tinhtien() +System.Environment.NewLine + tb.Time;
                btnA1.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA1.ForeColor = Color.Black;
            }
            if (tb.Num == "A2")
            {
                btnA2.Text = "A2" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA2.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA2.ForeColor = Color.Black;
            }
            if (tb.Num == "A3")
            {
                btnA3.Text = "A3" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA3.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA3.ForeColor = Color.Black;
            }
            if (tb.Num == "A4")
            {
                btnA4.Text = "A4" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA4.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA4.ForeColor = Color.Black;
            }
            if (tb.Num == "A5")
            {
                btnA5.Text = "A5" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA5.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA5.ForeColor = Color.Black;
            }
            if (tb.Num == "A6")
            {
                btnA6.Text = "A6" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA6.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA6.ForeColor = Color.Black;
            }
            if (tb.Num == "A7")
            {
                btnA7.Text = "A7" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA7.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA7.ForeColor = Color.Black;
            }
            if (tb.Num == "A8")
            {
                btnA8.Text = "A8" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA8.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA8.ForeColor = Color.Black;
            }
            if (tb.Num == "A9")
            {
                btnA9.Text = "A9" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA9.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA9.ForeColor = Color.Black;
            }
            if (tb.Num == "A10")
            {
                btnA10.Text = "A10" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA10.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA10.ForeColor = Color.Black;
            }
            if (tb.Num == "A11")
            {
                btnA11.Text = "A11" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA11.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA11.ForeColor = Color.Black;
            }
            if (tb.Num == "A12")
            {
                btnA12.Text = "A12" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA12.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA12.ForeColor = Color.Black;
            }
            if (tb.Num == "A13")
            {
                btnA13.Text = "A13" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA13.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA13.ForeColor = Color.Black;
            }
            if (tb.Num == "A14")
            {
                btnA14.Text = "A14" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA14.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA14.ForeColor = Color.Black;
            }
            if (tb.Num == "A15")
            {
                btnA15.Text = "A15" + System.Environment.NewLine + tb.tinhtien() + System.Environment.NewLine + tb.Time;
                btnA15.Image = project_5TQOrders.Properties.Resources.tableOpen;
                btnA15.ForeColor = Color.Black;
            }
        }
        public Table getTable(String num)
        {
            foreach (Table tb in lstTable)
            {
                if (tb.Num == num) return tb;
            }
            return null;
        }
        private void ucTable_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            main.showChose("A1");
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            main.showChose("A2");
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            main.showChose("A3");
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            main.showChose("A4");
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            main.showChose("A5");
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            main.showChose("A6");
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            main.showChose("A7");
        }

        private void btnA8_Click(object sender, EventArgs e)
        {
            main.showChose("A8");
        }

        private void btnA9_Click(object sender, EventArgs e)
        {
            main.showChose("A9");
        }

        private void btnA10_Click(object sender, EventArgs e)
        {
            main.showChose("A10");
        }

        private void btnA11_Click(object sender, EventArgs e)
        {
            main.showChose("A11");
        }

        private void btnA12_Click(object sender, EventArgs e)
        {
            main.showChose("A12");
        }

        private void btnA13_Click(object sender, EventArgs e)
        {
            main.showChose("A13");
        }

        private void btnA14_Click(object sender, EventArgs e)
        {
            main.showChose("A14");
        }

        private void btnA15_Click(object sender, EventArgs e)
        {
            main.showChose("A15");
        }
        
    }
}
