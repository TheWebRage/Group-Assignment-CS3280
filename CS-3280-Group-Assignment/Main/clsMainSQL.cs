using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CS_3280_Group_Assignment.Main
{
    /// <summary>
    /// This class is to hold the sql statements needed for getting data from the database.
    /// </summary>
    public class clsMainSQL
    {
        /// <summary>
        /// This is the connection to the database used for keeping track of the information
        /// </summary>
        private clsDataAccess db;

        /// <summary>
        /// This is the constructor for the sql class. This handles the actions to the database.
        /// </summary>
        public clsMainSQL()
        {
            try
            {
                db = new clsDataAccess();
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to create." + ex.ToString());
            }
        }

        /// <summary>
        /// This is the SQL statement to get all items.
        /// </summary>
        /// <returns>SQL string for all items</returns>
        public List<InvoiceItem> GetAllItems()
        {
            try
            {
                string sSQL = "SELECT * FROM Items";
                int iRet = 0;
                DataSet ds = new DataSet();

                InvoiceItem invoiceItem;
                List<InvoiceItem> invoiceItems = new List<InvoiceItem>();

                ds = db.ExecuteSQLStatement(sSQL, ref iRet);

                for (int i = 0; i < iRet; i++)
                {
                    invoiceItem = new InvoiceItem();
                    invoiceItem.invoiceItemId = ds.Tables[0].Rows[i][0].ToString();
                    invoiceItem.invoiceItemName = ds.Tables[0].Rows[i][1].ToString();
                    invoiceItem.invoiceItemCost = ds.Tables[0].Rows[i][2].ToString();

                    invoiceItems.Add(invoiceItem);
                }
                return invoiceItems;
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
        public List<Invoice> GetAllInvoices()
        {
            try
            {
                string sSQL = "SELECT * FROM Invoices";
                int iRet = 0;
                DataSet ds = new DataSet();

                Invoice invoice;
                List<Invoice> invoices = new List<Invoice>();

                ds = db.ExecuteSQLStatement(sSQL, ref iRet);

                for (int i = 0; i < iRet; i++)
                {
                    invoice = new Invoice();
                    invoice.invoiceId = ds.Tables[0].Rows[i][0].ToString();
                    invoice.invoiceDate = ds.Tables[0].Rows[i][1].ToString();
                    invoice.invoiceTotal = ds.Tables[0].Rows[i][2].ToString();

                    invoices.Add(invoice);
                }
                return invoices;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get all invoices." + ex.ToString());
            }
        }

        /// <summary>
        /// This is the SQL statement to get all invoices
        /// </summary>
        /// <returns>SQL string for all invoices</returns>
        public List<InvoiceItem> GetAllInvoiceItems(string invoiceId)
        {
            try
            {
                string sSQL = "SELECT Items.item FROM Invoices " +
                              "JOIN InvoiceItems ON InvoiceItems.InvoiceID = Invoice.InvoiceID" +
                              "JOIN Items ON Items.ItemID = InvoiceItems.ItemID" +
                              "WHERE InvoiceID = " + invoiceId;
                int iRet = 0;
                DataSet ds = new DataSet();

                List<InvoiceItem> invoiceItems = new List<InvoiceItem>();

                ds = db.ExecuteSQLStatement(sSQL, ref iRet);

                for (int i = 0; i < iRet; i++)
                {
                    InvoiceItem invoiceItem = new InvoiceItem();
                    invoiceItem.invoiceItemId = ds.Tables[0].Rows[i][0].ToString();
                    invoiceItem.invoiceItemName = ds.Tables[0].Rows[i][1].ToString();
                    invoiceItem.invoiceItemCost = ds.Tables[0].Rows[i][2].ToString();

                    invoiceItems.Add(invoiceItem);
                }
                return invoiceItems;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get all invoices." + ex.ToString());
            }
        }

        /// <summary>
        /// This adds a new invoice into the database. It will not have any items on it when first created.
        /// </summary>
        /// <param name="invoiceDateTime">The date of the invoice (Defaults to today)</param>
        /// <returns>SQL string for adding an invoice</returns>
        public void AddInvoice(string invoiceDateTime)
        {
            try
            {
                string sSQL = "INSERT INTO Invoices(InvoiceDate) VALUES(" + invoiceDateTime + ");";
                db.ExecuteNonQuery(sSQL);
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
        public void DeleteInvoice(string invoiceId)
        {
            try
            {
                string sSQL = "DELETE FROM Invoice WHERE InvoiceID = " + invoiceId + ";";
                db.ExecuteNonQuery(sSQL);
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
        public void EditInvoice(string invoiceId, string invoiceDate, string invoiceTotal)
        {
            try
            {
                string sSQL = "UPDATE Invoices SET InvoiceDate = " + invoiceDate + ", InvoiceTotal = " 
                       + invoiceTotal + " WHERE InvoiceID = " + invoiceId;
                db.ExecuteNonQuery(sSQL);
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
        /// <param name="itemId">InvoiceItem to add to invoice</param>
        /// <returns>SQL string to add an item to an invoice</returns>
        public void AddItem(string invoiceId, string itemId)
        {
            try
            {
                string sSQL = "INSERT INTO InvoiceItems(InvoiceID, ItemID) VALUES(" + invoiceId + ", " + itemId + ")";
                db.ExecuteNonQuery(sSQL);
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
        /// <param name="itemId">InvoiceItem to remove from the invoice</param>
        /// <returns>SQL string that removes the item from the invoice</returns>
        public void RemoveItem(string invoiceId, string itemId)
        {
            try
            {
                string sSQL = "DELETE FROM InvoiceItems WHERE InvoiceId = " + invoiceId + " AND ItemId = " + itemId;
                db.ExecuteNonQuery(sSQL);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to remove item." + ex.ToString());
            }
        }
    }
}
