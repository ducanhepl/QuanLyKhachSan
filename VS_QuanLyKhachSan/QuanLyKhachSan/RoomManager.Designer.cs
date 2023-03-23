namespace QuanLyKhachSan
{
    partial class RoomManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomManager));
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmServiceCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddService = new System.Windows.Forms.Button();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpkCheckout = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkCheckin = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBillRoom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTotalPriceRoom = new System.Windows.Forms.TextBox();
            this.btnCheckOutRoom = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmServiceCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.Location = new System.Drawing.Point(26, 7);
            this.flpRoom.Margin = new System.Windows.Forms.Padding(4);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(552, 553);
            this.flpRoom.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmServiceCount);
            this.panel4.Controls.Add(this.btnAddService);
            this.panel4.Controls.Add(this.cbService);
            this.panel4.Location = new System.Drawing.Point(584, 69);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 35);
            this.panel4.TabIndex = 10;
            // 
            // nmServiceCount
            // 
            this.nmServiceCount.Location = new System.Drawing.Point(395, 7);
            this.nmServiceCount.Margin = new System.Windows.Forms.Padding(4);
            this.nmServiceCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmServiceCount.Name = "nmServiceCount";
            this.nmServiceCount.Size = new System.Drawing.Size(52, 22);
            this.nmServiceCount.TabIndex = 3;
            this.nmServiceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(285, 4);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(100, 27);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Thêm DV";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(6, 5);
            this.cbService.Margin = new System.Windows.Forms.Padding(4);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(272, 24);
            this.cbService.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpkCheckout);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpkCheckin);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(584, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 61);
            this.panel1.TabIndex = 11;
            // 
            // dtpkCheckout
            // 
            this.dtpkCheckout.Location = new System.Drawing.Point(166, 33);
            this.dtpkCheckout.Name = "dtpkCheckout";
            this.dtpkCheckout.Size = new System.Drawing.Size(243, 22);
            this.dtpkCheckout.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(100, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trả phòng:";
            // 
            // dtpkCheckin
            // 
            this.dtpkCheckin.Location = new System.Drawing.Point(166, 5);
            this.dtpkCheckin.Name = "dtpkCheckin";
            this.dtpkCheckin.Size = new System.Drawing.Size(243, 22);
            this.dtpkCheckin.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(100, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhận phòng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBillRoom);
            this.panel2.Location = new System.Drawing.Point(586, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 388);
            this.panel2.TabIndex = 12;
            // 
            // lsvBillRoom
            // 
            this.lsvBillRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBillRoom.GridLines = true;
            this.lsvBillRoom.Location = new System.Drawing.Point(4, 4);
            this.lsvBillRoom.Margin = new System.Windows.Forms.Padding(4);
            this.lsvBillRoom.Name = "lsvBillRoom";
            this.lsvBillRoom.Size = new System.Drawing.Size(441, 379);
            this.lsvBillRoom.TabIndex = 0;
            this.lsvBillRoom.UseCompatibleStateImageBehavior = false;
            this.lsvBillRoom.View = System.Windows.Forms.View.Details;
            this.lsvBillRoom.SelectedIndexChanged += new System.EventHandler(this.lsvBillRoom_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên DV";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 81;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbTotalPriceRoom);
            this.panel3.Controls.Add(this.btnCheckOutRoom);
            this.panel3.Location = new System.Drawing.Point(652, 499);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 64);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng tiền:";
            // 
            // txbTotalPriceRoom
            // 
            this.txbTotalPriceRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTotalPriceRoom.ForeColor = System.Drawing.Color.OrangeRed;
            this.txbTotalPriceRoom.Location = new System.Drawing.Point(111, 18);
            this.txbTotalPriceRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPriceRoom.Name = "txbTotalPriceRoom";
            this.txbTotalPriceRoom.ReadOnly = true;
            this.txbTotalPriceRoom.Size = new System.Drawing.Size(139, 30);
            this.txbTotalPriceRoom.TabIndex = 7;
            this.txbTotalPriceRoom.Text = "0";
            this.txbTotalPriceRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCheckOutRoom
            // 
            this.btnCheckOutRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOutRoom.Location = new System.Drawing.Point(259, 4);
            this.btnCheckOutRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOutRoom.Name = "btnCheckOutRoom";
            this.btnCheckOutRoom.Size = new System.Drawing.Size(120, 57);
            this.btnCheckOutRoom.TabIndex = 3;
            this.btnCheckOutRoom.Text = "Thanh toán";
            this.btnCheckOutRoom.UseVisualStyleBackColor = true;
            this.btnCheckOutRoom.Click += new System.EventHandler(this.btnCheckOutService_Click);
            // 
            // RoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1041, 567);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flpRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmServiceCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmServiceCount;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkCheckout;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkCheckin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBillRoom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTotalPriceRoom;
        private System.Windows.Forms.Button btnCheckOutRoom;
    }
}