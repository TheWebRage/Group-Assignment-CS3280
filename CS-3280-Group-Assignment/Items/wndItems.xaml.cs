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
using System.Windows.Shapes;

namespace CS_3280_Group_Assignment.Items
{
    /// <summary>
    /// Interaction logic for wndItems.xaml
    /// </summary>
    public partial class wndItems : Window
    {
        public wndItems()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            CS_3280_Group_Assignment.InvoiceDatabaseDataSet invoiceDatabaseDataSet = ((CS_3280_Group_Assignment.InvoiceDatabaseDataSet)(this.FindResource("invoiceDatabaseDataSet")));
            // Load data into the table Items. You can modify this code as needed.
            CS_3280_Group_Assignment.InvoiceDatabaseDataSetTableAdapters.ItemsTableAdapter invoiceDatabaseDataSetItemsTableAdapter = new CS_3280_Group_Assignment.InvoiceDatabaseDataSetTableAdapters.ItemsTableAdapter();
            invoiceDatabaseDataSetItemsTableAdapter.Fill(invoiceDatabaseDataSet.Items);
            System.Windows.Data.CollectionViewSource itemsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("itemsViewSource")));
            itemsViewSource.View.MoveCurrentToFirst();
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
