using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAN.BUS;
using DoAN.DTO;

namespace DoAN
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }
        public void Xuly()
        {
            var dt = ban_bus.getdsnv();
            dataGridView1.DataSource = dt;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            ban_bus.THemBan(txtma.Text, cbtenhang.Text,txtSoLuong.Text,dateTimePicker1.Text,txtThanhTien.Text,txtkhachhang.Text);
            await Task.Delay(500);
            Xuly();
            MessageBox.Show("Thêm thành công");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            ban_bus.SuaNV(cbtenhang.Text, txtSoLuong.Text, dateTimePicker1.Text, txtThanhTien.Text, txtkhachhang.Text);
            await Task.Delay(500);
            Xuly();
            MessageBox.Show("Sửa thành công");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            ban_bus.XoanvBUS(txtma.Text);
            await Task.Delay(500);
            Xuly();
            MessageBox.Show("Xóa thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            Ban  nv = dataGridView1.CurrentRow.DataBoundItem as Ban;
            txtma.Text = nv.Id;
            cbtenhang.Text = nv.Xe;
            txtSoLuong.Text = nv.Number;
            //dateTimePicker1.Text = nv.Date.ToString();
            txtThanhTien.Text = nv.Thanhtien;

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            Xuly();
        }
    }
}
