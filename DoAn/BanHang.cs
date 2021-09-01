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
using DoAN.DAO;

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
            var dt = Nhap_BUS.getdsban();
            dataGridView1.DataSource = dt;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Nhap_BUS.THemBan(txtma.Text, cbtenhang.Text, int.Parse(numericUpDown1.Text), dateTimePicker1.Text, textBox2.Text, txtkhachhang.Text);
            await Task.Delay(600);
            Xuly();
            MessageBox.Show("Thêm thành công");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Nhap_BUS.SuadsBan(txtma.Text, Int32.Parse(numericUpDown1.Text));
            await Task.Delay(600);
            Xuly();
            MessageBox.Show("Sửa thành công");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Nhap_BUS.XoadsBan(txtma.Text);
            await Task.Delay(600);
            Xuly();
            MessageBox.Show("Xóa thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            textBox1.Enabled = true;
            Ban  nv = dataGridView1.CurrentRow.DataBoundItem as Ban;
            txtma.Text = nv.Id;
            txtkhachhang.Text = nv.Kh;
            cbtenhang.Text = nv.Xe;
            numericUpDown1.Value = nv.Number;
            textBox2.Text = nv.Thanhtien;
            //dateTimePicker1.Value= Convert.ToDateTime(nv.Date.ToString());



        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            Xuly();
            button4.Enabled = false;
            textBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string name = "desc";
            var dt = Nhap_BUS.GiatriBanhang(name);
            dataGridView1.DataSource = dt;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string name = "asc";
            var dt = Nhap_BUS.GiatriBanhang(name);
            dataGridView1.DataSource = dt;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Nhap_BUS.SuaKH(txtma.Text,textBox1.Text);
            await Task.Delay(600);
            Xuly();
            MessageBox.Show("Thêm thành công");
        }
        public static string tendangnhap = "";
        private void themkh_Click(object sender, EventArgs e)
        {
            themkh f = new themkh();
            this.Hide();
            f.ShowDialog();
            this.Show();
            txtkhachhang.Text = tendangnhap;
            txtkhachhang.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void cbtenhang_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (cbtenhang.Text == "WX150" || cbtenhang.Text == "AB125" || cbtenhang.Text == "EX150")
            {
                textBox2.Text = (50000000 * int.Parse(numericUpDown1.Text)).ToString();
            }
            if (cbtenhang.Text == "W150" || cbtenhang.Text == "B100" || cbtenhang.Text == "F125" || cbtenhang.Text == "W110")
            {
                textBox2.Text = (27000000 * int.Parse(numericUpDown1.Text)).ToString();
            }
            if (cbtenhang.Text == "SHY150" || cbtenhang.Text == "SM150" || cbtenhang.Text == "SH150")
            {
                textBox2.Text = (120000000 * int.Parse(numericUpDown1.Text)).ToString();
            }
        }
    }
}
