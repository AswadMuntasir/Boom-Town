using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BoomTown.Repo;
using BoomTown.Entities;
using BoomTown.Framework;

namespace BoomTown
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
            lblUserID.Text = "";
            lblPass.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUserId.Text;
            string password = txtPass.Text;

            HomePage hp = new HomePage(this);           
            hp.Visible = true;
            this.Visible = false;
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            ForgerPassword fp = new ForgerPassword(this);
            this.Visible = false;
            fp.Visible = true;
        }
    }
}
