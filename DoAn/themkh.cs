using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DoAN.BUS;

namespace DoAN
{
    public partial class themkh : Form
    {
        public themkh()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Nhap_BUS.Themkh(txtma.Text, txtten.Text, txtsdt.Text, txtdiachi.Text);
            MessageBox.Show("Thêm khách hàng thành công");
            BanHang.tendangnhap = txtma.Text;
        }
       
        private void themkh_Load(object sender, EventArgs e)
        {

        }
    }
}
