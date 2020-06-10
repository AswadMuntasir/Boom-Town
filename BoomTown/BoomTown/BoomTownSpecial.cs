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
    public partial class BoomTownSpecial : UserControl
    {
        private int x;
        private int x1;
        private int x2;
        private int y;
        private int y1;
        private int y2;

        public BoomTownSpecial()
        {
            InitializeComponent();
        }

        private void btnOrderQtyP_Click(object sender, EventArgs e)
        {
            x++;
            lblOrderQty.Text = x.ToString();
        }

        private void btnOrderQtyS_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                x--;
                lblOrderQty.Text = x.ToString();
            }
        }

        private void btnOrderQtyPTA_Click(object sender, EventArgs e)
        {
            y++;
            lblOrderQtyTA.Text = y.ToString();
        }

        private void btnOrderQtySTA_Click(object sender, EventArgs e)
        {
            if (y == 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                y--;
                lblOrderQtyTA.Text = x.ToString();
            }
        }

        private void btnOrderQtySACFC_Click(object sender, EventArgs e)
        {
            if (x1 == 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                x1--;
                lblOrderQtyACFC.Text = x1.ToString();
            }
        }

        private void btnOrderQtyPACFC_Click(object sender, EventArgs e)
        {
            y1++;
            lblOrderQtyACFC.Text = y1.ToString();
        }

        private void btnOrderQtySTAACFC_Click(object sender, EventArgs e)
        {
            if (y1 == 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                y1--;
                lblOrderQtyACFCTA.Text = y1.ToString();
            }
        }

        private void btnOrderQtyPTAACFC_Click(object sender, EventArgs e)
        {
            x2++;
            lblOrderQtyACFCTA.Text = x.ToString();
        }

        private void btnOrderQtyWFS_Click(object sender, EventArgs e)
        {
            if (x2 == 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                x2--;
                lblOrderQtyWF.Text = x2.ToString();
            }
        }

        private void btnOrderQtyWFP_Click(object sender, EventArgs e)
        {
            x2++;
            lblOrderQtyWF.Text = x2.ToString();
        }

        private void btnOrderQtyWFSTA_Click(object sender, EventArgs e)
        {
            if (y2 == 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                y2--;
                lblOrderQtyWFTA.Text = y2.ToString();
            }
        }

        private void btnOrderQtyWFPTA_Click(object sender, EventArgs e)
        {
            y2++;
            lblOrderQtyWFTA.Text = y2.ToString();
        }
    }
}
