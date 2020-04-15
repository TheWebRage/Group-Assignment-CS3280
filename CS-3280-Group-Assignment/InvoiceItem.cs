using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CS_3280_Group_Assignment
{
    public class InvoiceItem
    {
        public string invoiceItemId;
        public string invoiceItemName;
        public string invoiceItemCost;

        public override string ToString()
        {
            try
            {
                return invoiceItemName;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
