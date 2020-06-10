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
    public partial class Burgers : UserControl
    {
        private int x;
        private int x1;
        private int x2;
        private int x3;
        private int y;
        private int y1;
        private int y2;
        private int y3;

        public Burgers()
        {
            InitializeComponent();
        }

        private void btnAddCartBSB_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrderBSBQtyS_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                x--;
                lblOrderBSBQty.Text = x.ToString();
            }
        }

        private void btnOrderBSBQtyP_Click(object sender, EventArgs e)
        {
            x++;
            lblOrderBSBQty.Text = x.ToString();
        }

        private void btnTAOrderBSBQtyS_Click(object sender, EventArgs e)
        {
            if (y == 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                y--;
                lblTAOrderBSBQty.Text = y.ToString();
            }
        }

        private void btnTAOrderBSBQtyP_Click(object sender, EventArgs e)
        {
            y++;
            lblTAOrderBSBQty.Text = y.ToString();
        }

        private void btnOrderCDQtyS_Click(object sender, EventArgs e)
        {
            if (x1 <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                x1--;
                lblOrderCDQty.Text = x1.ToString();
            }
        }

        private void btnOrderCDQtyP_Click(object sender, EventArgs e)
        {
            x1++;
            lblOrderCDQty.Text = x1.ToString();
        }

        private void btnTAOrderCDQtyS_Click(object sender, EventArgs e)
        {
            if (y1 <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                y1--;
                lblTAOrderCDQty.Text = y1.ToString();
            }
        }

        private void btnTAOrderCDQtyP_Click(object sender, EventArgs e)
        {
            y1++;
            lblTAOrderCDQty.Text = y1.ToString();
        }

        private void btnOrderCSBQtyDNN_Click(object sender, EventArgs e)
        {
            if (x2 <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                x2--;
                lblDNOrderCSBQty.Text = x2.ToString();
            }
        }

        private void btnOrderCSBQtyDNP_Click(object sender, EventArgs e)
        {
            x2++;
            lblDNOrderCSBQty.Text = x2.ToString();
        }

        private void btnOrderCSBQtyTAN_Click(object sender, EventArgs e)
        {
            if (y2 <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                y2--;
                lblTAOrderCSBQty.Text = y2.ToString();
            }
        }

        private void btnOrderCSBQtyTAP_Click(object sender, EventArgs e)
        {
            y2++;
            lblTAOrderCSBQty.Text = y2.ToString();
        }

        private void btnOrderCSBQtyDNN1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrderCSBQtyDNP1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrderCSBQtyDNN1_Click_1(object sender, EventArgs e)
        {
            if (x3 <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                x3--;
                lblDNOrderCSBQty1.Text = x3.ToString();
            }
        }

        private void btnOrderCSBQtyDNP1_Click_1(object sender, EventArgs e)
        {
            x3++;
            lblDNOrderCSBQty1.Text = x3.ToString();
        }

        private void btnOrderCSBQtyTAN1_Click(object sender, EventArgs e)
        {
            if (y3 <= 0)
            {
                MessageBox.Show("Something Went wrong");
            }
            else
            {
                y3--;
                lblTAOrderCSBQty1.Text = y3.ToString();
            }
        }

        private void btnOrderCSBQtyTAP1_Click(object sender, EventArgs e)
        {
            y3++;
            lblTAOrderCSBQty1.Text = y3.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCartCCSB_Click(object sender, EventArgs e)
        {
            int totalAmountDI3 = x3 * 280;
            int totalAmountTA3 = y3 * 280;
            int total3 = totalAmountDI3 + totalAmountTA3;


        }

        private void btnAddCartBSB_Click_1(object sender, EventArgs e)
        {
            int totalAmountDI = x * 350;
            int totalAmountTA = y * 350;
            int total = totalAmountDI + totalAmountTA;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            int totalAmountDI1 = x1 * 250;
            int totalAmountTA1 = y1 * 250;
            int total1 = totalAmountDI1 + totalAmountTA1;

        }

        private void btnAddCartCSB_Click(object sender, EventArgs e)
        {
            int totalAmountDI2 = x2 * 280;
            int totalAmountTA2 = y2 * 280;
            int total2 = totalAmountDI2 + totalAmountTA2;

        }

        private void checkBoxCheese_CheckedChanged(object sender, EventArgs e)
        {
            int amountCheese = 30;
        }

        private void cBoxBeefPatty_CheckedChanged(object sender, EventArgs e)
        {
            int amountBeefPatty = 100;
        }

        private void cBoxChikenPatty_CheckedChanged(object sender, EventArgs e)
        {
            int amountChickenPatty = 80;
        }
    }
}
