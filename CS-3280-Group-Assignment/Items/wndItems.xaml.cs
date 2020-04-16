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
using System.Data;

namespace CS_3280_Group_Assignment.Items
{
    /// <summary>
    /// Interaction logic for wndItems.xaml
    /// </summary>
    public partial class wndItems : Window
    {
        clsItemsLogic itemsLogic;

        public wndItems()
        {
            InitializeComponent();
            itemsLogic = new clsItemsLogic();
            fillDataGrid();
        }


        private void fillDataGrid()
        {
            itemsDataGrid.ItemsSource = new DataView(itemsLogic.getAllItems().Tables[0]);
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