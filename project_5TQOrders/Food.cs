using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5TQOrders
{
    public class Food
    {
        private string tenmonan;

        public string Tenmonan
        {
            get { return tenmonan; }
            set { tenmonan = value; }
        }
        private float gia;

        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private string time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        private string ghichu;

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }
}
