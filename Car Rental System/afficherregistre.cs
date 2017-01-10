using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Car_Rental_System
{
    public partial class afficherregistre : Form
    {
        public afficherregistre()
        {
            InitializeComponent();
        }

        private void bOOKING_DETAILSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOOKING_DETAILSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAR_RENTALDataSet);

        }

        private void afficherregistre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAR_RENTALDataSet.BOOKING_DETAILS' table. You can move, or remove it, as needed.
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet DS = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        
        con.ConnectionString = "data source =.\\SQLEXPRESS ; Initial Catalog =CAR_RENTAL; Integrated Security = True; ";
        con.Open();
            
    
        
            

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM BOOKING_DETAILS";

            adapter.SelectCommand = cmd;
            adapter.Fill(DS, "D");

            RegistreGR.AutoGenerateColumns = true;
            RegistreGR.DataSource = DS.Tables["D"];

            con.Close();

        }
    }
}
