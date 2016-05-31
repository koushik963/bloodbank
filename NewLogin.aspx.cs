using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class NewLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Btn_Login_Click(object sender, EventArgs e)
    {
        if (Tb_Pwd.Text != null && Tb_Username != null)
        {
            String CS = @"data source=KOUSHIK\SQLEXPRESS; database = BLOOD; integrated security=SSPI";
                
            //String CS = ConfigurationManager.ConnectionStrings["DB"];
            SqlConnection con = new SqlConnection(CS);
            string sqlquery = "select fullname, username from Logintbl where Username = @username and pwd=@pwd";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.Parameters.Add("username", Tb_Username.Text);
            cmd.Parameters.Add("pwd", Tb_Pwd.Text);
            con.Open();
            SqlDataReader username = cmd.ExecuteReader();
            //if (cmd.ExecuteReader().HasRows)
            if(username.HasRows)
            {
                while (username.Read())
                {
                    Member mem = new Member();
                    //Session["name"] = Convert.ToString(username);
                    mem.FULLNAME = Convert.ToString(username["fullname"]);
                    mem.USERNAME = Convert.ToString(username["username"]);
                    Session["name"] = mem.FULLNAME;
                    //Session["username"] = "\"" + mem.USERNAME + "\"";
                    Session["username"] = mem.USERNAME;
                    //ViewState["name"] = "\"" + mem.FULLNAME + "\"";
                    Response.Redirect("~/UserHome.aspx");                
                }
                
                //Response.Redirect("~/Registration2.aspx");
            }
            else
            {
                Lbl_msg.Text = "Please entere a valid Username/Password";
                Lbl_msg.ForeColor = System.Drawing.Color.Red;
            }
        }
        else if (Tb_Username.Text == null)
        {
            Lbl_msg.Text = "Please enter a the UserName";
            Lbl_msg.ForeColor = System.Drawing.Color.Red;
        }
        else if (Tb_Username != null && Tb_Pwd == null)
        {
            Lbl_msg.Text = "Please enter the password";
            Lbl_msg.ForeColor = System.Drawing.Color.Red;
        }
    }
    protected void Btn_signup_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Registration2.aspx");
    }
}
 