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
    public partial class Employee : MetroFramework.Forms.MetroForm
    {
        HomePage hp;
        public Employee(HomePage hp)
        {
            InitializeComponent();
            this.hp = hp;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            hp.Visible = true;
        }
    }
}
