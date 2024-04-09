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

namespace _019_WPF_P1_Intro
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Grid myGrid = new Grid();
            //this.Content = myGrid;

            //Button myButton = new Button();
            //myButton.Height = 150;
            //myButton.Width = 150;
            //WrapPanel myWrap = new WrapPanel();

            //TextBlock txt1 = new TextBlock();
            //txt1. Text = "Hello";
            //txt1.Foreground = Brushes.Red;
            //myWrap.Children.Add(txt1);

            //TextBlock txt2 = new TextBlock();
            //txt2.Text = "World";
            //myWrap.Children.Add(txt2);

            //myButton.Content = myWrap;

            //myGrid.Children.Add(myButton);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Hello world!");
        }

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado al panel");
        }

        //private void Panel_Click(object sender, RoutedEventArgs e)
        //{
        //    Console.WriteLine("Le has dado al panel");
        //}
    }
}
