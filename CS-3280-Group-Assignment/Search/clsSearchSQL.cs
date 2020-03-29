using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3280_Group_Assignment.Search
{
    class clsSearchSQL
    {
        /// <summary>
        /// This SQL gets a distinct list of the dates from all invoices
        /// </summary>
        /// <returns></returns>
        public string SelectInvoiceDate()
        {
            try
            {
                return "SELECT DISTINCT InvoiceDate FROM Invoices";
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get invoice dates");
            }
        }

        /// <summary>
        /// This SQL gets a list of all invoice numbers 
        /// </summary>
        /// <returns></returns>
        public string SelectInvoiceNum()
        {
            try
            {
                return "SELECT InvoiceID FROM Invoices";
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get invoice numbers");
            }
            
        }

        /// <summary>
        /// This SQL gets a distinct list of of the total charges from all invoices
        /// </summary>
        /// <returns></returns>
        public string SelectInvoiceTotal()
        {
            try
            {
                return "SELECT DISTINCT InvoiceTotal FROM Invoices";
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get invoice totals");
            }
            
        }

        /// <summary>
        /// This SQL gets a list of the invoices that correspond with the selected criteria from the group boxes
        /// </summary>
        /// <param name="invoiceID"></param>
        /// <param name="invoiceTotal"></param>
        /// <param name="invoiceDate"></param>
        /// <returns></returns>
        public string UpdateInvoiceList(string invoiceID = "", string invoiceTotal = "", string invoiceDate = "")
        {
            try
            {
                //If there is no criteria, select all invoices
                if (invoiceID == "" && invoiceTotal == "" && invoiceDate == "")
                    return "SELECT * FROM Invoices";

                //If there is criteria, create the appropriate select statement
                string sSQL = "SELECT * FROM Invoices WHERE ";
                if (invoiceID != "")
                {
                    sSQL += "InvoiceID = " + invoiceID;
                    if (invoiceDate != "" || invoiceTotal != "")
                        sSQL += " AND ";
                }
                if (invoiceDate != "")
                {
                    sSQL += "InvoiceDate = " + invoiceDate;
                    if (invoiceTotal != "")
                        sSQL += " AND ";
                }
                if (invoiceTotal != "")
                {
                    sSQL += "InvoiceTotal = " + invoiceTotal;
                }
                return sSQL;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to get list of invoices");
            }
            
        }
    }
}
