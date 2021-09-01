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
    public partial class NhanVien_GUI : Form
    {
        public NhanVien_GUI()
        {
            InitializeComponent();
        }

        private void NhanVien_GUI_Load(object sender, EventArgs e)
        {
            
        }
        public void Chay()
        {
            //var dt = Themnhanvien_BUS.getdsnv();
            //dataGridView1.DataSource = dt;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {

            //Themnhanvien_BUS.ThemNVBUS(txtid.Text.ToString(), txtTen.Text.ToString(), dateTimePicker1.Text, txtQue.Text);
            //await Task.Delay(500);
            //Chay();
        }

        private void NhanVien_GUI_Load_1(object sender, EventArgs e)
        {
            Chay();
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            //Themnhanvien_BUS.XoanvBUS(txtTen.Text);
            //await Task.Delay(500);
            //Chay();
            //MessageBox.Show("Thành công");
        }
       
        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            //NhanVien_DTO nv = dataGridView1.CurrentRow.DataBoundItem as NhanVien_DTO;
            //txtid.Text = nv.Id;
            //DateTime date = DateTime.ParseExact(nv.Date, "dd/MM/yyyy", null);
            //dateTimePicker1.Text = date.ToString();
            //txtTen.Text = nv.Name;
            //txtQue.Text = nv.Address;
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            //Themnhanvien_BUS.SuaNV(txtid.Text.ToString(), txtTen.Text.ToString(), dateTimePicker1.Text, txtQue.Text);
            //await Task.Delay(500);
            //Chay();
        }
    }
}
