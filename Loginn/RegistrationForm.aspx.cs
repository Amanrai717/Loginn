using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loginn
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public class SqlConnectionExample
        {
            public SqlConnection CreateSqlConnection()
            {
                // Replace "your_connection_string_here" with your actual SQL Server connection string
                string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=webapp;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(connectionString);



                return sqlConnection;
            }

            // Additional methods or code related to using the SqlConnection can be added here.
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string uid = TextBox3.Text;
                string pass = TextBox4.Text;

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString()))
                {
                    con.Open();

                    // Check if the username already exists
                    string checkUserQuery = "Select COUNT(*) FROM dbo.tbl_loginn WHERE Username=@Username";
                    SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, con);
                    checkUserCmd.Parameters.AddWithValue("@Username", uid);

                    int userCount = (int)checkUserCmd.ExecuteScalar();

                    if (userCount > 0)
                    {
                        Label4.Text = "Username already exists. Please choose a different one.";
                        
                    }
                    else
                    {
                        // Insert a new user
                        string insertQuery = "INSERT INTO dbo.tbl_loginn (Username, Password) VALUES (@Username, @Password)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@Username", uid);
                        insertCmd.Parameters.AddWithValue("@Password", pass);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Label4.Text = "User registered successfully.";
                        }
                        else
                        {
                            Label4.Text = "Failed to register user. Please try again.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "An error occurred: " + ex.Message;
                
            }
            
        }
        
    }
}