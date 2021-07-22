using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAKU_LONDON_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (pictureBox2.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            Timelbl.Text = DateTime.Now.ToLongTimeString();
            Timelbl.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            string hour;
            if (DateTime.Now.Hour < 20)
            {
                 hour = (DateTime.Now.Hour + 4).ToString();
            }
           else 
            {
                hour = "0" + ((DateTime.Now.Hour + 4) - 24).ToString();
            }

            Timelbl.Text = hour + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
                
            Timelbl.Visible = true;
        }

    }
}
