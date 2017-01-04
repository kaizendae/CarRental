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
    public partial class afficherVoiture : Form
    {
        public afficherVoiture()
        {
            InitializeComponent();
        }

        private void cARBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cARBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cAR_RENTALDataSet);

        }

        private void afficherVoiture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAR_RENTALDataSet.CAR' table. You can move, or remove it, as needed.
            this.cARTableAdapter.Fill(this.cAR_RENTALDataSet.CAR);

        }

        private void cARDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
