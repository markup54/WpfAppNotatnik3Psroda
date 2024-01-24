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

namespace WpfAppNotatnik3Psroda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_Autor(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Autorem jest klasa 3P", "O autorze");
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(tekst.Text != "")
            {
                var Rezultat =MessageBox.Show("Czy na pewno chcesz usunąć zawartość", "Pytanie",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(Rezultat == MessageBoxResult.Yes)
                {
                    tekst.Text = string.Empty;
                }
                
            }
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var oknoDialogowe = new OpenFileDialog();
            //oknoDialogowe.FileName = "Dokument";
            oknoDialogowe.DefaultExt = ".txt";
            oknoDialogowe.Filter = "PlainText |*.txt";
            bool? rezultat = oknoDialogowe.ShowDialog();
            if(rezultat == true)
            {
                string nazwaPliku = oknoDialogowe.FileName;
                tekst.Text = File.ReadAllText(nazwaPliku);
            }
        }
    }
}
