using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prakrisk_eksamen_ØVE
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        // ---- Page Loader
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public DataTable GetAllTeachers()
        {

            var connectionString = ConfigurationManager.ConnectionStrings["ConnAir"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT " + TB.Text + " FROM Elev, Fag, FagElev, Klasse, Paststeder ", conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                conn.Close();

            }
            return dt;
        }


        //--------------------------------------------------------------------------
        // ---- Button
        protected void B_Click(object sender, EventArgs e)
        {
            GV.DataSource = GetAllTeachers();
            GV.DataBind();
        }


        //--------------------------------------------------------------------------
        // ---- TextBox
        protected void TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}