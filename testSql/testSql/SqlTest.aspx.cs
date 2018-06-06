using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace testSql
{
    public partial class SqlTest : System.Web.UI.Page
    {
        string connectionString = @"server=localhost;user=user;database=mydb1;port=3306;password=12345;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Clear();
            }

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {
                    sqlCon.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("PeopleAddOrEdit", sqlCon);
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_ID_People", Convert.ToInt32(hfPeopleID.Value == "" ? "0" : hfPeopleID.Value));
                    sqlCmd.Parameters.AddWithValue("_Family", txtFamily.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("_Name1", txtName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("_Surname", txtSurname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("_Date_Burh", Convert.ToDateTime(txtDate.Text.Trim()));
                    sqlCmd.Parameters.AddWithValue("_Type_c", txtType.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("_ID_clube", Convert.ToInt32(txtIDClube.Text.Trim()));
                    sqlCmd.ExecuteNonQuery();
                    Clear();
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex);
            }
        }

       void Clear()
        {
            hfPeopleID.Value = "";
            txtDate.Text = txtFamily.Text = txtIDClube.Text = txtName.Text = txtSurname.Text = txtType.Text = "";
            ButtonSave.Text = "Save";
            ButtonDelete.Enabled = false;
        }

       protected void ButtonClear_Click(object sender, EventArgs e)
       {
           Clear();
       }
    }
 

}