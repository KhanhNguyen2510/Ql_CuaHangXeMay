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
            var dt = Nhap_BUS.getdsNhap();
            dataGridView1.DataSource = dt;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Nhap_BUS.ThemNhap(txtma.Text, cbtenhang.Text, Int32.Parse(numericUpDown1.Text), dateTimePicker1.Text, textBox1.Text);
            await Task.Delay(700);
            Xuly();
            MessageBox.Show("Thêm thành công");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Nhap_BUS.SuaNhap(txtma.Text, Int32.Parse(numericUpDown1.Text));
            await Task.Delay(600);
            Xuly();
            MessageBox.Show("Sửa thành công");

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Nhap_BUS.XoadsNhap(txtma.Text);
            await Task.Delay(600);
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
            //dateTimePicker1.Value = Convert.ToDateTime(nv.Date.ToString());
            numericUpDown1.Value = nv.Number;
            //numericUpDown2.Value = nv.Money;

        }

        private void Nhaphang_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;

           
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
     
                var dt = Nhap_BUS.getdstang();
                dataGridView1.DataSource = dt;
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var dt = Nhap_BUS.getdsgiam();
            dataGridView1.DataSource = dt;
        }

        private void cbtenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
