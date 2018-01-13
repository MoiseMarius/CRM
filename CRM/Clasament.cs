using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class Clasament : Form
    {
        PaginaPrincipala linkInapoi;

        public Clasament(PaginaPrincipala parinte)
        {
            InitializeComponent();
            linkInapoi = parinte;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            linkInapoi.Show();
            this.Hide();
        }
    }
}
