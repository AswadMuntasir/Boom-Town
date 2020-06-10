using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoomTown
{
    
    public partial class MenuList : MetroFramework.Forms.MetroForm
    {
        public MenuList()
        {
            InitializeComponent();
            pnlSide.Width = btnBurger.Width;
            pnlSide.Left = btnBurger.Left;
            burgers1.BringToFront();


        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            pnlSide.Width = btnBurger.Width;
            pnlSide.Left = btnBurger.Left;
            burgers1.BringToFront();
        }

        private void btnSides_Click(object sender, EventArgs e)
        {
            pnlSide.Width = btnSides.Width;
            pnlSide.Left = btnSides.Left;
            sides1.BringToFront();
        }

        private void btnBTS_Click(object sender, EventArgs e)
        {
            pnlSide.Width = btnBTS.Width;
            pnlSide.Left = btnBTS.Left;
            boomTownSpecial1.BringToFront();
        }

        private void btnPlatter_Click(object sender, EventArgs e)
        {
            pnlSide.Width = btnPlatter.Width;
            pnlSide.Left = btnPlatter.Left;
            platters1.BringToFront();
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            pnlSide.Width = btnBeverage.Width;
            pnlSide.Left = btnBeverage.Left;
            bevarages1.BringToFront();
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            pnlSide.Width = btnDessert.Width;
            pnlSide.Left = btnDessert.Left;
            desserts1.BringToFront();
        }

        private void rbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private int x = 0;
        //private int y = 0;

        private void btnOrderQtyP_Click(object sender, EventArgs e)
        {

            //x++;

            //lblOrderQty.Text = x.ToString();

        }

        private void btnOrderQtyS_Click(object sender, EventArgs e)
        {
            if (x==1)
            {
                MessageBox.Show("Quantity Cannot be less than 1");

            }
            else
            {
                x--;
                //lblOrderQty.Text = x.ToString();
            }
            
        }

        private void lblDIQty_Click(object sender, EventArgs e)
        {

        }

        private void pnlCalculateBill_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void bevarages1_Load(object sender, EventArgs e)
        {

        }
    }
}
