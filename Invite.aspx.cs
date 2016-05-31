using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class Invite : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public static void sendemail(string emailBody, string to_email)
    {
        try
        {

            MailMessage mailmsg = new MailMessage("koushikravulapelli2@gmail.com", to_email); // please give the from email address and to email address;
            mailmsg.Subject = "THANK YOU FOR YOUR REGISTRATION";
            mailmsg.Body = emailBody;
            SmtpClient smtpclient = new SmtpClient("smtp.gmail.com", 587);
            smtpclient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "koushikravulapelli2@gmail.com", // please give the username here;
                Password = "9700265477"   // Please specify the password here;
            };
            smtpclient.EnableSsl = true;
            smtpclient.Send(mailmsg);

        }
        catch (Exception ex)
        {
        }

    }
    protected void Btn_Submit_Click(object sender, EventArgs e)
    {
        string emailbody = null;

        if (Tb_EmailId.Text != null && Tb_FirstName.Text != null)
        {
            Lbl_msg.Text = "Thank you for your registrations. A Confirmartion has been sent to " + Tb_EmailId.Text;
            emailbody = "Hi " + Tb_FirstName.Text + ",\n" + "\n" + Session["username"] + "Friend of yours, Inivited you to join in Blood Bank as a Blood Donor."+ "\n Thanks, \n BloodBank";
            sendemail(emailbody, Tb_EmailId.Text);
            Lbl_msg.ForeColor = System.Drawing.Color.Green;
            Response.Redirect("~/UserHome.aspx");
        }
    }
    protected void LinkBtn_Home_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/UserHome.aspx");
    }
    protected void Btn_Reset_Click(object sender, EventArgs e)
    {
        Lbl_msg.Text = string.Empty;
        Tb_FirstName.Text = string.Empty;
        Tb_EmailId.Text = string.Empty;
    }
}