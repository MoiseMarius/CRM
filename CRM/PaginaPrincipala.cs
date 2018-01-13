using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class PaginaPrincipala : Form
    {
        public StructuriDeDateTableAdapters.QueriesTableAdapter adaptorDate;
        IntroduActivitate panouActivitate;
        Clasament panouClasament;
        Contact panouContact;

        public PaginaPrincipala()
        {
            InitializeComponent();
            adaptorDate = new StructuriDeDateTableAdapters.QueriesTableAdapter();
            panouActivitate = new IntroduActivitate(this);
            panouContact = new Contact(this);
            panouClasament = new Clasament(this);
        }
        
        private void ButonActivitate_Click(object sender, EventArgs e)
        {
            panouActivitate.Show();
            this.Hide();
        }

        private void ButonClasament_Click(object sender, EventArgs e)
        {
            panouClasament.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panouContact.Show();
            this.Hide();
        }
    }
}
