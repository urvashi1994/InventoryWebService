using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
//using InventoryBo;
//using InventoryWebService.CustomerServiceReference1.InventoryBo;
using InventoryWebService.CustomerServiceReference1;
//using WebConsumer

namespace InventoryWebService
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void BtnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                int result;
                CustomerBO newCustomer = new CustomerBO()

                {
                    CustomerId = Convert.ToInt32(txtCustomerId.Text),
                    name = txtCust_name.Text,
                    city = txtCity.Text,
                    grade = Convert.ToInt32(txtGrade.Text),
                    SalesmanId = Convert.ToInt32(txtSalesmanId.Text)
                };

                CustomerServiceReference1.CustomerWebServiceSoapClient client = new CustomerServiceReference1.CustomerWebServiceSoapClient();
                result = client.InsertNewCustomer(newCustomer);
                    
                    if (result > 0)
                    {
                        lblResult.ForeColor = System.Drawing.Color.Green;
                        lblResult.Text = "Record has been successfully inserted!!!";
                        ClearFields();
                    }

            }
            catch(Exception ex)
            {
                throw ex;
            }          
        }
        private void ClearFields()
        {
            txtCustomerId.Text = "";
            txtCust_name.Text = "";
            txtGrade.Text = "";
            txtSalesmanId.Text = "";
            txtCustomerId.Focus();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int result;
                CustomerBO newCustomer = new CustomerBO()
                {
                    CustomerId = Convert.ToInt32(txtCustomerId.Text),
                    name = txtCust_name.Text,
                    city = txtCity.Text,
                    grade = Convert.ToInt32(txtGrade.Text),
                    SalesmanId = Convert.ToInt32(txtSalesmanId.Text)
                };

                CustomerServiceReference1.CustomerWebServiceSoapClient client = new CustomerServiceReference1.CustomerWebServiceSoapClient();
                result = client.UpdateCustomerInfo(newCustomer);

                if (result > 0)
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Record has been Updated successfully !!!";
                    ClearFields();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}