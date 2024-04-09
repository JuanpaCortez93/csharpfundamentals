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

namespace _019_WPF_P6_ComboBox_CheckBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitals> capitalList = new List<Capitals>();
            capitalList.Add(new Capitals() { Name = "Quito" });
            capitalList.Add(new Capitals() { Name = "Lima" });
            capitalList.Add(new Capitals() { Name = "La Paz" });
            capitalList.Add(new Capitals() { Name = "Santiago" });
            capitalList.Add(new Capitals() { Name = "Buenos Aires" });
            capitalList.Add(new Capitals() { Name = "Asunción" });
            capitalList.Add(new Capitals() { Name = "Rio de Janeiro" });
            capitalList.Add(new Capitals() { Name = "Montevideo" });
            capitalList.Add(new Capitals() { Name = "Bogotá" });
            capitalList.Add(new Capitals() { Name = "Caracas" });

            Capitals.ItemsSource = capitalList;

        }

        private void AllCountries_Checked(object sender, RoutedEventArgs e)
        {
            Venezuela.IsChecked = true;
            Colombia.IsChecked = true;
            Ecuador.IsChecked = true;
            Peru.IsChecked = true;
            Bolivia.IsChecked = true;
            Chile.IsChecked = true;
            Argentina.IsChecked = true;
            Uruguay.IsChecked = true;
            Paraguay.IsChecked = true;
            Brasil.IsChecked = true;
        }

        private void AllCountries_Unchecked(object sender, RoutedEventArgs e)
        {
            Venezuela.IsChecked = false;
            Colombia.IsChecked = false;
            Ecuador.IsChecked = false;
            Peru.IsChecked = false;
            Bolivia.IsChecked = false;
            Chile.IsChecked = false;
            Argentina.IsChecked = false;
            Uruguay.IsChecked = false;
            Paraguay.IsChecked = false;
            Brasil.IsChecked = false;
        }

        private void Capital_Checked(object sender, RoutedEventArgs e)
        {
            if (Venezuela.IsChecked == true && Colombia.IsChecked == true && Ecuador.IsChecked == true && Peru.IsChecked == true && Bolivia.IsChecked == true && Chile.IsChecked == true && Argentina.IsChecked == true && Uruguay.IsChecked == true && Paraguay.IsChecked == true && Brasil.IsChecked == true)
            {
                AllCountries.IsChecked = true;
            }
            else
            {
                AllCountries.IsChecked = false;
            }
        }

        private void Capital_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!(Venezuela.IsChecked == true && Colombia.IsChecked == true && Ecuador.IsChecked == true && Peru.IsChecked == true && Bolivia.IsChecked == true && Chile.IsChecked == true && Argentina.IsChecked == true && Uruguay.IsChecked == true && Paraguay.IsChecked == true && Brasil.IsChecked == true))
            {
                AllCountries.IsChecked = false;
            }
            else
            {
                AllCountries.IsChecked = true;
            }
        }
    }

    public class Capitals
    {
        public string Name { get; set; }
    }
}
