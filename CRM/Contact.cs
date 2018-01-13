using System.Windows.Forms;

namespace CRM
{
    public partial class Contact : Form
    {
        PaginaPrincipala linkInapoi;

        public Contact(PaginaPrincipala parinte)
        {
            InitializeComponent();
            linkInapoi = parinte;
        }

        private void Contact_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'structuriDeDate.InformatiiComplete' table. You can move, or remove it, as needed.
            this.informatiiCompleteTableAdapter.Fill(this.structuriDeDate.InformatiiComplete);
        }

        private void Back_Click(object sender, System.EventArgs e)
        {
            linkInapoi.Show();
            this.Hide();
        }
    }
}
