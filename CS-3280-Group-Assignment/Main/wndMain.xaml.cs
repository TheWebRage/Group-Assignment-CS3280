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
using CS_3280_Group_Assignment.Search;

namespace CS_3280_Group_Assignment
{
    /// <summary>
    /// Interaction logic for wndMain.xaml
    /// </summary>
    public partial class wndMain : Window
    {
        /// <summary>
        /// This is the main window that will allow the user to create new invoices,
        ///  add items, remove items, delete invoices, and navigate to other windows.
        /// </summary>
        public wndMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This button will add an existing item to an invoice
        /// </summary>
        private void addItemButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This will create a new invoice. It will not have any items on it initially.
        /// </summary>
        private void addInvoice_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This will submit the edits made to invoices
        /// </summary>
        private void madeEditsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This will delete the selected invoice
        /// </summary>
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This will open the search window and hide this window
        /// </summary>
        private void searchLink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wndSearch searchWindow = new wndSearch(this);
                searchWindow.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to open Search window. " + exception.ToString(), "Error - Open Search Window",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        /// <summary>
        /// THis will open the items window and hide this window
        /// </summary>
        private void itemsLink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wndItems itemsWindow = new wndItems(this);
                itemsWindow.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to open Items window. " + exception.ToString(), "Error - Open Items Window",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
