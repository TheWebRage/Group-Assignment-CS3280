using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3280_Group_Assignment.Items
{
    class clsItemsSQL
    {
        /// <summary>
        /// Query to select everything from the Items Table.
        /// </summary>
        /// <returns></returns>
        public static string GetAllItems() {
            try
            {
                return "SELECT * FROM Items";
            }
            catch (Exception ex) {
                throw new Exception("Unable to get all items. " + ex.ToString());
            }
        }

        /// <summary>
        /// Query to add an item to the Items Table.
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="cost"></param>
        /// <returns></returns>
        public static string AddItem(string itemName, double cost)
        {
            try
            {
                return "INSERT INTO Items(ItemName, ItemCost) VALUES('" + itemName + "', " + cost + ")";
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to add item." + ex.ToString());
            }
        }

        /// <summary>
        /// Query to delete an item from the Items Table.
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns></returns>
        public static string DeleteItem(int itemID) {
            try
            {
                return "DELETE FROM Items WHERE ItemID = " + itemID;
            }
            catch (Exception ex) {
                throw new Exception("Unable to delete item." + ex.ToString());
            }
        }

        /// <summary>
        /// Query to edit an item from the Items Table.
        /// </summary>
        /// <param name="itemID"></param>
        /// <param name="itemName"></param>
        /// <param name="cost"></param>
        /// <returns></returns>
        public static string EditItem(int itemID, string itemName, double cost) {
            try {
                return "UPDATE Items SET ItemName = '" + itemName + "', ItemCost = " + cost + " WHERE" +
                    "ItemID = " + itemID;
            } catch (Exception ex) {
                throw new Exception("Unable to edit item." + ex.ToString()); 
            }
        }
    }
}
