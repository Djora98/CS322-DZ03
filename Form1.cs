using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ03
{
    public partial class frmForma : Form
    {
        public frmForma()
        {
            InitializeComponent();
        }

        private void btnZuto_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            this.btnZuto.BackColor = Color.Yellow;
        }

        private void btnPlavo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void btnCrveno_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void btnKlikni_Click(object sender, EventArgs e)
        {
            lblLabela.Text = txbLabela.Text;
        }
    }
}
