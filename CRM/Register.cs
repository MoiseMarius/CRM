using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CRM
{
    public partial class Register : Form
    {
        StructuriDeDateTableAdapters.PersonTableAdapter adaptorDeDate = new StructuriDeDateTableAdapters.PersonTableAdapter();
        ContactRegister paginaContact;
        LoginRegister paginaLogin;
        Autentificare paginaParinte;
        int userID;

        public Register(Autentificare autentificare)
        {
            InitializeComponent();
            paginaParinte = autentificare;
        }

        private void Salveaza_Click(object sender, EventArgs e)
        {
            adaptorDeDate.Insert(Titlu.Text, Nume.Text, Prenume.Text, DataNasterii.Value, Ocupatie.Text, SexPicker.CheckedItems[0].ToString().Substring(1,1));
            userID = (from line in adaptorDeDate.GetData().AsEnumerable()
                      where line.Titlu == Titlu.Text && line.Nume == Nume.Text && line.Prenume == Prenume.Text
                      select line.ID).First();

            paginaContact = new ContactRegister(userID);
            paginaContact.Show();

            paginaLogin = new LoginRegister(userID);
            paginaLogin.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            paginaParinte.Show();
            this.Close();
        }
    }
}
