using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Car_Rental_System
{
    class DATA
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter adapter = new SqlDataAdapter();
        public DataSet DS = new DataSet();

        public void Connect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = "data source =.\\SQLEXPRESS ; Initial Catalog = CAR_RENTAL; Integrated Security = True; ";
                con.Open();
            }
        }
    }
}
