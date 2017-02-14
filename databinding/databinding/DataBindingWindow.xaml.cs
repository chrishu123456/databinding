using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DataBindingWindow : Window
    {
        public databinding.Persoon persoon = new databinding.Persoon("chris",4345, new DateTime(2015,10,5));

        public DataBindingWindow()
        {
            InitializeComponent();

            SortDescription sd = new SortDescription("Source",ListSortDirection.Ascending);
            lettertypeComboBox.Items.SortDescriptions.Add(sd);
            lettertypeComboBox.SelectedItem = new FontFamily("Arial");
            Veranderpanel.DataContext = persoon;
        }


        private void toonnaambutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(persoon.Naam);
        }

        private void veranderbutton_Click(object sender, RoutedEventArgs e)
        {
            persoon.Naam = "piet";
            persoon.Wedde = 3424.5m;
            persoon.InDienst = new DateTime(2016, 8, 5);
        }
    }
}
