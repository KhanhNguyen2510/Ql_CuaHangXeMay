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
    public partial class Nhaphang : Form
    {
        public Nhaphang()
        {
            InitializeComponent();
            Xuly();
        }
        public void Xuly()
        {
            var dt = Nhap_BUS.getdsnv();
            dataGridView1.DataSource = dt;
        }

        private async void button1_Click(object sender, EventArgs e)
        { 
            Nhap_BUS.ThemNBUS(txtma.Text, cbtenhang.Text, cbncc.Text, txtSoLuong.Text, dateTimePicker1.Text, txtThanhTien.Text);
            await Task.Delay(500);
            Xuly();
            MessageBox.Show("Thêm thành công");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Nhap_BUS.SuaNV(txtma.Text,cbtenhang.Text, cbncc.Text, txtSoLuong.Text, dateTimePicker1.Text, txtThanhTien.Text);
            await Task.Delay(600);
            Xuly();
            MessageBox.Show("Sửa thành công");

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Nhap_BUS.XoanvBUS(txtma.Text);
            await Task.Delay(500);
            Xuly();
            MessageBox.Show("Xóa thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;

            NhanVien_DTO nv = dataGridView1.CurrentRow.DataBoundItem as NhanVien_DTO;
            txtma.Text = nv.Id;
            cbtenhang.Text = nv.Name;
            cbncc.Text = nv.Ncc;

            //dateTimePicker1.Text = nv.Date.ToString();
            txtSoLuong.Text = nv.Number;
            txtThanhTien.Text = nv.Money;

        }

        private void Nhaphang_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}
