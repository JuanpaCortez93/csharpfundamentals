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

namespace _019_WPF_P5_lISTbOX
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Populations> popList = new List<Populations>();
            popList.Add(new Populations() { Population1 = "Quito", Population2 = "Guayaquil", Temperature1 = 13, Temperature2 = 28, TempDiff = 15 });
            popList.Add(new Populations() { Population1 = "Cuenca", Population2 = "Manta", Temperature1 = 10, Temperature2 = 23, TempDiff = 13 });
            popList.Add(new Populations() { Population1 = "Ambato", Population2 = "Machala", Temperature1 = 15, Temperature2 = 22, TempDiff = 7 });
            popList.Add(new Populations() { Population1 = "Riobamba", Population2 = "Quevedo", Temperature1 = 12, Temperature2 = 21, TempDiff = 9 }); 
            
            foreach(var popItem in popList)
            {
                Console.WriteLine(popItem.Population1);
            }

            listaPoblaciones.ItemsSource = popList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null) MessageBox.Show((listaPoblaciones.SelectedItem as Populations).Population1 + " " + (listaPoblaciones.SelectedItem as Populations).Temperature1 + "°C" + "\n" + (listaPoblaciones.SelectedItem as Populations).Population2 + " " + (listaPoblaciones.SelectedItem as Populations).Temperature2 + "°C" + " " + (listaPoblaciones.SelectedItem as Populations).TempDiff);
            else MessageBox.Show("Selecciona un item");
        }
    }

    public class Populations
    {
        public string Population1 { get; set; }
        public double Temperature1 { get; set; }
        public string Population2 { get; set; }
        public double Temperature2 { get; set; }
        public double TempDiff { get; set; }

    }
}
