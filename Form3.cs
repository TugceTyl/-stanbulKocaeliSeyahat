using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstanbulKocaeliSeyahat
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 bilet = new Form2();
            bilet.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "\thttp://46.20.3.201:80/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://shoutcast.radyogrup.com:1010/";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "\thttp://46.20.7.125/listen.pls";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=Istanbul&ysclid=lljt14xjyu834189143");
        }
    }
}
