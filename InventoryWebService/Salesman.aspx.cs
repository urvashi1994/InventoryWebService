using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InventoryWebService.SalesmanServiceReference1;
//using InventoryBo;


namespace InventoryWebService
{
    public partial class Salesman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int result;
                SalesmanBO newSalesman = new SalesmanBO()

                {
                    SalesmanId = Convert.ToInt32(txtSalesmanId.Text),
                    Name = txtSalesman_name.Text,
                    City = txtCity.Text,
                    Commission = float.Parse(txtCommission.Text)

                };

                SalesmanServiceReference1.SalesmanWebServiceSoapClient client1 = new SalesmanServiceReference1.SalesmanWebServiceSoapClient();
                result = client1.InsertNewSalesman(newSalesman);

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
            txtSalesmanId.Text = "";
            txtSalesman_name.Text = "";
            txtCity.Text = "";
            txtCommission.Text = "";
            txtSalesmanId.Focus();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int result;
                SalesmanBO newSalesman = new SalesmanBO()
                {
                    SalesmanId = Convert.ToInt32(txtSalesmanId.Text),
                    Name = txtSalesman_name.Text,
                    City = txtCity.Text,
                    Commission = float.Parse(txtCommission.Text)
                };
                SalesmanServiceReference1.SalesmanWebServiceSoapClient client1 = new SalesmanServiceReference1.SalesmanWebServiceSoapClient();
                result = client1.UpdateSalesmanInfo(newSalesman);

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
            txtSalesmanId.Text = "";
            txtSalesman_name.Text = "";
            txtCity.Text = "";
            txtCommission.Text = "";
            txtSalesmanId.Focus();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            try 
            {
                int result;
                SalesmanBO newSalesman = new SalesmanBO()
                {
                    SalesmanId = Convert.ToInt32(txtSalesmanId.Text)
                };
                SalesmanServiceReference1.SalesmanWebServiceSoapClient Client = new SalesmanServiceReference1.SalesmanWebServiceSoapClient();
                result = Client.DeleteSalesmanInfo(newSalesman);

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