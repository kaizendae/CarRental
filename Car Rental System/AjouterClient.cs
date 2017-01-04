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
    public partial class AjouterClient : Form
    {
        public AjouterClient()
        {
            InitializeComponent();
        }

        private void btnCLIENTadd_Click(object sender, EventArgs e)
        {
            string ClientID = client_IDTextBox.Text;
            string Fname = fNAMETextBox.Text;
            string Mname = mNAMETextBox.Text;
            string Lname = lNAMETextBox.Text;
            Int64 phone = Int64.Parse(pHONE_NUMBERTextBox.Text);
            string email = eMAIL_IDTextBox.Text;
            string street = sTREETTextBox.Text;
            string city = cITYTextBox.Text;
            string state = sTATE_NAMETextBox.Text;
            int zip = int.Parse(zIPCODETextBox.Text);
            string membership = mEMBERSHIP_TYPETextBox.Text;
            string idmember = mEMBERSHIP_IDTextBox.Text;

            SqlConnection newConnection = new
            SqlConnection("data source =.\\SQLEXPRESS ; Initial Catalog = CAR_RENTAL; Integrated Security = True; ");
            newConnection.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from Client", newConnection);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            DataRow MyRow = ds.Tables[0].NewRow();
            MyRow["Client_ID"] = ClientID;
            MyRow["FNAME"] = Fname;
            MyRow["MNAME"] = Mname;
            MyRow["LNAME"] = Lname;
            MyRow["PHONE_NUMBER"] = phone;
            MyRow["EMAIL_ID"] = email;
            MyRow["STREET"] = street;
            MyRow["CITY"] = city;
            MyRow["STATE_NAME"] = state;
            MyRow["ZIPCODE"] = zip;
            MyRow["MEMBERSHIP_TYPE"] = membership;
            MyRow["MEMBERSHIP_ID"] = idmember;
            ds.Tables[0].Rows.Add(MyRow);

            ad.Update(ds);
            newConnection.Close();
            MessageBox.Show(" Nouveau Client Ajoutée ! ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            afficherclients showclients = new afficherclients();
            showclients.Show();
        }
    }
}
