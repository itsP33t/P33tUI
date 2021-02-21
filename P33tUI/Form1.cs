using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P33tUI
{
    public partial class P33tUI : Form
    {
        public P33tUI()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
        //opens my website when you click the button
            Process.Start("https://www.p33t.net/");
        }
    }
}
