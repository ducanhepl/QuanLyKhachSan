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

namespace QuanLyKhachSan
{
    public partial class HotelManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public HotelManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

        #region Method

        void ChangeAccount(int type)
        {
            btnAdmin.Enabled = type == 1;
           
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            RoomManager f = new RoomManager();
            f.Show();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            TableManager f = new TableManager();
            f.Show();
            this.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.Show();
            this.Show();
        }

        
    }
}
