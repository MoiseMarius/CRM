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

        private void Clasament_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'structuriDeDate.Clasament' table. You can move, or remove it, as needed.
            this.clasamentTableAdapter.Fill(this.structuriDeDate.Clasament);
            // TODO: This line of code loads data into the 'structuriDeDate.Clasament' table. You can move, or remove it, as needed.
            this.clasamentTableAdapter.Fill(this.structuriDeDate.Clasament);

        }
    }
}
