namespace Car_Rental_System
{
    partial class afficherFac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(afficherFac));
            this.cAR_RENTALDataSet = new Car_Rental_System.CAR_RENTALDataSet();
            this.bILLING_DETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bILLING_DETAILSTableAdapter = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.BILLING_DETAILSTableAdapter();
            this.tableAdapterManager = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager();
            this.bILLING_DETAILSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bILLING_DETAILSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bILLING_DETAILSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLING_DETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLING_DETAILSBindingNavigator)).BeginInit();
            this.bILLING_DETAILSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bILLING_DETAILSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cAR_RENTALDataSet
            // 
            this.cAR_RENTALDataSet.DataSetName = "CAR_RENTALDataSet";
            this.cAR_RENTALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bILLING_DETAILSBindingSource
            // 
            this.bILLING_DETAILSBindingSource.DataMember = "BILLING_DETAILS";
            this.bILLING_DETAILSBindingSource.DataSource = this.cAR_RENTALDataSet;
            // 
            // bILLING_DETAILSTableAdapter
            // 
            this.bILLING_DETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLING_DETAILSTableAdapter = this.bILLING_DETAILSTableAdapter;
            this.tableAdapterManager.BOOKING_DETAILSTableAdapter = null;
            this.tableAdapterManager.CAR_CATEGTableAdapter = null;
            this.tableAdapterManager.CARTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DISCOUNT_DETAILSTableAdapter = null;
            this.tableAdapterManager.LOCATION_DETAILSTableAdapter = null;
            this.tableAdapterManager.RENTAL_CAR_INSURANCETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bILLING_DETAILSBindingNavigator
            // 
            this.bILLING_DETAILSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bILLING_DETAILSBindingNavigator.BindingSource = this.bILLING_DETAILSBindingSource;
            this.bILLING_DETAILSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bILLING_DETAILSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bILLING_DETAILSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bILLING_DETAILSBindingNavigatorSaveItem});
            this.bILLING_DETAILSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bILLING_DETAILSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bILLING_DETAILSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bILLING_DETAILSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bILLING_DETAILSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bILLING_DETAILSBindingNavigator.Name = "bILLING_DETAILSBindingNavigator";
            this.bILLING_DETAILSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bILLING_DETAILSBindingNavigator.Size = new System.Drawing.Size(847, 25);
            this.bILLING_DETAILSBindingNavigator.TabIndex = 0;
            this.bILLING_DETAILSBindingNavigator.Text = "bindingNavigator1";
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
            // bILLING_DETAILSBindingNavigatorSaveItem
            // 
            this.bILLING_DETAILSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bILLING_DETAILSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bILLING_DETAILSBindingNavigatorSaveItem.Image")));
            this.bILLING_DETAILSBindingNavigatorSaveItem.Name = "bILLING_DETAILSBindingNavigatorSaveItem";
            this.bILLING_DETAILSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bILLING_DETAILSBindingNavigatorSaveItem.Text = "Save Data";
            this.bILLING_DETAILSBindingNavigatorSaveItem.Click += new System.EventHandler(this.bILLING_DETAILSBindingNavigatorSaveItem_Click);
            // 
            // bILLING_DETAILSDataGridView
            // 
            this.bILLING_DETAILSDataGridView.AutoGenerateColumns = false;
            this.bILLING_DETAILSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bILLING_DETAILSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.bILLING_DETAILSDataGridView.DataSource = this.bILLING_DETAILSBindingSource;
            this.bILLING_DETAILSDataGridView.Location = new System.Drawing.Point(0, 28);
            this.bILLING_DETAILSDataGridView.Name = "bILLING_DETAILSDataGridView";
            this.bILLING_DETAILSDataGridView.Size = new System.Drawing.Size(845, 220);
            this.bILLING_DETAILSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BILL_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BILL_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BILL_DATE";
            this.dataGridViewTextBoxColumn2.HeaderText = "BILL_DATE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BILL_STATUS";
            this.dataGridViewTextBoxColumn3.HeaderText = "BILL_STATUS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DISCOUNT_AMOUNT";
            this.dataGridViewTextBoxColumn4.HeaderText = "DISCOUNT_AMOUNT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TOTAL_AMOUNT";
            this.dataGridViewTextBoxColumn5.HeaderText = "TOTAL_AMOUNT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TAX_AMOUNT";
            this.dataGridViewTextBoxColumn6.HeaderText = "TAX_AMOUNT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BOOKING_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "BOOKING_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TOTAL_LATE_FEE";
            this.dataGridViewTextBoxColumn8.HeaderText = "TOTAL_LATE_FEE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // afficherFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 247);
            this.Controls.Add(this.bILLING_DETAILSDataGridView);
            this.Controls.Add(this.bILLING_DETAILSBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "afficherFac";
            this.Text = "afficherFac";
            this.Load += new System.EventHandler(this.afficherFac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLING_DETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLING_DETAILSBindingNavigator)).EndInit();
            this.bILLING_DETAILSBindingNavigator.ResumeLayout(false);
            this.bILLING_DETAILSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bILLING_DETAILSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CAR_RENTALDataSet cAR_RENTALDataSet;
        private System.Windows.Forms.BindingSource bILLING_DETAILSBindingSource;
        private CAR_RENTALDataSetTableAdapters.BILLING_DETAILSTableAdapter bILLING_DETAILSTableAdapter;
        private CAR_RENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bILLING_DETAILSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bILLING_DETAILSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bILLING_DETAILSDataGridView;
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