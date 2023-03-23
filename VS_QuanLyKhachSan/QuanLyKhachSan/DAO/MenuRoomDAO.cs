using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class MenuRoomDAO
    {
        private static MenuRoomDAO instance;

        public static MenuRoomDAO Instance
        {
            get { if (instance == null) instance = new MenuRoomDAO(); return MenuRoomDAO.instance; }
            private set { MenuRoomDAO.instance = value; }
        }

        private MenuRoomDAO() { }

        public List<MenuRoom> GetListMenuByRoom(int id)
        {
            List<MenuRoom> listMenu = new List<MenuRoom>();

            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.xService AS f WHERE bi.idBill = b.id AND bi.idService = f.id AND b.status = 0 AND b.idRoom = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuRoom menu = new MenuRoom(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}