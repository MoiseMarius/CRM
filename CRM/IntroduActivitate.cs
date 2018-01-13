using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class IntroduActivitate : Form
    {
        public IntroduActivitate()
        {
            InitializeComponent();
        }

        private void IntroduActivitate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'structuriDeDate.Activitati' table. You can move, or remove it, as needed.
            this.activitatiTableAdapter.Fill(this.structuriDeDate.Activitati);

        }

        private void Salveaza_Click(object sender, EventArgs e)
        {

        }
    }
}
