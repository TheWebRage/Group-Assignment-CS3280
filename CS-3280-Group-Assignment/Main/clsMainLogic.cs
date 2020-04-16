using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CS_3280_Group_Assignment.Main
{
    public class clsMainLogic
    {
        /// <summary>
        /// This holds the SQL operations for performing the actions to the database
        /// </summary>
        private clsMainSQL _sqlOperations;


        /// <summary>
        /// This is the list of all invoices in the database
        /// </summary>
        public List<Invoice> invoices;

        /// <summary>
        /// This is the list of items in the currently selected invoice
        /// </summary>
        public List<InvoiceItem> invoiceItems;

        /// <summary>
        /// This is the DataSet used to load the invoices data grid
        /// </summary>
        public DataSet InvoicesDataSet;

        /// <summary>
        /// This is the DataSet used to load the invoice items data grid
        /// </summary>
        public DataSet InvoiceItemsDataSet;

        /// <summary>
        /// Constructor call for the main logic class for the invoices
        /// </summary>
        public clsMainLogic()
        {
            try
            {
                _sqlOperations = new clsMainSQL();
                GetInvoices();
                GetInvoiceItems("1");
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to create main logic object." + ex.ToString());
            }
        }

        /// <summary>
        /// This gets all of the invoices in the database and saves them in the invoices data member
        /// </summary>
        public void GetInvoices()
        {
            try
            {
                InvoicesDataSet = _sqlOperations.GetInvoices();
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get invoices." + ex.ToString());
            }
        }

        /// <summary>
        /// This gets all of the items in the currently selected invoice
        /// </summary>
        public void GetInvoiceItems(string invoiceId)
        {
            try
            {
                InvoiceItemsDataSet = _sqlOperations.GetAllInvoiceItems(invoiceId);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get invoice items." + ex.ToString());
            }
        }

        /// <summary>
        /// This will update the invoices and invoiceItems lists
        /// </summary>
        public void UpdateInvoicesAndInvoiceItems(string invoiceId = "1")
        {
            try
            {
                GetAllInvoices();
                GetInvoiceItems(invoiceId);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to update invoices and invoice items lists." + ex.ToString());
            }
        }

        /// <summary>
        /// This will add the item to the invoice
        /// </summary>
        public void AddItemToInvoice(string invoiceId, string itemId)
        {
            try
            {
                _sqlOperations.AddItem(invoiceId, itemId);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to add item to invoice." + ex.ToString());
            }
        }

        /// <summary>
        /// This will add the item to the invoice
        /// </summary>
        public List<InvoiceItem> GetAllItems()
        {
            try
            {
                return _sqlOperations.GetAllItems();
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to add item to invoice." + ex.ToString());
            }
        }

        /// <summary>
        /// This will add the list of invoices to the data member
        /// </summary>
        public void GetAllInvoices()
        {
            try
            {
                invoices = _sqlOperations.GetAllInvoices();
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to add item to invoice." + ex.ToString());
            }
        }

        /// <summary>
        /// This will delete the currently selected item from the invoice
        /// </summary>
        public void DeleteItemFromInvoice()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception("Unable to delete item from invoice." + ex.ToString());
            }
        }

        /// <summary>
        /// This will add a new invoice. It will not have any items with it until the user adds items
        /// </summary>
        public void AddNewInvoice()
        {
            try
            { 
                _sqlOperations.AddInvoice(DateTime.Now.ToString());
                // TODO: update the selected invoice to the newly created one
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to add invoice." + ex.ToString());
            }
        }

        /// <summary>
        /// This will save all the edits made in the window
        /// </summary>
        public void SaveEdits()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception("Unable to save edits." + ex.ToString());
            }
        }

        /// <summary>
        /// This will delete the selected invoice.
        /// </summary>
        public void DeleteInvoice(string invoiceId)
        {
            try
            {
                _sqlOperations.DeleteInvoice(invoiceId);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to delete invoice." + ex.ToString());
            }
        }
    }
}
