﻿using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class ContactRegister : Form
    {
        StructuriDeDateTableAdapters.ContactTableAdapter adaptorDeDate = new StructuriDeDateTableAdapters.ContactTableAdapter();
        int userID;

        public ContactRegister(int givenID)
        {
            InitializeComponent();
            userID = givenID;
        }

        private void Salveaza_Click(object sender, EventArgs e)
        {
            try
            {
                adaptorDeDate.Insert(userID, Adresa.Text, Emailuri.Text, TelefonAcasa.Text, TelefonMobil.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Nu se pot insera aceste date!!!");
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {

        }
    }
}
