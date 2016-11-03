using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace law
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            estLawcase elc = new estLawcase();
            elc.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            seaLawcase slc = new seaLawcase();
            slc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            sinContract sct = new sinContract();
            sct.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IEXPLORE.EXE","http://www.baidu.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            overtriCase otc = new overtriCase();
            otc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            triCase tc = new triCase();
            tc.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            incomeDetail id = new incomeDetail();
            id.Show();
        }
    }
}
