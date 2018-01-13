using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class Contact : Form
    {
        PaginaPrincipala linkInapoi;

        public Contact()
        {
            InitializeComponent();
        }

        public Contact(PaginaPrincipala parinte)
        {
            linkInapoi = parinte;
        }

        private void Clasament_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'structuriDeDate.Clasament' table. You can move, or remove it, as needed.
            this.clasamentTableAdapter.Fill(this.structuriDeDate.Clasament);
            // TODO: This line of code loads data into the 'structuriDeDate.Clasament' table. You can move, or remove it, as needed.
            this.clasamentTableAdapter.Fill(this.structuriDeDate.Clasament);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
