using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day26_02
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void File_Open_Click(object sender, EventArgs e)
        {
            var Dlg = new Form2();
            if(Dlg.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("정상종료되었습니다");
            }
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            cnt++;
            listView1.Items.Add(new ListViewItem(new string[] { cnt.ToString(), Dlg.sum.ToString(),  datetime}));
            Dlg.Dispose();
        }
    }
}
