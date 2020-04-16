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

namespace WpfParticipation
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string Color;
            string Name;

            Color = txtColor.Text;
            Name = txtName.Text;

            if (Color == "purple")
            {
                MessageBox.Show("That's wild, we have the same favorite color!");
            }
            else
            {
                MessageBox.Show($"{Name} that is really cool, I never would have expected your favorite color to be {Color}");
            }
        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
