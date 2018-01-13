using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class PaginaPrincipala : Form
    {
        IntroduActivitate panouActivitate;

        public PaginaPrincipala()
        {
            InitializeComponent();
            panouActivitate = new IntroduActivitate(this);
        }
        
        private void ButonActivitate_Click(object sender, EventArgs e)
        {
            panouActivitate.Show();
            this.Close();
        }

        private void ButonClasament_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
