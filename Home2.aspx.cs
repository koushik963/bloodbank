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
    protected void Page_Init(object sender, EventArgs e)
    {
        Gv_Data.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["notify"] == "yes")
        //{
        //    if (Tb_Zip != null && DDL_BloodGroups.SelectedIndex != 0)
        //    {
        //        try
        //        {
        //            SqlDataReader m_dr;
        //            String CS = @"data source=SANTHOSH\SQLEXPRESS; database = master; integrated security=SSPI";
        //            SqlConnection con = new SqlConnection(CS);


        //            string sqlquery = "select FullName, BloodGroup, Gender, Statecd, House_number, Street, city, zipcode, EmailId,Mobile, available_status " +
        //                "from Memberinfo where zipcode = " + Convert.ToString(Tb_Zip.Text) + " and BloodGroup = '" + Convert.ToString(DDL_BloodGroups.SelectedValue) + "';";
        //            SqlCommand cmd = new SqlCommand(sqlquery, con);
        //            cmd.Parameters.Add("zip", Tb_Zip.Text);
        //            cmd.Parameters.Add("group", DDL_BloodGroups.SelectedValue);
        //            con.Open();
        //            ButtonField notify = new ButtonField();


        //            m_dr = cmd.ExecuteReader();
        //            if (m_dr.HasRows)
        //            {
        //                Gv_Data.DataSource = m_dr;
        //                Gv_Data.DataBind();
        //                Session["notify"] = "yes";

        //                Lbl_Msg.Text = "DESIRED RECORD";
        //                Lbl_Msg.ForeColor = System.Drawing.Color.Green;
        //            }
        //            else
        //            {
        //                Lbl_Msg.Text = "NO RECORD FOUND";
        //                Lbl_Msg.ForeColor = System.Drawing.Color.Red;
        //                Gv_Data.DataSource = null;
        //                Gv_Data.DataBind();
        //            }

        //            con.Close();
        //        }
        //        catch (Exception ex)
        //        { }
        //    }
        //    else
        //    {
        //        Lbl_Msg.Text = "PLEASE MENTION ALL THE REQUIRED FIELDS";
        //        Lbl_Msg.ForeColor = System.Drawing.Color.Red;
        //    }

        //}
        //if (!IsPostBack)
        //{
        //    AddLinkButton();
        //}
    }
    protected void Btn_Submit_Click(object sender, EventArgs e)
    {
        if ( Tb_Zip != null && DDL_BloodGroups.SelectedIndex != 0)
        {
            try
            {
                SqlDataReader m_dr;
                String CS = @"data source=KOUSHIK\SQLEXPRESS; database = BLOOD; integrated security=SSPI";
                SqlConnection con = new SqlConnection(CS);
               

                //string sqlquery = "select FullName, BloodGroup, Gender, Statecd, House_number, Street, city, zipcode, EmailId,Mobile, available_status " +
                //    "from Memberinfo where zipcode = " + Convert.ToString(Tb_Zip.Text) + " and BloodGroup = '" + Convert.ToString(DDL_BloodGroups.SelectedValue) + "';";


                //string sqlquery = "select FullName, BloodGroup,DATEDIFF(YY, DOB, GETDATE()) AS AGE, Gender, Statecd, House_number, Street, city, zipcode, EmailId,Mobile, available_status " +
                  //  "from Memberinfo where zipcode = " + Convert.ToString(Tb_Zip.Text) + " and BloodGroup = '" + Convert.ToString(DDL_BloodGroups.SelectedValue) + "';";


                //string sqlquery = "select FullName \"FULL NAME\",DATEDIFF(YY, DOB, GETDATE()) AS AGE, BloodGroup \"BLOOD GROUP\", Gender \"GENDER\", Statecd \"STATE CODE\"," +
                //"House_number \"H.NO\", Street \"STREET\", city \"CITY\", zipcode \"ZIPCODE\", EmailId \"EMAIL ID\",Mobile \"MOBILE NUMBER\", available_status \"STATUS\" " +
                //"from Memberinfo where zipcode = " + Convert.ToString(Tb_Zip.Text) + " and BloodGroup = '" + Convert.ToString(DDL_BloodGroups.SelectedValue) + "';";

                string sqlquery = "select FullName \"FULL NAME\",DATEDIFF(YY, DOB, GETDATE()) AS AGE, BloodGroup \"BLOOD GROUP\", Gender \"GENDER\", Statecd \"STATE CODE\"," +
                "House_number \"H.NO\", Street \"STREET\", city \"CITY\", zipcode \"ZIPCODE\", EmailId \"EMAIL ID\",Mobile \"MOBILE NUMBER\", available_status \"STATUS\" " +
                "from Memberinfo where zipcode = " + Convert.ToString(Tb_Zip.Text) + " and BloodGroup = '" + Convert.ToString(DDL_BloodGroups.SelectedValue) + "' and available_status =\'Available\';" ;
               

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                cmd.Parameters.Add("zip", Tb_Zip.Text);
                cmd.Parameters.Add("group", DDL_BloodGroups.SelectedValue);
                con.Open();
                ButtonField notify = new ButtonField();
               

                m_dr = cmd.ExecuteReader();
                if (m_dr.HasRows)
                {
                    Gv_Data.DataSource = m_dr;                   
                    Gv_Data.DataBind();
                    Session["notify"] = "yes";
                    
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

    //protected void Gv_Data_DataBound(object sender, EventArgs e)
    //{
    //   AddLinkButton();
    //} 
    //private void AddLinkButton()
    //{
    //    foreach (GridViewRow row in Gv_Data.Rows)
    //    {
    //        if (row.RowType == DataControlRowType.DataRow)
    //        {
    //            LinkButton lb = new LinkButton();
    //            lb.Text = "Notify";
    //            lb.CommandName = "NotifyDonor";
    //            lb.Command += LinkButton_Command;
    //            row.Cells[0].Controls.Add(lb);
    //        }
    //    }
    //}
    //protected void LinkButton_Command(object sender, CommandEventArgs e)
    //{
    //    if (e.CommandName == "NotifyDonor")
    //    {
    //        //This is to test  
    //        LinkButton lb = (LinkButton)sender;
    //        lb.Text = "OK";

    //        //Response.Redirect("~/Home2.aspx");
    //    }
    //}
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //Session["notify"] = "no";
        Response.Redirect("~/NewLogin.aspx");
    }
}