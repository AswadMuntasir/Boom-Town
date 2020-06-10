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
    public partial class ResetPassword : MetroForm
    {
        Login lg;
        public ResetPassword(Login lg)
        {
            InitializeComponent();
            this.lg = lg;
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            lg.Visible = true;
        }
    }
}
