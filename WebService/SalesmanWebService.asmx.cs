using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using InventoryBo;
using System.Data.SqlClient;
using System.Configuration;

namespace WebService
{
    /// <summary>
    /// Summary description for SalesmanWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SalesmanWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int InsertNewSalesman(SalesmanBO newSalesman)
        {
            try
            {
                SalesmanDA salesman = new SalesmanDA();
                return salesman.InsertSalesman(newSalesman);
            }

            catch
            {
                return 0;
            }

        }
        [WebMethod]

        public int UpdateSalesmanInfo(SalesmanBO newSalesman)
        {
            try
            {
                SalesmanDA salesman = new SalesmanDA();
                return salesman.UpdateSalesman(newSalesman);
            }
            catch
            {
                return 0;
            }
        }
        [WebMethod]

        public int DeleteSalesmanInfo(SalesmanBO newSalesman)
        {
            try
            {
                SalesmanDA salesman = new SalesmanDA();
                return salesman.DeleteSalesman(newSalesman);
            }
            catch
            {
                return 0;
            }
        }

    }
}
