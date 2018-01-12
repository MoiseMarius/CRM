using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRM
{
    public partial class Autentificare : Form
    {
        private const string ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=DataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static int IDUtilizatorAutentificat;

        public Autentificare()
        {
            InitializeComponent();
        }

        private void Autentificare_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection bazaLocala = new SqlConnection(ConnectionString))
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
        }
    }
}
