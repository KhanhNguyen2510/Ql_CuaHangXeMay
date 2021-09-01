using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DoAN.DAO;
using DoAN.DTO;
using DoAN.BUS;

namespace DoAN
{
    public partial class dsXe : Form
    {
        public dsXe()
        {
            InitializeComponent();
        }
        public void Xuly()
        {
            var dt = NhanVien_DAO.dsXe();
            dataGridView1.DataSource = dt;
        }
        private void dsXe_Load(object sender, EventArgs e)
        {
            Xuly();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = NhanVien_DAO.Tim(textBox1.Text);
            dataGridView1.DataSource = dt;
      

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Themxe f = new Themxe();
            this.Hide();
            f.ShowDialog();
            this.Show();
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = "";
            var dt = NhanVien_DAO.CHIEN(id);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Danh sách đã được cập nhật xong");
            Xuly();

        }
    }
}
