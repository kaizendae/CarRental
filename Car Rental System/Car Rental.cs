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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAR_RENTALDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection newConnection = new SqlConnection("data source =.\\SQLEXPRESS ; Initial Catalog = CAR_RENTAL; Integrated Security = True; ");
            newConnection.Open();
            SqlCommand scm = new SqlCommand();
            scm.Connection = newConnection;
            scm.CommandText = "select count(*) from BOOKING_DETAILS";
            string BID = "B" + (int.Parse(scm.ExecuteScalar().ToString())+1001).ToString();
            bOOKING_IDTextBox.Text = BID;
            newConnection.Close();


            fillClientCombo();
            fillLocCombo();
            fill_BOOKINGSTATUS_Combo();
            fill_DISCOUT_Combo();
            fill_MODELVOIT_Combo();
        }
        public void fillClientCombo()
        {
            SqlConnection newConnection = new SqlConnection("data source =.\\SQLEXPRESS ; Initial Catalog = CAR_RENTAL; Integrated Security = True; ");
            newConnection.Open();
            SqlCommand scm = new SqlCommand();
            scm.Connection = newConnection;
            scm.CommandText = "select Client_ID from Client";
            SqlDataAdapter clientid = new SqlDataAdapter(scm);
            DataTable DT = new DataTable("CLIENTID");
            clientid.Fill(DT);

            for (int i = 0; i <= DT.Rows.Count - 1; i++)
            {
                clientCombo.Items.Add(DT.Rows[i]["Client_ID"].ToString());
            }
        }
        public void fillLocCombo()
        {
            SqlConnection newConnection = new SqlConnection("data source =.\\SQLEXPRESS ; Initial Catalog = CAR_RENTAL; Integrated Security = True; ");
            newConnection.Open();
            SqlCommand scm = new SqlCommand();
            scm.Connection = newConnection;
            scm.CommandText = "select LOCATION_ID from LOCATION_DETAILS";
            SqlDataAdapter clientid = new SqlDataAdapter(scm);
            DataTable DT = new DataTable("LOCATION_ID");
            clientid.Fill(DT);

            for (int i = 0; i <= DT.Rows.Count - 1; i++)
            {
                locationComboup.Items.Add(DT.Rows[i]["LOCATION_ID"].ToString());
                locationCombodrop.Items.Add(DT.Rows[i]["LOCATION_ID"].ToString());

            }
        }
        public void fill_BOOKINGSTATUS_Combo()
        {
            SqlConnection newConnection = new SqlConnection("data source =.\\SQLEXPRESS ; Initial Catalog = CAR_RENTAL; Integrated Security = True; ");
            newConnection.Open();
            SqlCommand scm = new SqlCommand();
            scm.Connection = newConnection;
            scm.CommandText = "select distinct BOOKING_STATUS from BOOKING_DETAILS";
            SqlDataAdapter clientid = new SqlDataAdapter(scm);
            DataTable DT = new DataTable("BOOKING_STATUS");
            clientid.Fill(DT);

            for (int i = 0; i <= DT.Rows.Count - 1; i++)
            {
                bookStatusCombo.Items.Add(DT.Rows[i]["BOOKING_STATUS"].ToString());

            }
        }
        public void fill_DISCOUT_Combo()
        {
            SqlConnection newConnection = new SqlConnection("data source =.\\SQLEXPRESS ; Initial Catalog = CAR_RENTAL; Integrated Security = True; ");
            newConnection.Open();
            SqlCommand scm = new SqlCommand();
            scm.Connection = newConnection;
            scm.CommandText = "select distinct DISCOUNT_CODE from DISCOUNT_DETAILS";
            SqlDataAdapter clientid = new SqlDataAdapter(scm);
            DataTable DT = new DataTable("DISCOUNT_CODE");
            clientid.Fill(DT);

            for (int i = 0; i <= DT.Rows.Count - 1; i++)
            {
                DISCOUNT_DETAILScombo.Items.Add(DT.Rows[i]["DISCOUNT_CODE"].ToString());

            }
        }
        public void fill_MODELVOIT_Combo()
        {
            SqlConnection newConnection = new SqlConnection("data source =.\\SQLEXPRESS ; Initial Catalog = CAR_RENTAL; Integrated Security = True; ");
            newConnection.Open();
            SqlCommand scm = new SqlCommand();
            scm.Connection = newConnection;
            scm.CommandText = "select distinct REGISTRATION_NUMBER from CAR";
            SqlDataAdapter clientid = new SqlDataAdapter(scm);
            DataTable DT = new DataTable("REGISTRATION_NUMBER");
            clientid.Fill(DT);

            for (int i = 0; i <= DT.Rows.Count - 1; i++)
            {
                Modelcombo.Items.Add(DT.Rows[i]["REGISTRATION_NUMBER"].ToString());

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnQUIT_Click(object sender, EventArgs e)
        {
            const string message = " Voulez Vous Fermer le programme ?";
            const string titre = "Fermeture";
            var result = MessageBox.Show(message, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleartext(this);
        }
        public void cleartext(Control T)
        {
            foreach (Control C in T.Controls)
            {
                if (C is TextBox)
                    ((TextBox)C).Clear();
                else
                    cleartext(C);
            }
        }
       



        private void Facture_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void AfficherFact(string BOOKID)
        {
            SqlConnection newConnection = new
            SqlConnection("data source =.\\SQLEXPRESS ; Initial Catalog = CAR_RENTAL; Integrated Security = True; ");
            newConnection.Open();
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM BILLING_DETAILS WHERE BOOKING_ID='"+BOOKID +"' ", newConnection);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds,"D");
            //ds.Tables["D"]
            showFact.Text = "\r\n\r\n\tFACTURE N: " + ds.Tables["D"].Rows[0]["BILL_ID"] +
                            "\r\n\r\n\r\n     DATE DE FACTURE :  " + ds.Tables["D"].Rows[0]["BILL_DATE"] +
                            "\r\n    ETAT DE PAIMENT :  " + ds.Tables["D"].Rows[0]["BILL_STATUS"] +
                            "\r\n    REMISE DE :  " + ds.Tables["D"].Rows[0]["DISCOUNT_AMOUNT"] +
                            "\r\n    PRIX TOTAL :  " + ds.Tables["D"].Rows[0]["TOTAL_AMOUNT"] +
                            "\r\n    PRIX TAX :  " + ds.Tables["D"].Rows[0]["TAX_AMOUNT"] +
                            "\r\n    NUMERO D'ENREGISTREMENT :  " + ds.Tables["D"].Rows[0]["BOOKING_ID"] +
                            "\r\n    TOTAL DE RETARD  :  " + ds.Tables["D"].Rows[0]["TOTAL_LATE_FEE"]
                            ;
            newConnection.Close();
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            afficherregistre showreg = new afficherregistre();
            showreg.Show();
        }
        




        private void fROM_DT_TIMEDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ajouterreg_Click(object sender, EventArgs e)
        {

            SqlConnection newConnection = new
            SqlConnection("data source =.\\SQLEXPRESS ; Initial Catalog = CAR_RENTAL; Integrated Security = True; ");
            newConnection.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from BOOKING_DETAILS", newConnection);
            SqlCommandBuilder cmd = new SqlCommandBuilder(ad);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            DataRow MyRow = ds.Tables[0].NewRow();

            MyRow["BOOKING_ID"] = bOOKING_IDTextBox.Text;
            MyRow["FROM_DT_TIME"] = fROM_DT_TIMEDateTimePicker.Text;
            MyRow["RET_DT_TIME"] = rET_DT_TIMEDateTimePicker.Text;
            MyRow["AMOUNT"] = Decimal.Parse(aMOUNTTextBox.Text);
            MyRow["BOOKING_STATUS"] = bookStatusCombo.Text;
            MyRow["PICKUP_LOC"] = locationComboup.Text;
            MyRow["DROP_LOC"] = locationCombodrop.Text;
            MyRow["REG_NUM"] = Modelcombo.Text;
            MyRow["DL_NUM"] = clientCombo.Text;
            MyRow["INS_CODE"] = iNS_CODETextBox.Text;
            MyRow["ACT_RET_DT_TIME"] = aCT_RET_DT_TIMEDateTimePicker.Text;
            MyRow["DISCOUNT_CODE"] = DISCOUNT_DETAILScombo.Text;
            ds.Tables[0].Rows.Add(MyRow);
            try
            {
                ad.Update(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            newConnection.Close();
            MessageBox.Show(" Donnees Inserées ! Voir Facture");

            //AfficherFact(bOOKING_IDTextBox.Text);
        }

        private void NVclient_Click(object sender, EventArgs e)
        {
            AjouterClient addclient = new AjouterClient();
            addclient.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            afficherclients showclients = new afficherclients();
            showclients.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            afficherRemises showdRemises = new afficherRemises();
            showdRemises.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            afficherVoiture showvhi = new afficherVoiture();
            showvhi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AfficherINS showASS = new AfficherINS();
            showASS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            afficherLOC showloc = new afficherLOC();
            showloc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            afficherBOOK showbook = new afficherBOOK();
            showbook.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AfficherFact(IDbooktxt.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            afficherFac showfact = new afficherFac();
            showfact.Show();
        }

        private void dL_NUMTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
