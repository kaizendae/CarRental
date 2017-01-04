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
    public partial class AfficherINS : Form
    {
        public AfficherINS()
        {
            InitializeComponent();
        }

        private void rENTAL_CAR_INSURANCEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rENTAL_CAR_INSURANCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAR_RENTALDataSet);

        }

        private void AfficherINS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAR_RENTALDataSet.RENTAL_CAR_INSURANCE' table. You can move, or remove it, as needed.
            this.rENTAL_CAR_INSURANCETableAdapter.Fill(this.cAR_RENTALDataSet.RENTAL_CAR_INSURANCE);

        }
    }
}
