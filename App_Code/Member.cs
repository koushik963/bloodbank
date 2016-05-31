using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Member
/// </summary>
public class Member
{
    private string FullName;
    private string EmailId;
    private string Mobile;
    private string Availability;
    private string Username;

    public string FULLNAME
    {
        get { return FullName; }
        set { FullName = value; }
    }

    public string EMAILID
    {
        get { return EmailId; }
        set { EmailId = value; }
    }

    public string MOBILE
    {
        get { return Mobile; }
        set { Mobile = value; }
    }
    public string STATUS
    {
        get { return Availability; }
        set { Availability = value; }
    }

    public string USERNAME
    {
        get { return Username; }
        set { Username = value; }
    }
}