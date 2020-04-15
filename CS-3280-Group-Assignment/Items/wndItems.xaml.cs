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
using System.ComponentModel;

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

        /// <summary>
        /// Add item button click event, which will add an item to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Edit item button click event, which will edit the name of the item and the cost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditItem_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Delete Item button click event, which will delete the item if the item is not being used in an invoice,
        /// if the item is being used in the invoice it'll tell the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}