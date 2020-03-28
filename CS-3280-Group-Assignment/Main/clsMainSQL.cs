using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3280_Group_Assignment.Main
{
    /// <summary>
    /// This class is to hold the sql statements needed for getting data from the database.
    /// </summary>
    class clsMainSQL
    {
        /// <summary>
        /// This is the SQL statement to get all items on an invoice. It needs to jump across the InvoiceItems table.
        /// </summary>
        /// <param name="invoiceNum">The invoice to get the items for</param>
        /// <returns>SQL string for invoice items</returns>
        public static string GetInvoiceItems(string invoiceNum)
        {
            try
            {
                return "SELECT Items.item FROM Invoices " +
                       "JOIN InvoiceItems ON InvoiceItems.InvoiceID = Invoice.InvoiceID" +
                       "JOIN Items ON Items.ItemID = InvoiceItems.ItemID" +
                       "WHERE InvoiceID = " + invoiceNum;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get invoice items." + ex.ToString());
            }
        }

        /// <summary>
        /// This is the SQL statement to get all items.
        /// </summary>
        /// <returns>SQL string for all items</returns>
        public static string GetAllItems()
        {
            try
            {
                return "SELECT ItemName FROM Items";
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get all items." + ex.ToString());
            }
        }

        /// <summary>
        /// This is the SQL statement to get all invoices
        /// </summary>
        /// <returns>SQL string for all invoices</returns>
        public static string GetAllInvoices()
        {
            try
            {
                return "SELECT * FROM Invoices";
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get all invoices." + ex.ToString());
            }
        }

        /// <summary>
        /// This adds a new invoice into the database. It will not have any items on it when first created.
        /// </summary>
        /// <param name="invoiceNum">The invoice number to create it for</param>
        /// <returns>SQL string for adding an invoice</returns>
        public static string AddInvoice(string invoiceNum)
        {
            try
            {
                return "INSERT INTO Invoices(invoiceNum) VALUES(" + invoiceNum + ")";
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to add invoice." + ex.ToString());
            }
        }

        /// <summary>
        /// This deletes an invoice at given invoiceId
        /// </summary>
        /// <param name="invoiceId">Invoice to delete</param>
        /// <returns>SQL string to delete an invoice</returns>
        public static string DeleteInvoice(int invoiceId)
        {
            try
            {
                return "DELETE FROM Invoice WHERE InvoiceID = " + invoiceId;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to delete invoice." + ex.ToString());
            }
        }

        /// <summary>
        /// This will edit a given invoice with the given information
        /// </summary>
        /// <param name="invoiceId">Invoice to edit</param>
        /// <param name="invoiceDate">Date to change to</param>
        /// <param name="invoiceTotal">Total to change to</param>
        /// <returns>SQL string to edit an invoice</returns>
        public static string EditInvoice(string invoiceId, string invoiceDate, string invoiceTotal)
        {
            try
            {
                return "UPDATE Invoices SET InvoiceDate = " + invoiceDate + ", InvoiceTotal = " 
                       + invoiceTotal + " WHERE InvoiceID = " + invoiceId;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to edit invoice." + ex.ToString());
            }
        }

        /// <summary>
        /// Add an item to an invoice
        /// </summary>
        /// <param name="invoiceId">Invoice to add item to</param>
        /// <param name="itemId">Item to add to invoice</param>
        /// <returns>SQL string to add an item to an invoice</returns>
        public static string AddItem(string invoiceId, string itemId)
        {
            try
            {
                return "INSERT INTO InvoiceItems(InvoiceID, ItemID) VALUES(" + invoiceId + ", " + itemId + ")";
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to add item." + ex.ToString());
            }
        }

        /// <summary>
        /// This removes an item from an invoice
        /// </summary>
        /// <param name="invoiceId">Invoice to remove the item from</param>
        /// <param name="itemId">Item to remove from the invoice</param>
        /// <returns>SQL string that removes the item from the invoice</returns>
        public static string RemoveItem(string invoiceId, string itemId)
        {
            try
            {
                return "DELETE FROM InvoiceItems WHERE InvoiceId = " + invoiceId + " AND ItemId = " + itemId;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to remove item." + ex.ToString());
            }
        }
    }
}
