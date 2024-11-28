namespace kekw
{
    partial class ProcessReq
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblworkerID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.workerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_AssignmentDataSet14 = new kekw.IOOP_AssignmentDataSet14();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.orderHistoryTableAdapter = new kekw.IOOP_AssignmentDataSet14TableAdapters.OrderHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(74, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "2";
            // 
            // lblworkerID
            // 
            this.lblworkerID.AutoSize = true;
            this.lblworkerID.BackColor = System.Drawing.Color.Transparent;
            this.lblworkerID.Location = new System.Drawing.Point(4, 3);
            this.lblworkerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblworkerID.Name = "lblworkerID";
            this.lblworkerID.Size = new System.Drawing.Size(79, 15);
            this.lblworkerID.TabIndex = 10;
            this.lblworkerID.Text = "WorkerID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.urgentDataGridViewCheckBoxColumn,
            this.workerIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(937, 320);
            this.dataGridView1.TabIndex = 9;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // urgentDataGridViewCheckBoxColumn
            // 
            this.urgentDataGridViewCheckBoxColumn.DataPropertyName = "Urgent";
            this.urgentDataGridViewCheckBoxColumn.HeaderText = "Urgent";
            this.urgentDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.urgentDataGridViewCheckBoxColumn.Name = "urgentDataGridViewCheckBoxColumn";
            this.urgentDataGridViewCheckBoxColumn.ReadOnly = true;
            this.urgentDataGridViewCheckBoxColumn.Width = 125;
            // 
            // workerIDDataGridViewTextBoxColumn
            // 
            this.workerIDDataGridViewTextBoxColumn.DataPropertyName = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.HeaderText = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workerIDDataGridViewTextBoxColumn.Name = "workerIDDataGridViewTextBoxColumn";
            this.workerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderHistoryBindingSource
            // 
            this.orderHistoryBindingSource.DataMember = "OrderHistory";
            this.orderHistoryBindingSource.DataSource = this.iOOP_AssignmentDataSet14;
            // 
            // iOOP_AssignmentDataSet14
            // 
            this.iOOP_AssignmentDataSet14.DataSetName = "IOOP_AssignmentDataSet14";
            this.iOOP_AssignmentDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(742, 391);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(208, 95);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 391);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 95);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // orderHistoryTableAdapter
            // 
            this.orderHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // ProcessReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblworkerID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Name = "ProcessReq";
            this.Text = "workerform";
            this.Load += new System.EventHandler(this.workerform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblworkerID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private IOOP_AssignmentDataSet14 iOOP_AssignmentDataSet14;
        private System.Windows.Forms.BindingSource orderHistoryBindingSource;
        private IOOP_AssignmentDataSet14TableAdapters.OrderHistoryTableAdapter orderHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIDDataGridViewTextBoxColumn;
    }
}