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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
 
                SqlConnection con = new SqlConnection("Data Source=.;Database=surendra;user id=sa;password=abc");
                string query = "insert into form values(@fname,@lname,@uname,@pwd)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@uname", txtuname.Text);
                cmd.Parameters.AddWithValue("@pwd", txtpwd.Text);
                con.Open();
               
              int i = cmd.ExecuteNonQuery();
             
             
                con.Close();
                if (i==1)
                {
                    lbl.Text = "Registered Successfully";
                }
                else
                {
                    lbl.Text = "Registration Failed";

                }
            }


        }
    }
