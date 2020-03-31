using System;

namespace ClassesParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox tb1 = new TextBox();
            tb1.Padding = 25;
            tb1.BackColor = ConsoleColor.Cyan;
            tb1.ForeColor = ConsoleColor.Yellow;
            tb1.Text = "ConsoleColor";

            TextBox tb2 = new TextBox();
            tb2.Padding = 25;
            tb2.BackColor = ConsoleColor.White;
            tb2.ForeColor = ConsoleColor.Black;
            tb2.Text = "ConsoleColor";

            Console.WriteLine(tb1.Text.PadLeft(50, '-').PadRight(50,'-'));
            Console.WriteLine(tb2.Text.PadLeft(50, '-').PadRight(50, '-'));

            Console.ReadKey();
        }
    }
}
