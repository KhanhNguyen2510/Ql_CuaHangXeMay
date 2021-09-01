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
    public partial class Danhsachncc : Form
    {
        public Danhsachncc()
        {
            InitializeComponent();
        }

        private void Danhsachncc_Load(object sender, EventArgs e)
        {
            var dt = Nhap_BUS.gedsncc();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
