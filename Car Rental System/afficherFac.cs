using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class afficherFac : Form
    {
        public afficherFac()
        {
            InitializeComponent();
        }

        private void bILLING_DETAILSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bILLING_DETAILSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAR_RENTALDataSet);

        }

        private void afficherFac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAR_RENTALDataSet.BILLING_DETAILS' table. You can move, or remove it, as needed.
            this.bILLING_DETAILSTableAdapter.Fill(this.cAR_RENTALDataSet.BILLING_DETAILS);

        }
    }
}
