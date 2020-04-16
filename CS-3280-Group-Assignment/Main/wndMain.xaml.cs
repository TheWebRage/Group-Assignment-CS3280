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
using CS_3280_Group_Assignment.Items;
using CS_3280_Group_Assignment.Main;
using CS_3280_Group_Assignment.Search;

namespace CS_3280_Group_Assignment
{
    /// <summary>
    /// Interaction logic for wndMain.xaml
    /// </summary>
    public partial class wndMain : Window
    {
        /// <summary>
        /// This is the logic class used for performing the operations on the back end
        /// </summary>
        private readonly clsMainLogic _logic;

        /// <summary>
        /// This is the main window that will allow the user to create new invoices,
        ///  add items, remove items, delete invoices, and navigate to other windows.
        /// </summary>
        public wndMain()
        {
            try
            {
                InitializeComponent();

                // TODO: get styles integrated
                _logic = new clsMainLogic();

                invoicesDataGrid.ItemsSource = _logic.InvoicesDataSet.Tables[0].DefaultView;
                invoicesDataGrid.SelectedIndex = 0;

                invoiceItemsDataGrid.ItemsSource = _logic.InvoiceItemsDataSet.Tables[0].DefaultView;
                invoiceItemsDataGrid.SelectedIndex = 0;

                itemsComboBox.ItemsSource = _logic.GetAllItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to create main window. " + ex.ToString(), "Error - wndMain constructor",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        /// <summary>
        /// This returns the selected invoice id
        /// </summary>
        /// <returns>The current invoice id as a string</returns>
        public string GetCurrentSelectedInvoiceId()
        {
            try
            {
                foreach (Invoice invoice in _logic.invoices)
                    if (invoice.ToString() == invoicesDataGrid.SelectedItem.ToString())
                        return invoice.invoiceId.ToString();

                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get current selected invoice. " + ex.ToString(), "Error - GetCurrentSelectedInvoiceId",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return "";
            }
        }

        /// <summary>
        /// This returns the current selected item id
        /// </summary>
        /// <returns>The current item id as a string</returns>
        public string GetCurrentSelectedItemId()
        {
            try
            {
                foreach (InvoiceItem invoiceItem in _logic.invoiceItems)
                    if (invoiceItem.ToString() == invoiceItemsDataGrid.SelectedItem.ToString())
                        return invoiceItem.invoiceItemId.ToString();

                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get current selected item. " + ex.ToString(), "Error - GetCurrentSelectedItemId",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return "";
            }
        }

        /// <summary>
        /// This button will add an existing item to an invoice
        /// </summary>
        private void addItemButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _logic.AddItemToInvoice(GetCurrentSelectedInvoiceId(), itemsComboBox.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add item. " + ex.ToString(), "Error - addItemButton_Click",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        /// <summary>
        /// This will create a new invoice. It will not have any items on it initially.
        /// </summary>
        private void addInvoice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _logic.AddNewInvoice();
                invoicesDataGrid.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add invoice. " + ex.ToString(), "Error - addInvoice_Click",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        /// <summary>
        /// This will delete the selected invoice
        /// </summary>
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _logic.DeleteInvoice(invoicesDataGrid.SelectedItem.ToString());
                invoicesDataGrid.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete invoice. " + ex.ToString(), "Error - deleteButton_Click",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        /// <summary>
        /// This will open the search window and hide this window
        /// </summary>
        private void searchLink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wndSearch searchWindow = new wndSearch();
                this.Hide();
                // TODO: get value to become current selected invoice in invoiceDataGrid
                searchWindow.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open Search window. " + ex.ToString(), "Error - Open Search Window",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        /// <summary>
        /// This will open the items window and hide this window
        /// </summary>
        private void itemsLink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wndItems itemsWindow = new wndItems();
                this.Hide();
                itemsWindow.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open Items window. " + ex.ToString(), "Error - Open Items Window",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
