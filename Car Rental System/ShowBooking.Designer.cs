namespace Car_Rental_System
{
    partial class ShowBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBooking));
            this.cAR_RENTALDataSet = new Car_Rental_System.CAR_RENTALDataSet();
            this.bOOKING_DETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKING_DETAILSTableAdapter = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.BOOKING_DETAILSTableAdapter();
            this.tableAdapterManager = new Car_Rental_System.CAR_RENTALDataSetTableAdapters.TableAdapterManager();
            this.bOOKING_DETAILSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bOOKING_DETAILSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bOOKING_DETAILSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKING_DETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKING_DETAILSBindingNavigator)).BeginInit();
            this.bOOKING_DETAILSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKING_DETAILSDataGridView)).BeginInit();
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
            // bOOKING_DETAILSBindingNavigator
            // 
            this.bOOKING_DETAILSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bOOKING_DETAILSBindingNavigator.BindingSource = this.bOOKING_DETAILSBindingSource;
            this.bOOKING_DETAILSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bOOKING_DETAILSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bOOKING_DETAILSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bOOKING_DETAILSBindingNavigatorSaveItem});
            this.bOOKING_DETAILSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bOOKING_DETAILSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bOOKING_DETAILSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bOOKING_DETAILSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bOOKING_DETAILSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bOOKING_DETAILSBindingNavigator.Name = "bOOKING_DETAILSBindingNavigator";
            this.bOOKING_DETAILSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bOOKING_DETAILSBindingNavigator.Size = new System.Drawing.Size(815, 25);
            this.bOOKING_DETAILSBindingNavigator.TabIndex = 0;
            this.bOOKING_DETAILSBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bOOKING_DETAILSBindingNavigatorSaveItem
            // 
            this.bOOKING_DETAILSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bOOKING_DETAILSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bOOKING_DETAILSBindingNavigatorSaveItem.Image")));
            this.bOOKING_DETAILSBindingNavigatorSaveItem.Name = "bOOKING_DETAILSBindingNavigatorSaveItem";
            this.bOOKING_DETAILSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bOOKING_DETAILSBindingNavigatorSaveItem.Text = "Save Data";
            this.bOOKING_DETAILSBindingNavigatorSaveItem.Click += new System.EventHandler(this.bOOKING_DETAILSBindingNavigatorSaveItem_Click);
            // 
            // bOOKING_DETAILSDataGridView
            // 
            this.bOOKING_DETAILSDataGridView.AutoGenerateColumns = false;
            this.bOOKING_DETAILSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bOOKING_DETAILSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.bOOKING_DETAILSDataGridView.DataSource = this.bOOKING_DETAILSBindingSource;
            this.bOOKING_DETAILSDataGridView.Location = new System.Drawing.Point(0, 28);
            this.bOOKING_DETAILSDataGridView.Name = "bOOKING_DETAILSDataGridView";
            this.bOOKING_DETAILSDataGridView.Size = new System.Drawing.Size(815, 220);
            this.bOOKING_DETAILSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BOOKING_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BOOKING_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FROM_DT_TIME";
            this.dataGridViewTextBoxColumn2.HeaderText = "FROM_DT_TIME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RET_DT_TIME";
            this.dataGridViewTextBoxColumn3.HeaderText = "RET_DT_TIME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AMOUNT";
            this.dataGridViewTextBoxColumn4.HeaderText = "AMOUNT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BOOKING_STATUS";
            this.dataGridViewTextBoxColumn5.HeaderText = "BOOKING_STATUS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PICKUP_LOC";
            this.dataGridViewTextBoxColumn6.HeaderText = "PICKUP_LOC";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DROP_LOC";
            this.dataGridViewTextBoxColumn7.HeaderText = "DROP_LOC";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "REG_NUM";
            this.dataGridViewTextBoxColumn8.HeaderText = "REG_NUM";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DL_NUM";
            this.dataGridViewTextBoxColumn9.HeaderText = "DL_NUM";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "INS_CODE";
            this.dataGridViewTextBoxColumn10.HeaderText = "INS_CODE";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ACT_RET_DT_TIME";
            this.dataGridViewTextBoxColumn11.HeaderText = "ACT_RET_DT_TIME";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DISCOUNT_CODE";
            this.dataGridViewTextBoxColumn12.HeaderText = "DISCOUNT_CODE";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // ShowBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 246);
            this.Controls.Add(this.bOOKING_DETAILSDataGridView);
            this.Controls.Add(this.bOOKING_DETAILSBindingNavigator);
            this.Name = "ShowBooking";
            this.Text = "ShowBooking";
            this.Load += new System.EventHandler(this.ShowBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAR_RENTALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKING_DETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKING_DETAILSBindingNavigator)).EndInit();
            this.bOOKING_DETAILSBindingNavigator.ResumeLayout(false);
            this.bOOKING_DETAILSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKING_DETAILSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CAR_RENTALDataSet cAR_RENTALDataSet;
        private System.Windows.Forms.BindingSource bOOKING_DETAILSBindingSource;
        private CAR_RENTALDataSetTableAdapters.BOOKING_DETAILSTableAdapter bOOKING_DETAILSTableAdapter;
        private CAR_RENTALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bOOKING_DETAILSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bOOKING_DETAILSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bOOKING_DETAILSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}