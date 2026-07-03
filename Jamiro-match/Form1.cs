using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jamiro_match
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int orange = 0;
        public int peaky = 0;
        public int gang = 0;
        public int guy = 0;
        public int snail = 0;
        public int tuff = 0;
        public bool checker(string which, int value)
        {
            return true;
        }

        private void ocover1_Click(object sender, EventArgs e)
        {
            ocover1.Visible= false;
        }

        private void ocover2_Click(object sender, EventArgs e)
        {
            ocover2.Visible = false;
        }

        private void peakycover1_Click(object sender, EventArgs e)
        {
            peakycover1.Visible = false;
        }

        private void peakycover2_Click(object sender, EventArgs e)
        {
            peakycover2.Visible = false;
        }

        private void gangcover1_Click(object sender, EventArgs e)
        {
            gangcover1.Visible = false;
        }

        private void gangcover2_Click(object sender, EventArgs e)
        {
            gangcover2.Visible = false;
        }

        private void guycover1_Click(object sender, EventArgs e)
        {
            guycover1.Visible = false;
        }

        private void guycover2_Click(object sender, EventArgs e)
        {
            guycover2.Visible = false;
        }

        private void snail1_Click(object sender, EventArgs e)
        {
            snailcover1.Visible = false;
        }

        private void snail2_Click(object sender, EventArgs e)
        {
            snailcover2.Visible = false;
        }

        private void tuff1_Click(object sender, EventArgs e)
        {
            tuffcover1.Visible = false;
        }

        private void tuff2_Click(object sender, EventArgs e)
        {
            tuffcover2.Visible = false;
        }
    }
}
