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
    public partial class afficherBOOK : Form
    {
        public afficherBOOK()
        {
            InitializeComponent();
        }

        private void bOOKING_DETAILSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOOKING_DETAILSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAR_RENTALDataSet);

        }

        private void afficherBOOK_Load(object sender, EventArgs e)
        {

        }
    }
}
