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
    public partial class Bevarages : UserControl
    {
        private int x;
        private int x1;
        private int x2;
        private int y;
        private int y1;
        private int y2;

        public Bevarages()
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
            if (x <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                x--;
                lblOrderQty.Text = x.ToString();
            }
        }

        private void btnTAOrderQtyP_Click(object sender, EventArgs e)
        {

            y++;
            lblOrderQtyTA.Text = y.ToString();
        }

        private void btnTAOrderQtyS_Click(object sender, EventArgs e)
        {
            if (y <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                y--;
                lblOrderQtyTA.Text = y.ToString();
            }

        }

        private void btnOrderCCQtyP_Click(object sender, EventArgs e)
        {
            x1++;
            lblOrderCCQty.Text = x1.ToString();
        }

        private void btnOrderCCQtyS_Click(object sender, EventArgs e)
        {
            if (x1 <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                x1--;
                lblOrderCCQty.Text = x1.ToString();
            }
        }

        private void btnTAOrderCCQtyP_Click(object sender, EventArgs e)
        {
            y1++;
            lblTAOrderCCQty.Text = y1.ToString();
        }

        private void btnTAOrderCCQtyS_Click(object sender, EventArgs e)
        {
            if (y1 <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                y1--;
                lblTAOrderCCQty.Text = y1.ToString();
            }

        }

        private void btnOrderHCQtyP_Click(object sender, EventArgs e)
        {

            x2++;
            lblOrderHCQty.Text = x2.ToString();
        }

        private void btnOrderHCQtyS_Click(object sender, EventArgs e)
        {
            if (x2 <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                x2--;
                lblOrderHCQty.Text = x2.ToString();
            }
        }

        private void btnTAOrderHCQtyP_Click(object sender, EventArgs e)
        {

            y2++;
            lblTAOrderHCQty.Text = y2.ToString();

        }

        private void btnTAOrderHCQtyS_Click(object sender, EventArgs e)
        {
            if (y2 <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                y2--;
                lblTAOrderHCQty.Text = y2.ToString();
            }
        }
    }
}
