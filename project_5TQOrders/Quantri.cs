using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace project_5TQOrders
{
    public partial class Quantri : DevExpress.XtraEditors.XtraForm
    {
        public Quantri()
        {
            InitializeComponent();
        }

        private void cấuHìnhHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.QLOrderNhaHangConnectionString);
            
        }
    }
}