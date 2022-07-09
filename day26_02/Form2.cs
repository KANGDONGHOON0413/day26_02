using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day26_02
{
    public partial class Form2 : Form
    {
        public int sum;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            Close();
        }
    }
}
