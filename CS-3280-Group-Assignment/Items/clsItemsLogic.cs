using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3280_Group_Assignment.Items
{
    class clsItemsLogic
    {
        DataSet ds;
        clsDataAccess db;

        int iRet = 0;


        public clsItemsLogic() {
            ds = new DataSet();
            db = new clsDataAccess();
        }
        /// <summary>
        /// Method to get all items.
        /// </summary>
        public DataSet getAllItems() {
            try
            {
                ds = db.ExecuteSQLStatement(clsItemsSQL.GetAllItems(), ref iRet);
            }
            catch (Exception ex) {
                throw new Exception("Unable to get all items. " + ex.ToString());
            }
           
            return ds;
        }

        /// <summary>
        /// Method to add an item.
        /// Adds an item to the database
        /// </summary>
        public DataSet addItem(string itemName, double cost)
        {
            try
            {
                ds = db.ExecuteSQLStatement(clsItemsSQL.AddItem(itemName, cost), ref iRet);
            }
            catch (Exception ex) {
                throw new Exception("Unable to add item. " + ex.ToString());
            }

            return ds;
        }

        /// <summary>
        /// Method to delete an item. 
        /// Deletes an item from the database if the item is not used in an invoice, 
        /// if it is it'll notify the user
        /// </summary>
        public DataSet deleteItem(int itemID)
        {
            try
            {
                ds = db.ExecuteSQLStatement(clsItemsSQL.DeleteItem(itemID), ref iRet);
            }
            catch (Exception ex) {
                throw new Exception("Unable to delete item. " + ex.ToString());
            }

            return ds;
        }

        /// <summary>
        /// Method to edit an item.
        /// Edits the name and the cost of the item
        /// </summary>
        public DataSet editItem(int itemID, string itemName, double cost)
        {
            try
            {
                ds = db.ExecuteSQLStatement(clsItemsSQL.EditItem(itemID, itemName, cost), ref iRet);
            }
            catch (Exception ex) {
                throw new Exception("Unable to edit item. " + ex.ToString());
            }

            return ds;
        }

        /// <summary>
        /// Method to get the invoices that the selected item is in.
        /// </summary>
/*        public DataSet getInvoicesWithItem()
        {
            try
            {

            }
            catch (Exception ex) { 
            
            }
        }*/
    }
}