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

namespace AplikacjaPrzelicznik {
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Window1 window1 = new Window1();
        Window2 window2 = new Window2();
        Window3 window3 = new Window3();

        public MainWindow() {
            InitializeComponent();
        }

        private void OtworzWaluty(object sender, RoutedEventArgs e) {
            window1.Show();
        }

        private void OtworzDlugosci(object sender, RoutedEventArgs e) {
            window2.Show();
        }

        private void OtworzMasy(object sender, RoutedEventArgs e) {
            window3.Show();
        }
    }
}
