namespace kekw
{
    partial class ServiceInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceInfo));
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.historyTableAdapter = new kekw.IOOP_AssignmentDataSet1TableAdapters.HistoryTableAdapter();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_AssignmentDataSet1 = new kekw.IOOP_AssignmentDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_AssignmentDataSet12 = new kekw.IOOP_AssignmentDataSet12();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOP_AssignmentDataSet2 = new kekw.IOOP_AssignmentDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serviceTableAdapter = new kekw.IOOP_AssignmentDataSet2TableAdapters.ServiceTableAdapter();
            this.servicesTableAdapter = new kekw.IOOP_AssignmentDataSet12TableAdapters.ServicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(599, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "- Same-day completion of the request is available with an upcharge of 30%.";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(671, 415);
            this.btnClose.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnClose.Size = new System.Drawing.Size(267, 52);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "C L O S E";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(85, 320);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 15);
            this.lbl.TabIndex = 32;
            this.lbl.Text = "Note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(599, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "- Each order is completed within 3 working days after receiving the order.";
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.iOOP_AssignmentDataSet1;
            // 
            // iOOP_AssignmentDataSet1
            // 
            this.iOOP_AssignmentDataSet1.DataSetName = "IOOP_AssignmentDataSet1";
            this.iOOP_AssignmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.serviceTypeDataGridViewTextBoxColumn,
            this.feesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.servicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(89, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(582, 194);
            this.dataGridView1.TabIndex = 31;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceTypeDataGridViewTextBoxColumn
            // 
            this.serviceTypeDataGridViewTextBoxColumn.DataPropertyName = "Service_Type";
            this.serviceTypeDataGridViewTextBoxColumn.HeaderText = "Service_Type";
            this.serviceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceTypeDataGridViewTextBoxColumn.Name = "serviceTypeDataGridViewTextBoxColumn";
            this.serviceTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // feesDataGridViewTextBoxColumn
            // 
            this.feesDataGridViewTextBoxColumn.DataPropertyName = "Fees";
            this.feesDataGridViewTextBoxColumn.HeaderText = "Fees";
            this.feesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feesDataGridViewTextBoxColumn.Name = "feesDataGridViewTextBoxColumn";
            this.feesDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.iOOP_AssignmentDataSet12;
            // 
            // iOOP_AssignmentDataSet12
            // 
            this.iOOP_AssignmentDataSet12.DataSetName = "IOOP_AssignmentDataSet12";
            this.iOOP_AssignmentDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.iOOP_AssignmentDataSet2;
            // 
            // iOOP_AssignmentDataSet2
            // 
            this.iOOP_AssignmentDataSet2.DataSetName = "IOOP_AssignmentDataSet2";
            this.iOOP_AssignmentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(83, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "APU Printing Service List";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(55, 40);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(931, 445);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1088, 572);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // ServiceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ServiceInfo";
            this.Text = "Service List";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOP_AssignmentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private IOOP_AssignmentDataSet1TableAdapters.HistoryTableAdapter historyTableAdapter;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private IOOP_AssignmentDataSet1 iOOP_AssignmentDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private IOOP_AssignmentDataSet2 iOOP_AssignmentDataSet2;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private IOOP_AssignmentDataSet2TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesDataGridViewTextBoxColumn;
        private IOOP_AssignmentDataSet12 iOOP_AssignmentDataSet12;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private IOOP_AssignmentDataSet12TableAdapters.ServicesTableAdapter servicesTableAdapter;
    }
}