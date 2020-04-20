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

namespace WPFParticipation2
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

        private void RBEven_Checked(object sender, RoutedEventArgs e)
        {
            int LimitE = Convert.ToInt32(TxtBox.Text);
            int valE = 0;
            for (int i = 2; i <= LimitE; i = i + 2)
            {
                LBEven.Items.Add(i);
            }
                        
        }

        private void RBOdd_Checked(object sender, RoutedEventArgs e)
        {

            int LimitO = Convert.ToInt32(TxtBox.Text);
            
            int valO = 0;

            for (int i = 1; i <= LimitO; i = i + 2)
            {
                LBOdd.Items.Add(i);
            }
            
            
        }

        private void TxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
