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

namespace HelloWorldWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonRun.Click += buttonRun_Click;
            buttonAbout.Click += buttonAbout_Click;
        }
        private void buttonAbout_Click(object sender, RoutedEventArgs e)
        {
            string info = $"О программе {this.Title}";
            AboutApp aboutApp = new AboutApp(info);
            aboutApp.ShowDialog();
        }
        private void buttonRun_Click(object sender, RoutedEventArgs e)
        {
            textBoxEnterName.Text = textBoxEnter.Text;
        }
        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void textBoxEnter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string input = string.Empty;
            input = textBoxEnter.Text;
        }
    }
}
