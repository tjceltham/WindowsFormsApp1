using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Panel p1 = new Panel();
        Panel p2 = new Panel();
        public Form1()
        {
            InitializeComponent();
            p1.BackColor = Color.DarkRed;
            p2.BackColor = Color.DarkGreen;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Controls.Add(p1,0,0);
        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Controls.Add(p2, 0, 0);
        }
    }
}
