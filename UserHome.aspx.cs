using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Common;

public partial class Home2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Lbl_Username.Text = "Hi " + Convert.ToString(Session["name"]);
      
    }
    protected void Btn_Submit_Click(object sender, EventArgs e)
    {
        Lbl_Username.Text = "Hi " + Convert.ToString(Session["name"]);
        if ( Tb_Zip != null && DDL_BloodGroups.SelectedIndex != 0)
        {
            try
            {
                SqlDataReader m_dr;       
                String CS = @"data source=KOUSHIK\SQLEXPRESS; database = BLOOD; integrated security=SSPI";
                SqlConnection con = new SqlConnection(CS);
                
                string sqlquery = "select FullName \"FULL NAME\",DATEDIFF(YY, DOB, GETDATE()) AS AGE, BloodGroup \"BLOOD GROUP\", Gender \"GENDER\", Statecd \"STATE CODE\"," +
                "House_number \"H.NO\", Street \"STREET\", city \"CITY\", zipcode \"ZIPCODE\", EmailId \"EMAIL ID\",Mobile \"MOBILE NUMBER\", available_status \"STATUS\" " +
                "from Memberinfo where zipcode = " + Convert.ToString(Tb_Zip.Text) + " and BloodGroup = '" + Convert.ToString(DDL_BloodGroups.SelectedValue) + "' and available_status =\'Available\';";

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Add("zip", Tb_Zip.Text);
                cmd.Parameters.Add("group", DDL_BloodGroups.SelectedValue);
                con.Open();
                
                m_dr = cmd.ExecuteReader();
                if (m_dr.HasRows)
                {
                    Gv_Data.DataSource = m_dr;
                    Gv_Data.DataBind();
                    Lbl_Msg.Text = "DESIRED RECORD";
                    Lbl_Msg.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    Lbl_Msg.Text = "NO RECORD FOUND";
                    Lbl_Msg.ForeColor = System.Drawing.Color.Red;
                    Gv_Data.DataSource = null;
                    Gv_Data.DataBind();
                }
                con.Close();
            }
            catch (Exception ex)
            {  }            
        }
        else
        {
            Lbl_Msg.Text = "PLEASE MENTION ALL THE REQUIRED FIELDS";
            Lbl_Msg.ForeColor = System.Drawing.Color.Red;
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Lbl_Username.Text = "Hi " + Convert.ToString(Session["name"]);
       // Lbl_Msg.Text = Convert.ToString(ViewState["name"]);
        Response.Redirect("~/NewLogin.aspx");
    }
    protected void LinkBtn_ManageAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Manage.aspx");
    }
    protected void LinkBtn_Loguout_Click(object sender, EventArgs e)
    {
        Session["name"] = null;
        Session["username"] = null;
        Session["mailid"] = null;
        Response.Redirect("~/Home2.aspx");
    }
    protected void LinkBtn_Invite_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Invite.aspx");
    }
}