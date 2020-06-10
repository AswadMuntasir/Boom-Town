using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace BoomTown
{
    public partial class ForgerPassword : MetroForm
    {
        Login lg;
        public ForgerPassword(Login lg)
        {
            InitializeComponent();
            this.lg = lg;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            lg.Visible = true;
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword rp = new ResetPassword(lg);
            this.Visible = false;
            rp.Visible = false;
        }
    }
}
