using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CS_3280_Group_Assignment.Search
{
    /// <summary>
    /// Interaction logic for wndSearch.xaml
    /// </summary>
    public partial class wndSearch : Window
    {

        /// <summary>
        /// Fills groupboxes and datagrid with all invoices
        /// </summary>
        public wndSearch()
        {
            InitializeComponent();

            //Call methods to fill groupboxes and datagrid
        }

        /// <summary>
        /// Hide search window and display main window. Returns the selected invoice with a setter method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to close Search window. " + exception.ToString(), "Error - Close Search Window",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        /// <summary>
        /// Hides search window and displays main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to close Search window. " + exception.ToString(), "Error - Close Search Window",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        /// <summary>
        /// Retrieves and displays all invoices. Resets all groupboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Retrieves and displays new invoice list depending on which invoice number was selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void invNumBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// Retrieves and displays new invoice list depending on which invoice date was selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void invDateBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// Retrieves and displays new invoice list depending on which invoice total was selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void totalChargeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
