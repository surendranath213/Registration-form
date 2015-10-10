using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication10
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string uname="";
        string pwd="";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Database=surendra;user id=sa;password=abc");
            SqlCommand cmd = new SqlCommand("select uname,pwd from form", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    uname = dr[0].ToString();
                    pwd = dr[1].ToString();

                    if (txtusname.Text == uname && txtpawd.Text == pwd)
                    {
                        Response.Redirect("welcome.aspx");
                    }
                    else
                    {
                        lblmsg.Text = "Please enter correct username and password";

                    }



                }
            }

        }

    }
    }