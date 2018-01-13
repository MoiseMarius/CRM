using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CRM
{
    public partial class Autentificare : Form
    {
        public static int IDUtilizatorAutentificat = -5;
        public static StructuriDeDate.PersonRow utilizatorAutentificat;

        public Autentificare()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection bazaLocala = new SqlConnection(Properties.Settings.Default.DataBaseConnectionString))
            using (SqlCommand autentifica = new SqlCommand
            {
                Connection = bazaLocala,
                CommandType = CommandType.StoredProcedure,
                CommandText = "[dbo].[Autentificare]"
            })
            {

                autentifica.Parameters.AddWithValue("@numeUtilizator", UserName.Text);
                autentifica.Parameters.AddWithValue("@parolaUtilizator", Password.Text.GetHashCode());
                autentifica.Parameters.Add("@IDUtilizator", SqlDbType.Int).Direction = ParameterDirection.Output;

                bazaLocala.Open();

                try
                {
                    autentifica.ExecuteNonQuery();

                    var rezultatAutentificare = autentifica.Parameters["@IDUtilizator"].Value;
                    IDUtilizatorAutentificat = Convert.IsDBNull(rezultatAutentificare) ? 0 : Convert.ToInt32(rezultatAutentificare);
                }
                catch
                {
                    IDUtilizatorAutentificat = 0;
                }
            }

            if (IDUtilizatorAutentificat > 0)
            {
                utilizatorAutentificat = new StructuriDeDateTableAdapters.PersonTableAdapter().GetData().Where(x => x.ID == IDUtilizatorAutentificat).First();
                this.Close();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register paginaDeInregistrare = new Register(this);

            paginaDeInregistrare.Show();
            this.Hide();
        }
    }
}
