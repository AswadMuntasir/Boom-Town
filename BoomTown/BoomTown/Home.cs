using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoomTown
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox22.Visible == true)
            {
                pictureBox22.Visible = false;
                pictureBox21.Visible = true;
            }
            else if (pictureBox21.Visible == true)
            {
                pictureBox21.Visible = false;
                pictureBox20.Visible = true;
            }
            else if (pictureBox20.Visible == true)
            {
                pictureBox20.Visible = false;
                pictureBox19.Visible = true;
            }
            else if (pictureBox19.Visible == true)
            {
                pictureBox19.Visible = false;
                pictureBox18.Visible = true;
            }
            else if (pictureBox18.Visible == true)
            {
                pictureBox18.Visible = false;
                pictureBox17.Visible = true;
            }
            else if (pictureBox17.Visible == true)
            {
                pictureBox17.Visible = false;
                pictureBox16.Visible = true;
            }
            else if (pictureBox16.Visible == true)
            {
                pictureBox16.Visible = false;
                pictureBox15.Visible = true;
            }
            else if (pictureBox15.Visible == true)
            {
                pictureBox15.Visible = false;
                pictureBox14.Visible = true;
            }
            else if (pictureBox14.Visible == true)
            {
                pictureBox14.Visible = false;
                pictureBox13.Visible = true;
            }
            else if (pictureBox13.Visible == true)
            {
                pictureBox13.Visible = false;
                pictureBox12.Visible = true;
            }
            else if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox11.Visible = true;
            }
            else if (pictureBox11.Visible == true)
            {
                pictureBox11.Visible = false;
                pictureBox10.Visible = true;
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox10.Visible = false;
                pictureBox9.Visible = true;
            }
            else if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox8.Visible = true;
            }
            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                pictureBox7.Visible = true;
            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }
            else if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox22.Visible = true;
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox21.Visible = false;
            pictureBox20.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            pictureBox17.Visible = false;
            pictureBox16.Visible = false;
            pictureBox15.Visible = false;
            pictureBox14.Visible = false;
            pictureBox13.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox10.Visible = false;
            pictureBox9.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;

        }
    }
}
