using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class IntroduActivitate : Form
    {
        PaginaPrincipala linkInapoi;

        public IntroduActivitate(PaginaPrincipala parinte)
        {
            InitializeComponent();
            linkInapoi = parinte;
        }

        private void Salveaza_Click(object sender, EventArgs e)
        {
            try
            {
                linkInapoi.adaptorDate.InsereazaActivitate(Autentificare.IDUtilizatorAutentificat,
                    NumeActivitate.Text, Convert.ToInt32(IDCategorie.Text), Convert.ToInt32(Punctaj.Text));
            }
            catch
            {
                MessageBox.Show("Nu se poate insera activitatea!!!");
                linkInapoi.Close();
                this.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            linkInapoi.Show();
            this.Hide();
        }
    }
}
