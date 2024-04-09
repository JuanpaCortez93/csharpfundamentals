using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace _020_BBDD_SQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection mySqlConnection = null;

        public MainWindow()
        {
            InitializeComponent();

            string myConnectionString = ConfigurationManager.ConnectionStrings["_020_BBDD_SQL.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            mySqlConnection = new SqlConnection(myConnectionString);
            ShowClients();
            ShowAllDeliveries();

        }

        private void ShowClients()
        {
            try
            {
                string sqlQuery = "SELECT * FROM clientes";
                SqlDataAdapter mySQLAdapter = new SqlDataAdapter(sqlQuery, mySqlConnection);
                using (mySQLAdapter)
                {
                    DataTable clientsTable = new DataTable();
                    mySQLAdapter.Fill(clientsTable);
                    clientList.DisplayMemberPath = "nombre";
                    clientList.SelectedValuePath = "id";
                    clientList.ItemsSource = clientsTable.DefaultView;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ShowAllDeliveries()
        {
            try
            {
                string sqlQuery = "SELECT *, CONCAT(nombre, '. ', formaPago, ' (', fechaPedido, ')') AS INFOCOMPLETA FROM pedidos INNER JOIN clientes ON pedidos.cCliente = clientes.id";
                SqlDataAdapter mySQLAdapater = new SqlDataAdapter(sqlQuery, mySqlConnection);
                using (mySQLAdapater)
                {
                    DataTable deliveriesTable = new DataTable();
                    mySQLAdapater.Fill(deliveriesTable);
                    allDeliveriesList.DisplayMemberPath = "INFOCOMPLETA";
                    allDeliveriesList.SelectedValuePath = "id";
                    allDeliveriesList.ItemsSource = deliveriesTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ShowDeliveries()
        {
            try
            {
                string sqlQuery = "SELECT * FROM pedidos INNER JOIN clientes ON pedidos.cCliente = clientes.id WHERE clientes.id = @clienteId";
                SqlCommand mySQLCommand = new SqlCommand(sqlQuery, mySqlConnection);

                SqlDataAdapter mySQLAdapter = new SqlDataAdapter(mySQLCommand);
                using (mySQLAdapter)
                {

                    mySQLCommand.Parameters.AddWithValue("@clienteId", clientList.SelectedValue);

                    DataTable deliveriesTable = new DataTable();
                    mySQLAdapter.Fill(deliveriesTable);
                    deliverList.DisplayMemberPath = "fechaPedido";
                    deliverList.SelectedValuePath = "id";
                    deliverList.ItemsSource = deliveriesTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(allDeliveriesList.SelectedValue.ToString());

            try
            {
                string sqlQuery = "DELETE FROM pedidos WHERE id=@pedidoId";
                SqlCommand mySqlCommand = new SqlCommand(sqlQuery, mySqlConnection);
                mySqlConnection.Open();
                mySqlCommand.Parameters.AddWithValue("@pedidoId", allDeliveriesList.SelectedValue.ToString());
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();

                ShowAllDeliveries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string sqlQuery = "INSERT INTO clientes (nombre, direccion, poblacion, telefono) VALUES (@name, @address, @city, @telephone)";
                SqlCommand mySqlCommand = new SqlCommand(sqlQuery, mySqlConnection);
                mySqlConnection.Open();
                mySqlCommand.Parameters.AddWithValue("@name", clientBox.Text);
                mySqlCommand.Parameters.AddWithValue("@address", addressBox.Text);
                mySqlCommand.Parameters.AddWithValue("@city", cityBox.Text);
                mySqlCommand.Parameters.AddWithValue("@telephone", telephoneBox.Text);
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();

                clientBox.Text = "";
                addressBox.Text = "";
                cityBox.Text = "";
                telephoneBox.Text = "";

                ShowClients();
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string sqlQuery = "DELETE FROM clientes WHERE id=@clienteId";
                SqlCommand mySqlCommand = new SqlCommand(sqlQuery, mySqlConnection);
                mySqlConnection.Open();
                mySqlCommand.Parameters.AddWithValue("@clienteId", clientList.SelectedValue.ToString());
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();

                ShowClients();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clientList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ShowDeliveries();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            EditClient editActualClient = new EditClient((int)clientList.SelectedValue);
            

            try
            {

                if(clientList.SelectedValue != null)
                {
                    
                    string sqlQuery = "SELECT * FROM clientes WHERE id = @clientId";
                    SqlCommand mySqlCommand = new SqlCommand(sqlQuery, mySqlConnection);
                    SqlDataAdapter mySQLAdapter = new SqlDataAdapter(mySqlCommand);
                    using (mySQLAdapter)
                    {

                        mySqlCommand.Parameters.AddWithValue("@clientId", clientList.SelectedValue);

                        DataTable clientsTable = new DataTable();
                        mySQLAdapter.Fill(clientsTable);

                        editActualClient.clientBoxUpdate.Text = clientsTable.Rows[0]["nombre"].ToString();
                        editActualClient.addressBoxUpdate.Text = clientsTable.Rows[0]["direccion"].ToString();
                        editActualClient.cityBoxUpdate.Text = clientsTable.Rows[0]["poblacion"].ToString();
                        editActualClient.telephoneBoxUpdate.Text = clientsTable.Rows[0]["telefono"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente");
                }

                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            editActualClient.ShowDialog();
            ShowClients();

        }
    }
}
