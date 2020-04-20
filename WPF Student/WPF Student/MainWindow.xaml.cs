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

namespace WPF_Student
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

        private void TxtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BttnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string FirstName = TxtFirstName.Text;
            string LastName = TxtLastName.Text;
            string StudentID = TxtStudentID.Text;
            string FavColor = TxtFavoriteColor.Text;
            
            string AllTogetherNow = $"{LastName}, {FirstName} ({StudentID}) has a favorite color of {FavColor}";

            LBStudents.Items.Add(AllTogetherNow);
                       
            TxtFirstName.Text = "Enter First Name";
            TxtLastName.Text = "Enter Last Name";
            TxtStudentID.Text = "Enter Student ID";
            TxtFavoriteColor.Text = "Enter Favorite Color";
                       
        }

       
    }
}
