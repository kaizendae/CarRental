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
    public partial class afficherLOC : Form
    {
        public afficherLOC()
        {
            InitializeComponent();
        }

        private void lOCATION_DETAILSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOCATION_DETAILSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAR_RENTALDataSet);

        }

        private void afficherLOC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAR_RENTALDataSet.LOCATION_DETAILS' table. You can move, or remove it, as needed.
            this.lOCATION_DETAILSTableAdapter.Fill(this.cAR_RENTALDataSet.LOCATION_DETAILS);

        }
    }
}
