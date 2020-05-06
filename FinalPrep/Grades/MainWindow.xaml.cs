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

namespace Grades
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LblFinalGrade.IsEnabled = false;            
        }

        private void BttnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double HWGrade = Convert.ToDouble(TxtBxHW.Text)*.25;
            double ParticipationGrade = Convert.ToDouble(TxtBxClassParticipation.Text)*.1;
            double QuizGrade = Convert.ToDouble(TxtBxQuiz.Text)*.1;
            double MidtermGrade = Convert.ToDouble(TxtBxMidterm.Text)*.25;
            double FinalExamGrade = Convert.ToDouble(TxtBxFinalExam.Text)*.30;
            double OverallGrade = (HWGrade + ParticipationGrade + QuizGrade + MidtermGrade + FinalExamGrade);

            LblFinalGrade.IsEnabled = true;            
            LblFinalGrade.Content = $"Your final grade is... {Convert.ToString(OverallGrade)}";
        }

        private void BttnReset_Click(object sender, RoutedEventArgs e)
        {
            TxtBxHW.Text = "Homework";
            TxtBxClassParticipation.Text = "Class Participation";
            TxtBxQuiz.Text = "Quizzes";
            TxtBxMidterm.Text = "Midterm";
            TxtBxFinalExam.Text = "Final Exam";
            
            LblFinalGrade.Content = "";
            LblFinalGrade.IsEnabled = false;
            
        }
    }
}
