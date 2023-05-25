using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting.Messaging;

namespace Prakrisk_eksamen_ØVE
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }
        public DataTable GetAllTeachers()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;
            DataTable dt = new DataTable();

            // -------- ELEV INFO 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT " + TextBox1.Text + " FROM Elev", conn);

                // Alt funker, men jeg kan ikke ha mer en 1 data base tilkoblet, SVAR: kjekk om alt som skal være likt i SQl er likt. 


                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                conn.Close();

            }
            return dt;
        }
   //---------------------
    protected void Button_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = GetAllTeachers();
            GridView1.DataBind();
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        { }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }
    }
}