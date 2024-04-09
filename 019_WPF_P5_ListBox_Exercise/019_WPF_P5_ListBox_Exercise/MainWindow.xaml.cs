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

namespace _019_WPF_P5_ListBox_Exercise
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Students> students = new List<Students>();
            students.Add(new Students { FirstName = "Felipe", LastName = "Cortez", FirstGrade = 15, SecondGrade = 10, FinalGrade = 0 });
            students.Add(new Students { FirstName = "Angel", LastName = "Torres", FirstGrade = 12, SecondGrade =  15, FinalGrade = 0 });
            students.Add(new Students { FirstName = "Alexander", LastName = "Aguirre", FirstGrade = 18, SecondGrade = 10, FinalGrade = 0 });
            students.Add(new Students { FirstName = "Magie", LastName = "Fuertes", FirstGrade = 17, SecondGrade = 10, FinalGrade = 0 });
            students.Add(new Students { FirstName = "Veronica", LastName = "Rosero", FirstGrade = 19, SecondGrade = 13, FinalGrade = 0 });

            StudentGradesList.ItemsSource = students;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (StudentGradesList.SelectedItem != null)
            {

                string text;
                double finalGrade = (StudentGradesList.SelectedItem as Students).FinalGrade;

                if (finalGrade >= 28) text = $"Pasa ({finalGrade}/40)";
                else text = $"No pasa ({(StudentGradesList.SelectedItem as Students).FinalGrade}/40)";

                MessageBox.Show((StudentGradesList.SelectedItem as Students).FirstName + " " + (StudentGradesList.SelectedItem as Students).LastName + "\n" + text);
            }
            else MessageBox.Show("Selecciona un estudiante primero");
        }

        public class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double FirstGrade { get; set; }
            public double SecondGrade { get; set; }
            public double FinalGrade { get {return FirstGrade + SecondGrade; } set { } }

        }


    }
}
