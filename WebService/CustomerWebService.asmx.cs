using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;
using InventoryBo;

namespace WebService
{
    /// <summary>
    /// Summary description for CustomerWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int InsertNewCustomer(CustomerBO newCustomer)
        {
            try
            {
                CustomerDA customer = new CustomerDA();
                return customer.InsertCustomer(newCustomer);
            }

            catch
            {
                return 0;
            }
        }

        [WebMethod]
        public int UpdateCustomerInfo(CustomerBO newCustomer)
        {
            CustomerDA customer = new CustomerDA();
            return customer.UpdateCustomer(newCustomer);
        }
    }
}
