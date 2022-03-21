using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace FootballLeagues
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://www.bundesliga.com/en/bundesliga";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://www.legaseriea.it/en";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://www.laliga.com/en-GB";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://www.ligue1.com/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://www.premierleague.com/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://www.ligaportugal.pt/pt/homepage/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://www.proleague.be/nl/jpl";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://eredivisie.nl/home/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://www.ligaprofesional.ar/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://brasileirao.cbf.com.br/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://www.tff.org/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void Btn12_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://spfl.co.uk/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://ru.uefa.com/uefachampionsleague/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://ru.uefa.com/uefaeuropaleague/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            var url = "https://www.conmebol.com/";
            var info = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            };
            Process.Start(info);
        }
    }
}
