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

namespace Shifumi
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        int lose = 0;
        int win = 0;
        String[] choice = { "pierre", "feuille", "ciseaux" };
        int user = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            user = 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            user = 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int computer = random.Next(0, 3);

            if (user < 3)
            {
                counter++;
                if ((user == 0 && computer == 2) || (user == 1 && computer == 0) || (user == 2 && computer == 1))
                {
                    win++;
                    Info.Text = $"vous avez choisi { choice[user]} \nL'ordinateur avait choisi : {choice[computer]}";
                }
               else if ((user == 0 && computer == 1) || (user == 1 && computer == 2) || (user == 2 && computer == 0))
                {
                    lose++;
                    Info.Text = $"vous avez perdu { choice[user]} \nL'ordinateur avait choisi : {choice[computer]}";
                }
                Counter.Text = $"Nombre de partie {counter} vous avez gagner {win} et perdu {lose}";
                pourcentage.Text = "pourcentage de victoire " + win*100/counter + "%";
            }
        }
    }
}
