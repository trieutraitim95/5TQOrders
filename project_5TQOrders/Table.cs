using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5TQOrders
{
    public class Table
    {
        public Table(string num)
        {
            this.Num = num;
        }
        public Table(string num, string kh, string time, string nv, string sl,string sdt)
        {
            this.Num = num;
            this.Khachhang = kh;
            this.time = time;
            this.Nv = nv;
            this.soluong = sl;
            this.sdt = sdt;
            this.date = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string soluong;

        public string Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private String num;

        public String Num
        {
            get { return num; }
            set { num = value; }
        }
        private String time;

        public String Time
        {
            get { return time; }
            set { time = value; }
        }
        private String date;

        public String Date
        {
            get { return date; }
            set { date = value; }
        }
        private String nv;

        public String Nv
        {
            get { return nv; }
            set { nv = value; }
        }
        private List<Food> lstMonan = new List<Food>();

        internal List<Food> LstMonan
        {
            get { return lstMonan; }
            set { lstMonan = value; }
        }
        private List<Food> lstGoimon = new List<Food>();

        internal List<Food> LstGoimon
        {
            get { return lstGoimon; }
            set { lstGoimon = value; }
        }

        private String khachhang;

        public String Khachhang
        {
            get { return khachhang; }
            set { khachhang = value; }
        }
        public String tinhtien()
        {
            float tongtien = 0;
            foreach (Food ma in LstMonan)
            {
                tongtien += ma.Gia*ma.Soluong;
            }
            return tongtien.ToString();
        }
    }
}
