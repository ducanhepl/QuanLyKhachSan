using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Service
    {
        public Service(int id, string name, float price)
        {
            this.ID = id;
            this.Name = name;
            
            this.Price = price;
        }

        public Service(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

      

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
