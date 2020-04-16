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

namespace Practice1
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

        private void TxtBxFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Testing(object sender, MouseEventArgs e)
        {
            
        }

        private void Bttn_Click(object sender, RoutedEventArgs e)
        {
            string First = TxtBxFirstName.Text;
            string Last = TxtBxLastName.Text;

            if (First == "")
            {
                MessageBox.Show("Please enter your first name");
            }
            else if (Last == "")
            {
                MessageBox.Show("Please enter your last name");
            }
            else
            {
                MessageBox.Show($"Hello {First} {Last}");
            }
        }
    }
}
