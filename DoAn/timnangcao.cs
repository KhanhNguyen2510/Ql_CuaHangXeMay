using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DoAN.DAO;

namespace DoAN
{
    public partial class timnangcao : Form
    {
        public timnangcao()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = NhanVien_DAO.TimkiemNangcao(textBox1.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
