using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
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
using System.Xml;
using XmlTaskWPF.Interfaces;
using XmlTaskWPF.Models;
using XmlTaskWPF.Share;

namespace XmlTaskWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpened = false;
        private string _xmlFilePath;
        public MainWindow()
        {
            InitializeComponent();
            _logger = LoggerFactory.Create(builder => builder
                                                .SetMinimumLevel(LogLevel.Information))
                                                .CreateLogger<MainWindow>();
            _worker = new XmlDocumentWorker(_logger);
        }

        private void buttonFindCountryByName_Click(object sender, RoutedEventArgs e)
        {
            var country = _worker.FindBy(textBoxCountryName.Text);
            PrintContry(country);
        }
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            PrintContries(_worker.GetAll());
        }
        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDeleteCountryName.Text) 
                || !string.IsNullOrWhiteSpace(textBoxDeleteCountryName.Text)) 
            { 
                _worker.Delete(textBoxDeleteCountryName.Text);
                PrintContries(_worker.GetAll());
            }
        }
        private void PrintContry(Country country)
        {
            if (radioButtonTextBlock.IsChecked == true)
            {
                textBlockXmlFileContent.Visibility = Visibility.Visible;
                treeViewXmlFileContent.Visibility = Visibility.Collapsed;
                listBoxXmlFileContent.Visibility = Visibility.Collapsed;
                textBlockXmlFileContent.Text = "Note" + Environment.NewLine;
                textBlockXmlFileContent.Text += country?.ToString() ?? "Country not founds";
            }
            else if (radioButtonTreeView.IsChecked == true)
            {
                textBlockXmlFileContent.Visibility = Visibility.Collapsed;
                treeViewXmlFileContent.Visibility = Visibility.Visible;
                listBoxXmlFileContent.Visibility = Visibility.Collapsed;
                treeViewXmlFileContent.Items.Add("Note");
                treeViewXmlFileContent.Items.Add(country?.ToString() ?? "Country not founds");
            }
            else if (radioButtonListBox.IsChecked == true)
            {
                textBlockXmlFileContent.Visibility = Visibility.Collapsed;
                treeViewXmlFileContent.Visibility = Visibility.Collapsed;
                listBoxXmlFileContent.Visibility = Visibility.Visible;
                listBoxXmlFileContent.Items.Add("Note");
                listBoxXmlFileContent.Items.Add(country?.ToString() ?? "Country not founds");
            }
        }
        private void PrintContries(List<Country> countries)
        {
            if (radioButtonTextBlock.IsChecked == true)
            {
                textBlockXmlFileContent.Visibility = Visibility.Visible;
                treeViewXmlFileContent.Visibility = Visibility.Collapsed;
                listBoxXmlFileContent.Visibility = Visibility.Collapsed;
                textBlockXmlFileContent.Text = "Note" + Environment.NewLine;
                foreach (var contry in countries)
                {
                    textBlockXmlFileContent.Text += contry?.ToString();
                }
            }
            else if (radioButtonTreeView.IsChecked == true)
            {
                textBlockXmlFileContent.Visibility = Visibility.Collapsed;
                treeViewXmlFileContent.Visibility = Visibility.Visible;
                listBoxXmlFileContent.Visibility = Visibility.Collapsed;
                treeViewXmlFileContent.Items.Add("Note");
                foreach (var contry in countries)
                {
                    treeViewXmlFileContent.Items.Add(contry?.ToString());
                }
            }
            else if (radioButtonListBox.IsChecked == true)
            {
                textBlockXmlFileContent.Visibility = Visibility.Collapsed;
                treeViewXmlFileContent.Visibility = Visibility.Collapsed;
                listBoxXmlFileContent.Visibility = Visibility.Visible;
                listBoxXmlFileContent.Items.Add("Note");
                foreach (var contry in countries)
                {
                    listBoxXmlFileContent.Items.Add(contry?.ToString());
                }
            }
        }
        private void textBoxCountryName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCountryName.Text))
            {
                PrintContries(_worker.GetAll());
            }
        }
        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintContries(_worker.GetAll());
            }
        }
        private void textBlockXmlFileContent_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {

            if (_xmlFilePath != null)
            {
                _worker.Load(_xmlFilePath);
                PrintContries(_worker.GetAll());
            }
        }
        private void textBlockXmlFileContent_MouseMove1(object sender, System.Windows.Input.MouseEventArgs e)
        {

            if (_xmlFilePath != null)
            {
                _worker.Load(_xmlFilePath);
                PrintContries(_worker.GetAll());
            }
        }
        private void radioButtonTextBlock_Checked(object sender, RoutedEventArgs e)
        {
            if (_xmlFilePath != null)
                PrintContries(_worker.GetAll());

        }

        private void radioButtonTreeView_Checked(object sender, RoutedEventArgs e)
        {
            treeViewXmlFileContent.Items.Clear();
            if (_xmlFilePath != null)
                PrintContries(_worker.GetAll());
        }

        private void radioButtonListBox_Checked(object sender, RoutedEventArgs e)
        {
            listBoxXmlFileContent.Items.Clear();
            if (_xmlFilePath != null)
                PrintContries(_worker.GetAll());
        }
    }
}