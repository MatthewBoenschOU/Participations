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

namespace WPF_Student_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LBStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public static void Main(string [] args)
        {
            string ID = "";
            string FirstName = "";
            string LastName = "";
            string FavColor = "";
            string AllTogetherNow = $"{FirstName} {LastName} ({ID}) has a favorite color of {FavColor})";

            var path = @"c:/Users/Niels/desktop/studentdataRandom10Rows.cvs";

            



        }

    }
}
