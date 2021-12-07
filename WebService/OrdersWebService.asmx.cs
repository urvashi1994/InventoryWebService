using InventoryBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;


namespace WebService
{
    /// <summary>
    /// Summary description for OrdersWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrdersWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int InsertNewOrder(OrdersBO newOrder)
        {
            try
            {
                OrdersDA order = new OrdersDA();
                return order.InsertOrder(newOrder);
            }

            catch
            {
                return 0;
            }
        }

        [WebMethod]
        public int UpdateOrdersInfo(OrdersBO newOrder)
        {
            try
            {
                OrdersDA order = new OrdersDA();
                return order.UpdateOrder(newOrder);
            }

            catch
            {
                return 0;
            }
        }

        [WebMethod]
        public int DeleteOrdersInfo(OrdersBO newOrder)
        {
            try
            {
                OrdersDA order = new OrdersDA();
                return order.DeleteOrder(newOrder);
            }

            catch
            {
                return 0;
            }
        }
    }
}
