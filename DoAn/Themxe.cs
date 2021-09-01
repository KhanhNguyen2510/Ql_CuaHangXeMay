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
    public partial class Themxe : Form
    {
        public Themxe()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nhap_BUS.Themxeee(textBox1.Text, textBox2.Text, comboBox1.Text, textBox5.Text, textBox4.Text);
            MessageBox.Show("Thêm thành công");
            
        }
    }
}
