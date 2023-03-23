using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int FoodID, int serviceID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.ServiceID = serviceID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.FoodID = (int)row["idFood"];
            this.ServiceID = (int)row["idService"];
            this.Count = (int)row["count"];
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int serviceID;
        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        private int foodID;
        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }


        private int billID;
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
