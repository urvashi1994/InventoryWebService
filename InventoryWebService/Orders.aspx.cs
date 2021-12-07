using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InventoryWebService.OrderServiceReference1;


namespace InventoryWebService
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int result;
                OrdersBO newOrder = new OrdersBO()
                {
                    OrderNo = Convert.ToInt32(txtord_no.Text),
                    PurchAmt = float.Parse(txtpurch_amt.Text),
                    OrderDate = Convert.ToDateTime(txtord_date.Text),
                    CustomerId = Convert.ToInt32(txtcustomer_id.Text),
                    SalesmanId = Convert.ToInt32(txtsalesman_id.Text)
                };

                OrderServiceReference1.OrdersWebServiceSoapClient client = new OrderServiceReference1.OrdersWebServiceSoapClient();
                result = client.InsertNewOrder(newOrder);

                if (result > 0)
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Record has been successfully inserted!!!";
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ClearFields()
        {
            txtord_no.Text = "";
            txtpurch_amt.Text = "";
            txtord_date.Text = "";
            txtcustomer_id.Text = "";
            txtsalesman_id.Text = "";
            txtord_no.Focus();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                int result;
                OrdersBO newOrder = new OrdersBO()
                {

                    OrderNo = Convert.ToInt32(txtord_no.Text),
                    PurchAmt = float.Parse(txtpurch_amt.Text),
                    OrderDate = Convert.ToDateTime(txtord_date.Text),
                    CustomerId = Convert.ToInt32(txtcustomer_id.Text),
                    SalesmanId = Convert.ToInt32(txtsalesman_id.Text)

                };
                OrderServiceReference1.OrdersWebServiceSoapClient client = new OrderServiceReference1.OrdersWebServiceSoapClient();
                result = client.UpdateOrdersInfo(newOrder);

                if (result > 0)
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Record has been updated Successfully!!!";
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ClearField()
        {
            txtord_no.Text = "";
            txtpurch_amt.Text = "";
            txtord_date.Text = "";
            txtcustomer_id.Text = "";
            txtsalesman_id.Text = "";
            txtord_no.Focus();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int result;
                OrdersBO newOrder = new OrdersBO()
                {

                    OrderNo = Convert.ToInt32(txtord_no.Text),

                };
                OrderServiceReference1.OrdersWebServiceSoapClient client = new OrderServiceReference1.OrdersWebServiceSoapClient();
                result = client.DeleteOrdersInfo(newOrder);

                if (result > 0)
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Record has been Deleted Successfully!!!";
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}