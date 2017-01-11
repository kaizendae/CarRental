namespace Car_Rental_System
{
    partial class afficherVoiture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(afficherVoiture));
            this.cAR_RENTALDataSet = new Car_Rental_System.CAR_RENTALDataSet();
            this.cARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARTableAdapter = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.CARTableAdapter();
            this.tableAdapterManager = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager();
            this.cARDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cAR_RENTALDataSet
            // 
            this.cAR_RENTALDataSet.DataSetName = "CAR_RENTALDataSet";
            this.cAR_RENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cARBindingSource
            // 
            this.cARBindingSource.DataMember = "CAR";
            this.cARBindingSource.DataSource = this.cAR_RENTALDataSet;
            // 
            // cARTableAdapter
            // 
            this.cARTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLING_DETAILSTableAdapter = null;
            this.tableAdapterManager.BOOKING_DETAILSTableAdapter = null;
            this.tableAdapterManager.CAR_CATEGTableAdapter = null;
            this.tableAdapterManager.CARTableAdapter = this.cARTableAdapter;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DISCOUNT_DETAILSTableAdapter = null;
            this.tableAdapterManager.LOCATION_DETAILSTableAdapter = null;
            this.tableAdapterManager.RENTAL_CAR_INSURANCETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cARDataGridView
            // 
            this.cARDataGridView.AutoGenerateColumns = false;
            this.cARDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cARDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.cARDataGridView.DataSource = this.cARBindingSource;
            this.cARDataGridView.Location = new System.Drawing.Point(0, -2);
            this.cARDataGridView.Name = "cARDataGridView";
            this.cARDataGridView.Size = new System.Drawing.Size(840, 299);
            this.cARDataGridView.TabIndex = 1;
            this.cARDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cARDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "REGISTRATION_NUMBER";
            this.dataGridViewTextBoxColumn1.HeaderText = "REGISTRATION_NUMBER";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MODEL_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "MODEL_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MAKE";
            this.dataGridViewTextBoxColumn3.HeaderText = "MAKE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MODEL_YEAR";
            this.dataGridViewTextBoxColumn4.HeaderText = "MODEL_YEAR";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MILEAGE";
            this.dataGridViewTextBoxColumn5.HeaderText = "MILEAGE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CAR_CATEGORY_NAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "CAR_CATEGORY_NAME";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LOC_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "LOC_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AVAILABILITY_FLAG";
            this.dataGridViewTextBoxColumn8.HeaderText = "AVAILABILITY_FLAG";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // afficherVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 297);
            this.Controls.Add(this.cARDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "afficherVoiture";
            this.Text = "afficherVoiture";
            this.Load += new System.EventHandler(this.afficherVoiture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CAR_RENTALDataSet cAR_RENTALDataSet;
        private System.Windows.Forms.BindingSource cARBindingSource;
        private CAR_RENTALDataSetTableAdapters.CARTableAdapter cARTableAdapter;
        private CAR_RENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cARDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}