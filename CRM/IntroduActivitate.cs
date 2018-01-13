using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class IntroduActivitate : Form
    {
        StructuriDeDateTableAdapters.QueriesTableAdapter adaptorPentruInsertie;
        PaginaPrincipala linkInapoi;

        public IntroduActivitate()
        {
            InitializeComponent();
        }

        public IntroduActivitate(PaginaPrincipala parinte)
        {
            linkInapoi = parinte;
        }

        private void IntroduActivitate_Load(object sender, EventArgs e)
        {
            adaptorPentruInsertie = new StructuriDeDateTableAdapters.QueriesTableAdapter();
        }

        private void Salveaza_Click(object sender, EventArgs e)
        {
            adaptorPentruInsertie.InsereazaActivitate(Autentificare.IDUtilizatorAutentificat,
                Convert.ToInt32(IDCategorie.Text), NumeActivitate.Text, Convert.ToInt32(Punctaj.Text));
        }

        private void Back_Click(object sender, EventArgs e)
        {
            linkInapoi.Show();
            this.Close();
        }
    }
}
