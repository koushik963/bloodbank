using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Common;
using System.Net.Mail;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Lbl_Username.Text = "Hi " + Convert.ToString(Session["name"]);
        if (!IsPostBack)
        {
            String CS = @"data source=KOUSHIK\SQLEXPRESS; database = BLOOD; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            string username = Convert.ToString(Session["username"]);
            string sqlquery = "select * from Memberinfo where Userid = '" + username + "';";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Member mem = new Member();
                mem.EMAILID = Convert.ToString(reader["EmailId"]);
                mem.FULLNAME = Convert.ToString(reader["FullName"]);
                mem.MOBILE = Convert.ToString(reader["Mobile"]);
                mem.STATUS = Convert.ToString(reader["available_status"]);

                DDL_BloodGroups.SelectedValue = Convert.ToString(reader["BloodGroup"]);
                Tb_FirstName.Text = mem.FULLNAME;
                Tb_EmailId.Text = mem.EMAILID;
                
                if (mem.STATUS == "Available      ")
                {
                    Ddl_status.SelectedIndex = 0;
                }
                else
                {
                    Ddl_status.SelectedIndex = 1;
                }
               // Ddl_status.SelectedValue = mem.STATUS;
                
                Tb_Mobilenum.Text = mem.MOBILE;
                Ddl_State.SelectedValue = Convert.ToString(reader["Statecd"]);
                Tb_HouseNumber.Text = Convert.ToString(reader["House_Number"]);
                Tb_Street.Text = Convert.ToString(reader["street"]);
                Tb_City.Text = Convert.ToString(reader["city"]);
                Tb_ZipCode.Text = Convert.ToString(reader["zipcode"]);
            }
        }
        
    }

    protected void Btn_Submit_Click(object sender, EventArgs e)
    {
        if (Tb_City.Text != null && Tb_EmailId != null && Tb_FirstName != null && Tb_HouseNumber != null && Tb_Mobilenum != null && 
            Tb_Street != null && Tb_ZipCode != null && DDL_BloodGroups.SelectedIndex != 0 && Ddl_State.SelectedIndex != 0 )
        {
            String CS = @"data source=KOUSHIK\SQLEXPRESS; database = BLOOD; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            int num_of_rows = 0;
            SqlTransaction transaction;
            transaction = con.BeginTransaction();

            try
            {
                string emailbody = null;

            
                string sqlquery2 = "UPDATE Memberinfo SET FullName = @FullName, BloodGroup= @Group, Mobile=@Mobile, Statecd=@state,"+
                              "House_number=@House_number, Street=@Street, city=@city, zipcode=@zipcode," +
                                     "EmailId=@EmailId, available_status=@status,TS= GETDATE() where Userid=@Userid";

               
                SqlCommand cmd2 = new SqlCommand(sqlquery2, con, transaction);
                cmd2.Parameters.Add("FullName", Tb_FirstName.Text);
                cmd2.Parameters.Add("Group", DDL_BloodGroups.SelectedValue);
                cmd2.Parameters.Add("Mobile", Tb_Mobilenum.Text);
                cmd2.Parameters.Add("state", Ddl_State.SelectedValue);
                cmd2.Parameters.Add("House_number", Tb_HouseNumber.Text);
                cmd2.Parameters.Add("Street", Tb_Street.Text);
                cmd2.Parameters.Add("city", Tb_City.Text);
                cmd2.Parameters.Add("zipcode", Tb_ZipCode.Text);
                cmd2.Parameters.Add("Userid", Convert.ToString(Session["username"]));
                cmd2.Parameters.Add("EmailId", Tb_EmailId.Text);
                cmd2.Parameters.Add("status", Ddl_status.SelectedValue);
                num_of_rows += cmd2.ExecuteNonQuery();

                transaction.Commit();
                
                if (num_of_rows > 0)
                {
                    Session["mailid"] = Tb_EmailId.Text;
                    Session["name"] = Tb_FirstName.Text;
                    Lbl_msg.Text = "You Have Successfully Updated your profile ";
                    emailbody = "Hey " + Tb_FirstName.Text + ",\n" + "\n Your profile has been Updated \nThanks, \n BloodBank";
                    sendemail(emailbody, Tb_EmailId.Text);
                    Lbl_msg.ForeColor = System.Drawing.Color.Green;
                    //Response.Redirect("~/Manage.aspx");
                }
                else
                {
                    Lbl_msg.Text = "";
                }

            }
            catch (SqlException ex)
            {
                transaction.Rollback();
            }
            
        }
        else
        {
            Lbl_msg.Text = " Please enter all the required fields*";
            Lbl_msg.ForeColor = System.Drawing.Color.Red;
        }
    }

    public static void sendemail(string emailBody, string to_email)
    {
        try
        {            
            MailMessage mailmsg = new MailMessage("bloodbank62@gmail.com", to_email); // please give the from email address and to email address;
            mailmsg.Subject = "YOUR PROFILE HAS BEEN UPDATED";
            mailmsg.Body = emailBody;
            SmtpClient smtpclient = new SmtpClient("smtp.gmail.com", 587);
            smtpclient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "bloodbank62@gmail.com", // please give the username here;
                Password = "dibloodbank"   // Please specify the password here;
            };
            smtpclient.EnableSsl = true;
            smtpclient.Send(mailmsg);
        }
        catch (Exception ex)
        {
        }        
    }
    protected void LinkBtn_Loguout_Click(object sender, EventArgs e)
    {
        Session["name"] = null;
        Session["username"] = null;
        Session["mailid"] = null;
        Response.Redirect("~/Home2.aspx");
    }
    protected void LinkBtn_Home_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/UserHome.aspx");
    }
}