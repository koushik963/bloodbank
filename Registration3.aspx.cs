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

    }

    protected void Btn_Submit_Click(object sender, EventArgs e)
    {
        if (Tb_City.Text != null && Tb_DOB != null && Tb_EmailId != null && Tb_FirstName != null && Tb_HouseNumber != null && Tb_Mobilenum != null && 
            Tb_Pwd != null && Tb_Street != null && Tb_UserId != null && Tb_ZipCode != null && DDL_BloodGroups.SelectedIndex != 0 && Ddl_State.SelectedIndex != 0 )
        {
            String CS = @"data source=KOUSHIK\SQLEXPRESS; database = BLOOD; integrated security=SSPI";
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            int num_of_rows = 0;
            SqlTransaction transaction;
            transaction = con.BeginTransaction();

            try
            {
                string sqlquery1 = "insert into Logintbl (Username, Pwd, TS) values (@username,@pwd, GETDATE());";
                SqlCommand cmd = new SqlCommand(sqlquery1, con, transaction);
                cmd.Parameters.Add("username", Tb_UserId.Text);
                cmd.Parameters.Add("pwd", Tb_Pwd.Text);
                num_of_rows = cmd.ExecuteNonQuery();
                string emailbody = null;

            
                //string sqlquery2 = "insert into Memberinfo(FullName, BloodGroup, Gender, DOB, Mobile, Statecd, House_number, Street, city, zipcode,"
                //+ "Userid, Pwd, EmailId, available_status, TS) "
                //+ "values ('FullName', 'O+', 'Gender', '1990-09-09', 'Mobil', 'OH', 'House_number', 'Street', 'city', 12345, 'Userid3', 'Pwd', 'EmailId', 'available', GETDATE())";


                string sqlquery2 = "insert into Memberinfo(FullName, BloodGroup, Gender, DOB, Mobile, Statecd, House_number, Street, city, zipcode," +
                                     "Userid, Pwd, EmailId, available_status, TS) values (@FullName, @Group, @Gender, @DOB, @Mobile, @state," +
                                     "@House_number, @Street, @city, @zipcode, @Userid, @Pwd, @EmailId, @status, GETDATE());";
                //string sqlquery2 = "insert into Memberinfo(FullName, BloodGroup, Gender, DOB, Mobile, Statecd, House_number, Street, city, zipcode," +
                //"EmailId, available_status) values (@FullName, @Group, @Gender, @DOB, @Mobile, @state," +
                //"@House_number, @Street, @city, @zipcode, @EmailId, @status);";
               
                SqlCommand cmd2 = new SqlCommand(sqlquery2, con, transaction);
                cmd2.Parameters.Add("FullName", Tb_FirstName.Text);
                cmd2.Parameters.Add("Group", DDL_BloodGroups.SelectedValue);
                cmd2.Parameters.Add("Gender", Ddl_Gender.SelectedValue);
                cmd2.Parameters.Add("DOB", Tb_DOB.Text);
                cmd2.Parameters.Add("Mobile", Tb_Mobilenum.Text);
                cmd2.Parameters.Add("state", Ddl_State.SelectedValue);
                cmd2.Parameters.Add("House_number", Tb_HouseNumber.Text);
                cmd2.Parameters.Add("Street", Tb_Street.Text);
                cmd2.Parameters.Add("city", Tb_City.Text);
                cmd2.Parameters.Add("zipcode", Tb_ZipCode.Text);
                cmd2.Parameters.Add("Userid", Tb_UserId.Text);
                cmd2.Parameters.Add("Pwd", Tb_Pwd.Text);
                cmd2.Parameters.Add("EmailId", Tb_EmailId.Text);
                cmd2.Parameters.Add("status", Ddl_status.SelectedValue);
                num_of_rows += cmd2.ExecuteNonQuery();

                transaction.Commit();
                
                if (num_of_rows > 1)
                {
                    Lbl_msg.Text = "Thank you for your registrations. A Confirmartion has been sent to " + Tb_EmailId.Text;
                    emailbody = "Hey " + Tb_FirstName.Text + ",\n" + "\nThank you for Regestering in the website and your credentials are \n \nUSER ID: " + Tb_UserId.Text + "\n" + "Password: " + Tb_Pwd.Text + "\n Thanks, \n BloodBank";
                    sendemail(emailbody, Tb_EmailId.Text);
                    Lbl_msg.ForeColor = System.Drawing.Color.Green;

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
        MailMessage mailmsg = new MailMessage("bloodbank62@gmail.com", to_email); // please give the from email address and to email address;
        mailmsg.Subject = "THANK YOU FOR YOUR REGISTRATION";
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
}