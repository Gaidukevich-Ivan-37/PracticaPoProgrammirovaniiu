using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
            textBlockXMLFileContent.Text = "=======Country=======" 
                + Environment.NewLine;
            textBlockXMLFileContent.Text += country?.ToString() ?? "Country not found";
        }
        private void PrintContries(List<Country> countries)
        {
            textBlockXMLFileContent.Text = "=======Countries======="
                + Environment.NewLine;
            foreach (var country in countries)
            {
                textBlockXMLFileContent.Text += country.ToString(); 
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
    }
}