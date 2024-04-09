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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _021_BBDD_LINQ_P31_SQL_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataContextDataContext myDataContext;

        public MainWindow()
        {
            InitializeComponent();

            string myConnectionString = ConfigurationManager.ConnectionStrings["_021_BBDD_LINQ_P31_SQL_WPF.Properties.Settings.GestionPedidosConnectionLinqString"].ConnectionString;
            myDataContext = new DataContextDataContext(myConnectionString);
            //InsertCompanies();
            //InsertEmployee();
            //InsertRole();
            //InsertRoleEmployee();
            //UpdateEmployee();
            DeleteEmployee();
        }

        public void InsertCompanies()
        {
            
            myDataContext.ExecuteCommand("DELETE FROM empresas");

            empresas google = new empresas();
            google.nombre = "Google";
            myDataContext.empresas.InsertOnSubmit(google);
            myDataContext.SubmitChanges();

            empresas nexti = new empresas();
            nexti.nombre = "NexTI";
            myDataContext.empresas.InsertOnSubmit(nexti);
            myDataContext.SubmitChanges();

            companiesDataList.ItemsSource = myDataContext.empresas;
        }

        public void InsertEmployee()
        {

            myDataContext.ExecuteCommand("DELETE FROM empleados");

            empresas google = myDataContext.empresas.First(empresa => empresa.nombre.Equals("Google"));
            empresas nexti = myDataContext.empresas.First(empresa => empresa.nombre.Equals("NexTI"));
            List<empleados> employeeList = new List<empleados>();

            employeeList.Add(new empleados { nombre = "Juan", apellido = "Cortez", empresaId = google.id });
            employeeList.Add(new empleados { nombre = "Felipe", apellido = "Cortez", empresaId = nexti.id });
            employeeList.Add(new empleados { nombre = "Ximena", apellido = "Mosquera", empresaId = google.id });

            myDataContext.empleados.InsertAllOnSubmit(employeeList);
            myDataContext.SubmitChanges();
            companiesDataList.ItemsSource = myDataContext.empleados;
        }

        public void InsertRole()
        {

            myDataContext.ExecuteCommand("DELETE FROM cargos");

            cargos ceo = new cargos();
            ceo.name = "CEO";
            myDataContext.cargos.InsertOnSubmit(ceo);
            myDataContext.SubmitChanges();

            cargos developer = new cargos();
            developer.name = "Developer";
            myDataContext.cargos.InsertOnSubmit(developer);
            myDataContext.SubmitChanges();

            cargos pm = new cargos();
            pm.name = "Product Mananger";
            myDataContext.cargos.InsertOnSubmit(pm);
            myDataContext.SubmitChanges();

            companiesDataList.ItemsSource = myDataContext.cargos;

        }

        public void InsertRoleEmployee()
        {
            empleados juanCortez = myDataContext.empleados.First(empleado => empleado.nombre.Equals("Juan") && empleado.apellido.Equals("Cortez"));
            empleados felipeCortez = myDataContext.empleados.First(empleado => empleado.nombre.Equals("Felipe") && empleado.apellido.Equals("Cortez"));

            cargos ceo = myDataContext.cargos.First(cargo => cargo.name.Equals("CEO"));
            cargos developer = myDataContext.cargos.First(cargo => cargo.name.Equals("Developer"));

            //rolesEmpleados cargoJuan = new rolesEmpleados();

            //cargoJuan.empleados = juanCortez;
            //cargoJuan.cargoId = developer.id;

            //myDataContext.SubmitChanges();


            rolesEmpleados cargoFelipe = new rolesEmpleados();
            cargoFelipe.empleados = felipeCortez;
            cargoFelipe.cargoId = ceo.id;

            myDataContext.SubmitChanges();

            companiesDataList.ItemsSource = myDataContext.rolesEmpleados;

        }

        public void UpdateEmployee()
        {
            empleados juanCortez = myDataContext.empleados.First(em => em.nombre.Equals("Juan"));
            juanCortez.nombre = "Juan Pablo";
            myDataContext.SubmitChanges();
            companiesDataList.ItemsSource = myDataContext.empleados;

        }

        public void DeleteEmployee()
        {
            empleados juanCortez = myDataContext.empleados.First(em => em.nombre.Equals("Juan Pablo"));
            myDataContext.empleados.DeleteOnSubmit(juanCortez);
            myDataContext.SubmitChanges();
            companiesDataList.ItemsSource = myDataContext.empleados;

        }


    }
}
