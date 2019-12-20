using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.netcrud
{

    
    public partial class Contact : System.Web.UI.Page
    {//SQL connection
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-55T2PS0;Initial Catalog=ASPCRUD;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnDelete.Enabled = false;
            }

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()//Clear entered data
        {
            hfContactID.Value = "";
            txtName.Text = txtLastName.Text = txtDebt.Text = txtPayment.Text = " ";
            lblSuccessMessage.Text = lblErrorMessage.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;

        }

        protected void btnSave_Click(object sender, EventArgs e)

        {
            //open sql connection
            //pass enterd data to database

            if (sqlCon.State == System.Data.ConnectionState.Closed)
            sqlCon.Open();
           
            SqlCommand sqlCmd = new SqlCommand("ContactCreateOrUpdate", sqlCon);
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ContactID", (hfContactID.Value == "" ? 0 : Convert.ToInt32(hfContactID.Value)));
            sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Debt", txtDebt.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@Payment", txtPayment.Text.Trim());
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            Clear();
            if (hfContactID.Value == "")
                lblSuccessMessage.Text = "Save Succesfully";
            else
                lblSuccessMessage.Text = "Updated Succesfully";
        }

      
    }
}