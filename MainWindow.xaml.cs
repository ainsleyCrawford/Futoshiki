using System;
using System.Windows;

namespace Futoshiki
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Exercise1 exercise1 = new Exercise1();
            exercise1.Show();
            this.Close();
        }
    }
}
