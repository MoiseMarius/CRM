using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class LoginRegister : Form
    {
        int userID;
        StructuriDeDateTableAdapters.LoginTableAdapter adaptorDeDate = new StructuriDeDateTableAdapters.LoginTableAdapter();

        public LoginRegister(int givenID)
        {
            InitializeComponent();
            userID = givenID;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            adaptorDeDate.Insert(userID, UserName.Text, Password.Text.GetHashCode().ToString());
            this.Close();
        }
    }
}
