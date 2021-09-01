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
    public partial class Dasachxe : Form
    {
        public Dasachxe()
        {
            InitializeComponent();
        }
     
        private void Dasachxe_Load(object sender, EventArgs e)
        {
            var dt = xem_bus.getdsnv();
            dataGridView1.DataSource = dt;
        }
    }
}
