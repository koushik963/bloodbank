using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Common;
using System.Configuration;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Tb_Pwd.Text = string.Empty;
        //Tb_Username.Text = string.Empty;
        //Lbl_msg.Text = string.Empty;
    }
    protected void Btn_Login_Click(object sender, EventArgs e)
    {
        if (Tb_Pwd.Text != null && Tb_Username != null)
        {
            String CS = @"data source=KOUSHIK\SQLEXPRESS; database = BLOOD; integrated security=SSPI";
                
            //String CS = ConfigurationManager.ConnectionStrings["DB"];
            SqlConnection con = new SqlConnection(CS);
            string sqlquery = "select * from Logintbl where Username = @username and pwd=@pwd";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.Parameters.Add("username", Tb_Username.Text);
            cmd.Parameters.Add("pwd", Tb_Pwd.Text);
            con.Open();
            if (cmd.ExecuteReader().HasRows)
            {
                Response.Redirect("~/Registration.aspx");
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
}