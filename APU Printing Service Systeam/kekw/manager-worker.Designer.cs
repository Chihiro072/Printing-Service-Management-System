namespace kekw
{
    partial class AssignWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignWorker));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderHistoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_AssignmentDataSet13 = new kekw.IOOP_AssignmentDataSet13();
            this.orderHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_AssignmentDataSet9 = new kekw.IOOP_AssignmentDataSet9();
            this.button1 = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.orderHistoryTableAdapter = new kekw.IOOP_AssignmentDataSet9TableAdapters.OrderHistoryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.orderHistoryTableAdapter1 = new kekw.IOOP_AssignmentDataSet13TableAdapters.OrderHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Urgent,
            this.WorkerID});
            this.dataGridView1.DataSource = this.orderHistoryBindingSource1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            resources.ApplyResources(this.orderIDDataGridViewTextBoxColumn, "orderIDDataGridViewTextBoxColumn");
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            resources.ApplyResources(this.usernameDataGridViewTextBoxColumn, "usernameDataGridViewTextBoxColumn");
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            resources.ApplyResources(this.serviceDataGridViewTextBoxColumn, "serviceDataGridViewTextBoxColumn");
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            resources.ApplyResources(this.quantityDataGridViewTextBoxColumn, "quantityDataGridViewTextBoxColumn");
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            resources.ApplyResources(this.unitPriceDataGridViewTextBoxColumn, "unitPriceDataGridViewTextBoxColumn");
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            resources.ApplyResources(this.subtotalDataGridViewTextBoxColumn, "subtotalDataGridViewTextBoxColumn");
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            resources.ApplyResources(this.requestDateDataGridViewTextBoxColumn, "requestDateDataGridViewTextBoxColumn");
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            resources.ApplyResources(this.statusDataGridViewTextBoxColumn, "statusDataGridViewTextBoxColumn");
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Urgent
            // 
            this.Urgent.DataPropertyName = "Urgent";
            resources.ApplyResources(this.Urgent, "Urgent");
            this.Urgent.Name = "Urgent";
            this.Urgent.ReadOnly = true;
            // 
            // WorkerID
            // 
            this.WorkerID.DataPropertyName = "WorkerID";
            resources.ApplyResources(this.WorkerID, "WorkerID");
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.ReadOnly = true;
            // 
            // orderHistoryBindingSource1
            // 
            this.orderHistoryBindingSource1.DataMember = "OrderHistory";
            this.orderHistoryBindingSource1.DataSource = this.iOOP_AssignmentDataSet13;
            // 
            // iOOP_AssignmentDataSet13
            // 
            this.iOOP_AssignmentDataSet13.DataSetName = "IOOP_AssignmentDataSet13";
            this.iOOP_AssignmentDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderHistoryBindingSource
            // 
            this.orderHistoryBindingSource.DataMember = "OrderHistory";
            this.orderHistoryBindingSource.DataSource = this.iOOP_AssignmentDataSet9;
            // 
            // iOOP_AssignmentDataSet9
            // 
            this.iOOP_AssignmentDataSet9.DataSetName = "IOOP_AssignmentDataSet9";
            this.iOOP_AssignmentDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Confirm
            // 
            resources.ApplyResources(this.Confirm, "Confirm");
            this.Confirm.Name = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // orderHistoryTableAdapter
            // 
            this.orderHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // orderHistoryTableAdapter1
            // 
            this.orderHistoryTableAdapter1.ClearBeforeFill = true;
            // 
            // AssignWorker
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AssignWorker";
            this.Load += new System.EventHandler(this.manager_worker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Confirm;
        private IOOP_AssignmentDataSet9 iOOP_AssignmentDataSet9;
        private System.Windows.Forms.BindingSource orderHistoryBindingSource;
        private IOOP_AssignmentDataSet9TableAdapters.OrderHistoryTableAdapter orderHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private IOOP_AssignmentDataSet13 iOOP_AssignmentDataSet13;
        private System.Windows.Forms.BindingSource orderHistoryBindingSource1;
        private IOOP_AssignmentDataSet13TableAdapters.OrderHistoryTableAdapter orderHistoryTableAdapter1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Urgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerID;
    }
}