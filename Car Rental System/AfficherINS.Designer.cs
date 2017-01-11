namespace Car_Rental_System
{
    partial class AfficherINS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfficherINS));
            this.cAR_RENTALDataSet = new Car_Rental_System.CAR_RENTALDataSet();
            this.rENTAL_CAR_INSURANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rENTAL_CAR_INSURANCETableAdapter = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.RENTAL_CAR_INSURANCETableAdapter();
            this.tableAdapterManager = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager();
            this.rENTAL_CAR_INSURANCEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rENTAL_CAR_INSURANCEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rENTAL_CAR_INSURANCEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTAL_CAR_INSURANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTAL_CAR_INSURANCEBindingNavigator)).BeginInit();
            this.rENTAL_CAR_INSURANCEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rENTAL_CAR_INSURANCEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cAR_RENTALDataSet
            // 
            this.cAR_RENTALDataSet.DataSetName = "CAR_RENTALDataSet";
            this.cAR_RENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rENTAL_CAR_INSURANCEBindingSource
            // 
            this.rENTAL_CAR_INSURANCEBindingSource.DataMember = "RENTAL_CAR_INSURANCE";
            this.rENTAL_CAR_INSURANCEBindingSource.DataSource = this.cAR_RENTALDataSet;
            // 
            // rENTAL_CAR_INSURANCETableAdapter
            // 
            this.rENTAL_CAR_INSURANCETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLING_DETAILSTableAdapter = null;
            this.tableAdapterManager.BOOKING_DETAILSTableAdapter = null;
            this.tableAdapterManager.CAR_CATEGTableAdapter = null;
            this.tableAdapterManager.CARTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DISCOUNT_DETAILSTableAdapter = null;
            this.tableAdapterManager.LOCATION_DETAILSTableAdapter = null;
            this.tableAdapterManager.RENTAL_CAR_INSURANCETableAdapter = this.rENTAL_CAR_INSURANCETableAdapter;
            this.tableAdapterManager.UpdateOrder = Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rENTAL_CAR_INSURANCEBindingNavigator
            // 
            this.rENTAL_CAR_INSURANCEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rENTAL_CAR_INSURANCEBindingNavigator.BindingSource = this.rENTAL_CAR_INSURANCEBindingSource;
            this.rENTAL_CAR_INSURANCEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rENTAL_CAR_INSURANCEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rENTAL_CAR_INSURANCEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rENTAL_CAR_INSURANCEBindingNavigatorSaveItem});
            this.rENTAL_CAR_INSURANCEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rENTAL_CAR_INSURANCEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rENTAL_CAR_INSURANCEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rENTAL_CAR_INSURANCEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rENTAL_CAR_INSURANCEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rENTAL_CAR_INSURANCEBindingNavigator.Name = "rENTAL_CAR_INSURANCEBindingNavigator";
            this.rENTAL_CAR_INSURANCEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rENTAL_CAR_INSURANCEBindingNavigator.Size = new System.Drawing.Size(447, 25);
            this.rENTAL_CAR_INSURANCEBindingNavigator.TabIndex = 0;
            this.rENTAL_CAR_INSURANCEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rENTAL_CAR_INSURANCEBindingNavigatorSaveItem
            // 
            this.rENTAL_CAR_INSURANCEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rENTAL_CAR_INSURANCEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rENTAL_CAR_INSURANCEBindingNavigatorSaveItem.Image")));
            this.rENTAL_CAR_INSURANCEBindingNavigatorSaveItem.Name = "rENTAL_CAR_INSURANCEBindingNavigatorSaveItem";
            this.rENTAL_CAR_INSURANCEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rENTAL_CAR_INSURANCEBindingNavigatorSaveItem.Text = "Save Data";
            this.rENTAL_CAR_INSURANCEBindingNavigatorSaveItem.Click += new System.EventHandler(this.rENTAL_CAR_INSURANCEBindingNavigatorSaveItem_Click);
            // 
            // rENTAL_CAR_INSURANCEDataGridView
            // 
            this.rENTAL_CAR_INSURANCEDataGridView.AutoGenerateColumns = false;
            this.rENTAL_CAR_INSURANCEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rENTAL_CAR_INSURANCEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.rENTAL_CAR_INSURANCEDataGridView.DataSource = this.rENTAL_CAR_INSURANCEBindingSource;
            this.rENTAL_CAR_INSURANCEDataGridView.Location = new System.Drawing.Point(0, 28);
            this.rENTAL_CAR_INSURANCEDataGridView.Name = "rENTAL_CAR_INSURANCEDataGridView";
            this.rENTAL_CAR_INSURANCEDataGridView.Size = new System.Drawing.Size(445, 220);
            this.rENTAL_CAR_INSURANCEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "INSURANCE_CODE";
            this.dataGridViewTextBoxColumn1.HeaderText = "INSURANCE_CODE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "INSURANCE_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "INSURANCE_NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COVERAGE_TYPE";
            this.dataGridViewTextBoxColumn3.HeaderText = "COVERAGE_TYPE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COST_PER_DAY";
            this.dataGridViewTextBoxColumn4.HeaderText = "COST_PER_DAY";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // AfficherINS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 249);
            this.Controls.Add(this.rENTAL_CAR_INSURANCEDataGridView);
            this.Controls.Add(this.rENTAL_CAR_INSURANCEBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AfficherINS";
            this.Text = "AfficherINS";
            this.Load += new System.EventHandler(this.AfficherINS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTAL_CAR_INSURANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTAL_CAR_INSURANCEBindingNavigator)).EndInit();
            this.rENTAL_CAR_INSURANCEBindingNavigator.ResumeLayout(false);
            this.rENTAL_CAR_INSURANCEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rENTAL_CAR_INSURANCEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CAR_RENTALDataSet cAR_RENTALDataSet;
        private System.Windows.Forms.BindingSource rENTAL_CAR_INSURANCEBindingSource;
        private CAR_RENTALDataSetTableAdapters.RENTAL_CAR_INSURANCETableAdapter rENTAL_CAR_INSURANCETableAdapter;
        private CAR_RENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rENTAL_CAR_INSURANCEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rENTAL_CAR_INSURANCEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rENTAL_CAR_INSURANCEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}