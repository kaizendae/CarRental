namespace Car_Rental_System
{
    partial class afficherregistre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cAR_RENTALDataSet = new Car_Rental_System.CAR_RENTALDataSet();
            this.bOOKING_DETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKING_DETAILSTableAdapter = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.BOOKING_DETAILSTableAdapter();
            this.tableAdapterManager = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager();
            this.bookinG_DETAILSTableAdapter1 = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.BOOKING_DETAILSTableAdapter();
            this.RegistreGR = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKING_DETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistreGR)).BeginInit();
            this.SuspendLayout();
            // 
            // cAR_RENTALDataSet
            // 
            this.cAR_RENTALDataSet.DataSetName = "CAR_RENTALDataSet";
            this.cAR_RENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKING_DETAILSBindingSource
            // 
            this.bOOKING_DETAILSBindingSource.DataMember = "BOOKING_DETAILS";
            this.bOOKING_DETAILSBindingSource.DataSource = this.cAR_RENTALDataSet;
            // 
            // bOOKING_DETAILSTableAdapter
            // 
            this.bOOKING_DETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLING_DETAILSTableAdapter = null;
            this.tableAdapterManager.BOOKING_DETAILSTableAdapter = this.bOOKING_DETAILSTableAdapter;
            this.tableAdapterManager.CAR_CATEGTableAdapter = null;
            this.tableAdapterManager.CARTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DISCOUNT_DETAILSTableAdapter = null;
            this.tableAdapterManager.LOCATION_DETAILSTableAdapter = null;
            this.tableAdapterManager.RENTAL_CAR_INSURANCETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookinG_DETAILSTableAdapter1
            // 
            this.bookinG_DETAILSTableAdapter1.ClearBeforeFill = true;
            // 
            // RegistreGR
            // 
            this.RegistreGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistreGR.Location = new System.Drawing.Point(0, 1);
            this.RegistreGR.Name = "RegistreGR";
            this.RegistreGR.Size = new System.Drawing.Size(845, 344);
            this.RegistreGR.TabIndex = 0;
            // 
            // afficherregistre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 348);
            this.Controls.Add(this.RegistreGR);
            this.Name = "afficherregistre";
            this.Text = "afficherregistre";
            this.Load += new System.EventHandler(this.afficherregistre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKING_DETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistreGR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CAR_RENTALDataSet cAR_RENTALDataSet;
        private System.Windows.Forms.BindingSource bOOKING_DETAILSBindingSource;
        private CAR_RENTALDataSetTableAdapters.BOOKING_DETAILSTableAdapter bOOKING_DETAILSTableAdapter;
        private CAR_RENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CAR_RENTALDataSetTableAdapters.BOOKING_DETAILSTableAdapter bookinG_DETAILSTableAdapter1;
        private System.Windows.Forms.DataGridView RegistreGR;
    }
}