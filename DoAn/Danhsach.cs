using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAN
{
    public partial class Danhsach : Form
    {
        public Danhsach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btndsxe_Click(object sender, EventArgs e)
        {
            dsXe f = new dsXe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btndscungcap_Click(object sender, EventArgs e)
        {
            Danhsachncc f = new Danhsachncc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            Nhaphang f = new Nhaphang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHoaDonXuat_Click(object sender, EventArgs e)
        {
            BanHang f = new BanHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
