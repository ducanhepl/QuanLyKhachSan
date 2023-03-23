using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;

        public static ServiceDAO Instance
        {
            get { if (instance == null) instance = new ServiceDAO(); return ServiceDAO.instance; }
            private set { ServiceDAO.instance = value; }
        }

        private ServiceDAO() { }

        public List<Service> GetListService()
        {
            List<Service> list = new List<Service>();

            string query = "select * from xService";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                list.Add(service);
            }

            return list;
        }
    }
}