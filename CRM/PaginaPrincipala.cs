using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class PaginaPrincipala : Form
    {
        public StructuriDeDateTableAdapters.QueriesTableAdapter adaptorDate;
        IntroduActivitate panouActivitate;

        public PaginaPrincipala()
        {
            InitializeComponent();
            adaptorDate = new StructuriDeDateTableAdapters.QueriesTableAdapter();
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
