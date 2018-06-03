using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinopins
{
    public partial class Form1 : Form
    {
        private KinopoiskSearch ks;
        public Form1()
        {
            InitializeComponent();
            ks = new KinopoiskSearch();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (ks.DownloanHtml(textBox_namefiml.Text))
            {
                ks.FindCover();
            }
        }
    }
}
