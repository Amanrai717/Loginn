using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Loginn
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
     

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());

            try
                {
                    string uid = TextBox1.Text;
                    string pass = TextBox2.Text;
                    con.Open();
               
                string qry = "Select * FROM dbo.tbl_loginn WHERE Username=@Username AND Password=@Password";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Username", uid);
                cmd.Parameters.AddWithValue("@Password", pass);
                SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        Label1.Text = "Login Sucess......!!";
                    }
                    else
                    {
                        Label1.Text = "UserId & Password Is not correct Try again..!!";

                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                Label1.Text = "An error occurred: " + ex.Message;
            }

            }

        }
    }
