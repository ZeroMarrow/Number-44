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

namespace Number_44
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ballas1_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(Ballas.Text);
            {
                if (n >= 1 || n <= 31) ;
            else
            {
                Ballas.Text = "Мимо";
            }
                int d = int.Parse(Ballas.Text);
                switch (d)
                {
                    case 1: Result.Text = "Лев"
                }
            }
            }
        }
    }

