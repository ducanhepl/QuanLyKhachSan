using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class MenuTableDAO
    {
        private static MenuTableDAO instance;

        public static MenuTableDAO Instance
        {
            get { if (instance == null) instance = new MenuTableDAO(); return MenuTableDAO.instance; }
            private set { MenuTableDAO.instance = value; }
        }

        private MenuTableDAO() { }

        public List<MenuTable> GetListMenuByTable(int id)
        {
            List<MenuTable> listMenuTable = new List<MenuTable>();

            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuTable menu = new MenuTable(item);
                listMenuTable.Add(menu);
            }

            return listMenuTable;
        }
    }
}

