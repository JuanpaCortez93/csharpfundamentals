using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _020_BBDD_SQL
{
    /// <summary>
    /// Lógica de interacción para EditClient.xaml
    /// </summary>
    public partial class EditClient : Window
    {
        private int _id;
        SqlConnection mySqlConnection = null;

        public EditClient()
        {
            InitializeComponent();
            string myConnectionString = ConfigurationManager.ConnectionStrings["_020_BBDD_SQL.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            mySqlConnection = new SqlConnection(myConnectionString);

        }

        public EditClient(int z)
        {
            InitializeComponent();
            string myConnectionString = ConfigurationManager.ConnectionStrings["_020_BBDD_SQL.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            mySqlConnection = new SqlConnection(myConnectionString);
            _id = z;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = new MainWindow();

            try
            {

                string sqlQuery = "UPDATE clientes SET nombre = @clientName, direccion = @address, poblacion = @city, telefono = @telephone WHERE id = " + _id;

                SqlCommand mySqlCommand = new SqlCommand(sqlQuery, mySqlConnection);
                mySqlConnection.Open();
                mySqlCommand.Parameters.AddWithValue("@clientName", clientBoxUpdate.Text);
                mySqlCommand.Parameters.AddWithValue("@address", addressBoxUpdate.Text);
                mySqlCommand.Parameters.AddWithValue("@city", cityBoxUpdate.Text);
                mySqlCommand.Parameters.AddWithValue("@telephone", telephoneBoxUpdate.Text);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                this.Close(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
