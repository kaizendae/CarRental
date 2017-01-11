namespace Car_Rental_System
{
    partial class afficherRemises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(afficherRemises));
            this.cAR_RENTALDataSet = new Car_Rental_System.CAR_RENTALDataSet();
            this.dISCOUNT_DETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dISCOUNT_DETAILSTableAdapter = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.DISCOUNT_DETAILSTableAdapter();
            this.tableAdapterManager = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager();
            this.dISCOUNT_DETAILSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISCOUNT_DETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISCOUNT_DETAILSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cAR_RENTALDataSet
            // 
            this.cAR_RENTALDataSet.DataSetName = "CAR_RENTALDataSet";
            this.cAR_RENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dISCOUNT_DETAILSBindingSource
            // 
            this.dISCOUNT_DETAILSBindingSource.DataMember = "DISCOUNT_DETAILS";
            this.dISCOUNT_DETAILSBindingSource.DataSource = this.cAR_RENTALDataSet;
            // 
            // dISCOUNT_DETAILSTableAdapter
            // 
            this.dISCOUNT_DETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLING_DETAILSTableAdapter = null;
            this.tableAdapterManager.BOOKING_DETAILSTableAdapter = null;
            this.tableAdapterManager.CAR_CATEGTableAdapter = null;
            this.tableAdapterManager.CARTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DISCOUNT_DETAILSTableAdapter = this.dISCOUNT_DETAILSTableAdapter;
            this.tableAdapterManager.LOCATION_DETAILSTableAdapter = null;
            this.tableAdapterManager.RENTAL_CAR_INSURANCETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dISCOUNT_DETAILSDataGridView
            // 
            this.dISCOUNT_DETAILSDataGridView.AutoGenerateColumns = false;
            this.dISCOUNT_DETAILSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dISCOUNT_DETAILSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dISCOUNT_DETAILSDataGridView.DataSource = this.dISCOUNT_DETAILSBindingSource;
            this.dISCOUNT_DETAILSDataGridView.Location = new System.Drawing.Point(0, 0);
            this.dISCOUNT_DETAILSDataGridView.Name = "dISCOUNT_DETAILSDataGridView";
            this.dISCOUNT_DETAILSDataGridView.Size = new System.Drawing.Size(443, 248);
            this.dISCOUNT_DETAILSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DISCOUNT_CODE";
            this.dataGridViewTextBoxColumn1.HeaderText = "DISCOUNT_CODE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DISCOUNT_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "DISCOUNT_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EXPIRE_DATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "EXPIRE_DATE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DISCOUNT_PERCENTAGE";
            this.dataGridViewTextBoxColumn4.HeaderText = "DISCOUNT_PERCENTAGE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // afficherRemises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 249);
            this.Controls.Add(this.dISCOUNT_DETAILSDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "afficherRemises";
            this.Text = "afficherRemises";
            this.Load += new System.EventHandler(this.afficherRemises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISCOUNT_DETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dISCOUNT_DETAILSDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CAR_RENTALDataSet cAR_RENTALDataSet;
        private System.Windows.Forms.BindingSource dISCOUNT_DETAILSBindingSource;
        private CAR_RENTALDataSetTableAdapters.DISCOUNT_DETAILSTableAdapter dISCOUNT_DETAILSTableAdapter;
        private CAR_RENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dISCOUNT_DETAILSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}