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
    public partial class Ghichumonan : Form
    {
        Food food;
        ucChose chose;
        public Ghichumonan(Food f,ucChose chose)
        {
            InitializeComponent();
            food = f;
            this.chose = chose;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            food.Ghichu = richTextBox1.Text;
            chose.loadData();
            this.Close();
        }
    }
}
