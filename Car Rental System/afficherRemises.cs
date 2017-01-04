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
    public partial class afficherRemises : Form
    {
        public afficherRemises()
        {
            InitializeComponent();
        }

        private void dISCOUNT_DETAILSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dISCOUNT_DETAILSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAR_RENTALDataSet);

        }

        private void afficherRemises_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAR_RENTALDataSet.DISCOUNT_DETAILS' table. You can move, or remove it, as needed.
            this.dISCOUNT_DETAILSTableAdapter.Fill(this.cAR_RENTALDataSet.DISCOUNT_DETAILS);

        }
    }
}
