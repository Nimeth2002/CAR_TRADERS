
namespace ABC_CAR_RENTAL_SERVICE_
{
    partial class Manage_Part_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Part_Orders));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CarPartOrdersTable = new System.Windows.Forms.DataGridView();
            this.billIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARpARTBillDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_Car_Rental_ServiceDataSet8 = new ABC_CAR_RENTAL_SERVICE_.ABC_Car_Rental_ServiceDataSet8();
            this.cAR_pART_Bill_DetailsTableAdapter = new ABC_CAR_RENTAL_SERVICE_.ABC_Car_Rental_ServiceDataSet8TableAdapters.CAR_pART_Bill_DetailsTableAdapter();
            this.txtBillid = new System.Windows.Forms.TextBox();
            this.btndeleTE = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarPartOrdersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARpARTBillDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Car_Rental_ServiceDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(262, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 40);
            this.label4.TabIndex = 139;
            this.label4.Text = "M A N A G E   C A R    P A R T   O R D E R S \r\n\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(162, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 167;
            this.label3.Text = "BillID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // CarPartOrdersTable
            // 
            this.CarPartOrdersTable.AutoGenerateColumns = false;
            this.CarPartOrdersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarPartOrdersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.billDateDataGridViewTextBoxColumn});
            this.CarPartOrdersTable.DataSource = this.cARpARTBillDetailsBindingSource;
            this.CarPartOrdersTable.Location = new System.Drawing.Point(-1, 408);
            this.CarPartOrdersTable.Name = "CarPartOrdersTable";
            this.CarPartOrdersTable.RowHeadersWidth = 62;
            this.CarPartOrdersTable.RowTemplate.Height = 28;
            this.CarPartOrdersTable.Size = new System.Drawing.Size(813, 150);
            this.CarPartOrdersTable.TabIndex = 169;
            // 
            // billIDDataGridViewTextBoxColumn
            // 
            this.billIDDataGridViewTextBoxColumn.DataPropertyName = "BillID";
            this.billIDDataGridViewTextBoxColumn.HeaderText = "BillID";
            this.billIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.billIDDataGridViewTextBoxColumn.Name = "billIDDataGridViewTextBoxColumn";
            this.billIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.billIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "PartName";
            this.partNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // billDateDataGridViewTextBoxColumn
            // 
            this.billDateDataGridViewTextBoxColumn.DataPropertyName = "BillDate";
            this.billDateDataGridViewTextBoxColumn.HeaderText = "BillDate";
            this.billDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.billDateDataGridViewTextBoxColumn.Name = "billDateDataGridViewTextBoxColumn";
            this.billDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // cARpARTBillDetailsBindingSource
            // 
            this.cARpARTBillDetailsBindingSource.DataMember = "CAR_pART_Bill_Details";
            this.cARpARTBillDetailsBindingSource.DataSource = this.aBC_Car_Rental_ServiceDataSet8;
            // 
            // aBC_Car_Rental_ServiceDataSet8
            // 
            this.aBC_Car_Rental_ServiceDataSet8.DataSetName = "ABC_Car_Rental_ServiceDataSet8";
            this.aBC_Car_Rental_ServiceDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAR_pART_Bill_DetailsTableAdapter
            // 
            this.cAR_pART_Bill_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // txtBillid
            // 
            this.txtBillid.Location = new System.Drawing.Point(310, 177);
            this.txtBillid.Name = "txtBillid";
            this.txtBillid.Size = new System.Drawing.Size(328, 26);
            this.txtBillid.TabIndex = 170;
            // 
            // btndeleTE
            // 
            this.btndeleTE.BackColor = System.Drawing.Color.DimGray;
            this.btndeleTE.Location = new System.Drawing.Point(498, 312);
            this.btndeleTE.Name = "btndeleTE";
            this.btndeleTE.Size = new System.Drawing.Size(140, 90);
            this.btndeleTE.TabIndex = 174;
            this.btndeleTE.Text = "Delete";
            this.btndeleTE.UseVisualStyleBackColor = false;
            this.btndeleTE.Click += new System.EventHandler(this.btndeleTE_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Location = new System.Drawing.Point(162, 312);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 90);
            this.btnSearch.TabIndex = 175;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Manage_Part_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 556);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btndeleTE);
            this.Controls.Add(this.txtBillid);
            this.Controls.Add(this.CarPartOrdersTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Manage_Part_Orders";
            this.Text = "Manage_Part_Orders";
            this.Load += new System.EventHandler(this.Manage_Part_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarPartOrdersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARpARTBillDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Car_Rental_ServiceDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CarPartOrdersTable;
        private ABC_Car_Rental_ServiceDataSet8 aBC_Car_Rental_ServiceDataSet8;
        private System.Windows.Forms.BindingSource cARpARTBillDetailsBindingSource;
        private ABC_Car_Rental_ServiceDataSet8TableAdapters.CAR_pART_Bill_DetailsTableAdapter cAR_pART_Bill_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBillid;
        private System.Windows.Forms.Button btndeleTE;
        private System.Windows.Forms.Button btnSearch;
    }
}