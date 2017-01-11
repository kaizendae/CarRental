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
    public partial class ShowBooking : Form
    {
        public ShowBooking()
        {
            InitializeComponent();
        }

        private void bOOKING_DETAILSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOOKING_DETAILSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAR_RENTALDataSet);

        }

        private void ShowBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAR_RENTALDataSet.BOOKING_DETAILS' table. You can move, or remove it, as needed.
            this.bOOKING_DETAILSTableAdapter.Fill(this.cAR_RENTALDataSet.BOOKING_DETAILS);

        }
    }
}
