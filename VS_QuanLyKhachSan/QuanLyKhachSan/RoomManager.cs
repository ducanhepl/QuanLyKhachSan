using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyKhachSan
{
    public partial class RoomManager : Form
    {
        public RoomManager()
        {
            InitializeComponent();
            LoadRoom();
            LoadService();
        }

        #region Method

        void LoadService()
        {
            List<Service> listService = ServiceDAO.Instance.GetListService();
            cbService.DataSource = listService;
            cbService.DisplayMember = "Name";
        }

        void LoadRoom()
        {
            flpRoom.Controls.Clear();
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();

            foreach (Room item in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.PaleTurquoise;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpRoom.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lsvBillRoom.Items.Clear();
            List<MenuRoom> listBillInfo = MenuRoomDAO.Instance.GetListMenuByRoom(id);
            float totalPrice = 0;
            foreach (MenuRoom item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.ServiceName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBillRoom.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPriceRoom.Text = totalPrice.ToString("c", culture);
        }
        #endregion

        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int roomID = ((sender as Button).Tag as Room).ID;
            lsvBillRoom.Tag = (sender as Button).Tag;
        

            ShowBill(roomID);
        }
        #endregion 

        private void btnCheckOutService_Click(object sender, EventArgs e)
        {
            Room room = lsvBillRoom.Tag as Room;

            int idBill = BillDAO.Instance.GetUncheckBillIDByRoomID(room.ID);
            double totalPrice = Convert.ToDouble(txbTotalPriceRoom.Text.Split(',')[0]);

            if (idBill != -1)
            {
                if (MessageBox.Show("Hoàn tất thanh toán hóa đơn cho " + room.Name, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, (float)totalPrice);
                    ShowBill(room.ID);

                    LoadRoom();
                }
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            Room room = lsvBillRoom.Tag as Room;

            int idBill = BillDAO.Instance.GetUncheckBillIDByRoomID(room.ID);
            int serviceID = (cbService.SelectedItem as Service).ID;
            int count = (int)nmServiceCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBillRoom(room.ID);
                BillInfoDAO.Instance.InsertBillInfoRoom(BillDAO.Instance.GetMaxIDBill(), serviceID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfoRoom(idBill, serviceID, count);
            }

            ShowBill(room.ID);
            LoadRoom();
        }

        private void lsvBillRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
