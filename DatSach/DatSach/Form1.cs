using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbMasach.Items.Add("5");
            cbMasach.Items.Add("10");
            cbMasach.Items.Add("15");
            cbThoigian.Items.Add("6h");
            cbThoigian.Items.Add("12h");
            cbThoigian.Items.Add("7h");
            cbEmail.Items.Add("Nhasach1@gmail.com");
            cbEmail.Items.Add("Nhasach2@gmail.com");
            cbEmail.Items.Add("Nhasach3@gmail.com");
        }
        public string HoTen, ThoiGian, Email;
        public int Masach, DienThoai;
        public DateTime NgayThang;

        private void btnXacnhan_Click(object sender, EventArgs e)
        {

            laydulieu();
            nhapdulieu();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = " ";
            txtSodienthoai.Text = "";
            cbMasach.Text = "";
            cbThoigian.Text = "";
            cbEmail.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void laydulieu()
        {
            HoTen = txtHoTen.Text;
            Masach = Int32.Parse(cbMasach.SelectedItem.ToString());
            DienThoai = Int32.Parse(txtSodienthoai.Text.ToString());
            NgayThang = dateTimePicker1.Value.Date;
            ThoiGian = cbThoigian.Text;
            Email = cbEmail.Text;
        }
        public void nhapdulieu()
        {
            //getMonAn();
            classhotro.ketnoi();
            classhotro.ThucThiLenh("INSERT INTO DAT_SACH VALUES('" + HoTen + "', " + Masach + ", " + DienThoai + ", '" + NgayThang + "','" + ThoiGian + "','" + Email + "')");
            MessageBox.Show("Thêm dữ liệu thành công!");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
