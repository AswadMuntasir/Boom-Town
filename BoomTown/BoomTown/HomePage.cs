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
    public partial class HomePage : MetroFramework.Forms.MetroForm
    {
        Login l;
        MenuList mn = new MenuList();

        public HomePage(Login l)
        {
            InitializeComponent();
            pnlselect.Height = btnOrder.Height;
            pnlselect.Top = btnOrder.Top;
            pnlOrder.BringToFront();
            home1.Visible = false;
            this.l = l;
        }

        /*private void tables1_Load(object sender, EventArgs e)
        {
            MenuList mn = new MenuList();
            this.Visible = false;
            mn.Visible = true;
            
        }*/

        private void btnTable1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void CheckBoxT1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT1.Checked == true)
            {
                btnTable1.Enabled = false;
            }
            else
            {
                btnTable1.Enabled = true;
            }
        }

        private void CheckBoxT2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT2.Checked == true)
            {
                btnTable2.Enabled = false;
            }
            else
            {
                btnTable2.Enabled = true;
            }

        }

        private void CheckBoxT3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT3.Checked == true)
            {
                btnTable3.Enabled = false;
            }
            else
            {
                btnTable3.Enabled = true;
            }
        }

        private void CheckBoxT4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT4.Checked == true)
            {
                btnTable4.Enabled = false;
            }
            else
            {
                btnTable4.Enabled = true;
            }
        }

        private void CheckBoxT5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT5.Checked == true)
            {
                btnTable5.Enabled = false;
            }
            else
            {
                btnTable5.Enabled = true;
            }
        }

        private void CheckBoxT6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT6.Checked == true)
            {
                btnTable6.Enabled = false;
            }
            else
            {
                btnTable6.Enabled = true;
            }
        }

        private void CheckBoxT7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT7.Checked == true)
            {
                btnTable7.Enabled = false;
            }
            else
            {
                btnTable7.Enabled = true;
            }
        }

        private void CheckBoxT8_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT8.Checked == true)
            {
                btnTable8.Enabled = false;
            }
            else
            {
                btnTable8.Enabled = true;
            }
        }

        private void CheckBoxT9_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT9.Checked == true)
            {
                btnTable9.Enabled = false;
            }
            else
            {
                btnTable9.Enabled = true;
            }
        }

        private void CheckBoxT10_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT10.Checked == true)
            {
                btnTable10.Enabled = false;
            }
            else
            {
                btnTable10.Enabled = true;
            }
        }

        private void CheckBoxT11_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT11.Checked == true)
            {
                btnTable11.Enabled = false;
            }
            else
            {
                btnTable11.Enabled = true;
            }
        }

        private void CheckBoxT12_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT12.Checked == true)
            {
                btnTable12.Enabled = false;
            }
            else
            {
                btnTable12.Enabled = true;
            }
        }

        private void CheckBoxT13_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT13.Checked == true)
            {
                btnTable13.Enabled = false;
            }
            else
            {
                btnTable13.Enabled = true;
            }

        }

        private void CheckBoxT14_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT14.Checked == true)
            {
                btnTable14.Enabled = false;
            }
            else
            {
                btnTable14.Enabled = true;
            }
        }

        private void CheckBoxT15_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT15.Checked == true)
            {
                btnTable15.Enabled = false;
            }
            else
            {
                btnTable15.Enabled = true;
            }
        }

        private void CheckBoxT16_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT16.Checked == true)
            {
                btnTable16.Enabled = false;
            }
            else
            {
                btnTable16.Enabled = true;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlselect.Height = btnOrder.Height;
            pnlselect.Top = btnOrder.Top;
            pnlOrder.Visible = true;
            pnlOrder.BringToFront();
            home1.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlselect.Height = btnHome.Height;
            pnlselect.Top = btnHome.Top;
            home1.Visible = true;
            pnlOrder.Visible = false;
        }

        private void btnSalesRecord_Click(object sender, EventArgs e)
        {
            pnlselect.Height = btnSalesRecord.Height;
            pnlselect.Top = btnSalesRecord.Top;
            home1.Visible = false;

        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            pnlselect.Height = btnEmp.Height;
            pnlselect.Top = btnEmp.Top;
            home1.Visible = false;
            Employee empl = new Employee(this);
            this.Visible = false;
            empl.Visible = true;
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer(this);
            pnlselect.Height = btnCustomerInfo.Height;
            pnlselect.Top = btnCustomerInfo.Top;
            home1.Visible = false;
            cs.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            l.Visible = true;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ResetPassword rp = new ResetPassword(l);
            rp.Visible = true;
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable11_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable12_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable13_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable14_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable15_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }

        private void btnTable16_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mn.Visible = true;
        }
    }
}
