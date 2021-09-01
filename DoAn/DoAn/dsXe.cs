using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DoAN.DAO;
using DoAN.DTO;

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
            //var dt = NhanVien_DAO.dsXe();
            //dataGridView1.DataSource = dt;
            var dt = NhanVien_DAO.dsNCC();
            dataGridView1.DataSource = dt;
        }
        private void dsXe_Load(object sender, EventArgs e)
        {
            Xuly();
        }
    }
}
