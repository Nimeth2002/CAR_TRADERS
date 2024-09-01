
namespace ABC_CAR_RENTAL_SERVICE_
{
    partial class Manage_Car_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Car_Orders));
            this.label4 = new System.Windows.Forms.Label();
            this.CaOrders = new System.Windows.Forms.DataGridView();
            this.billIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBillDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_Car_Rental_ServiceDataSet5 = new ABC_CAR_RENTAL_SERVICE_.ABC_Car_Rental_ServiceDataSet5();
            this.car_Bill_DetailsTableAdapter = new ABC_CAR_RENTAL_SERVICE_.ABC_Car_Rental_ServiceDataSet5TableAdapters.Car_Bill_DetailsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSEARCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBillDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Car_Rental_ServiceDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(273, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 40);
            this.label4.TabIndex = 138;
            this.label4.Text = "M A N A G E   C A R    O R D E R S\r\n\r\n";
            // 
            // CaOrders
            // 
            this.CaOrders.AutoGenerateColumns = false;
            this.CaOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CaOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.carModelNameDataGridViewTextBoxColumn,
            this.billDateDataGridViewTextBoxColumn});
            this.CaOrders.DataSource = this.carBillDetailsBindingSource;
            this.CaOrders.Location = new System.Drawing.Point(-3, 379);
            this.CaOrders.Name = "CaOrders";
            this.CaOrders.RowHeadersWidth = 62;
            this.CaOrders.RowTemplate.Height = 28;
            this.CaOrders.Size = new System.Drawing.Size(813, 245);
            this.CaOrders.TabIndex = 139;
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
            // carModelNameDataGridViewTextBoxColumn
            // 
            this.carModelNameDataGridViewTextBoxColumn.DataPropertyName = "Car_Model_Name";
            this.carModelNameDataGridViewTextBoxColumn.HeaderText = "Car_Model_Name";
            this.carModelNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carModelNameDataGridViewTextBoxColumn.Name = "carModelNameDataGridViewTextBoxColumn";
            this.carModelNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // billDateDataGridViewTextBoxColumn
            // 
            this.billDateDataGridViewTextBoxColumn.DataPropertyName = "BillDate";
            this.billDateDataGridViewTextBoxColumn.HeaderText = "BillDate";
            this.billDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.billDateDataGridViewTextBoxColumn.Name = "billDateDataGridViewTextBoxColumn";
            this.billDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // carBillDetailsBindingSource
            // 
            this.carBillDetailsBindingSource.DataMember = "Car_Bill_Details";
            this.carBillDetailsBindingSource.DataSource = this.aBC_Car_Rental_ServiceDataSet5;
            // 
            // aBC_Car_Rental_ServiceDataSet5
            // 
            this.aBC_Car_Rental_ServiceDataSet5.DataSetName = "ABC_Car_Rental_ServiceDataSet5";
            this.aBC_Car_Rental_ServiceDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_Bill_DetailsTableAdapter
            // 
            this.car_Bill_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(180, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 163;
            this.label5.Text = "BillID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(318, 160);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(328, 26);
            this.txtBillID.TabIndex = 167;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.Location = new System.Drawing.Point(559, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 90);
            this.btnDelete.TabIndex = 168;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.BackColor = System.Drawing.Color.DimGray;
            this.btnSEARCH.Location = new System.Drawing.Point(151, 271);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(140, 90);
            this.btnSEARCH.TabIndex = 170;
            this.btnSEARCH.Text = "Search";
            this.btnSEARCH.UseVisualStyleBackColor = false;
            this.btnSEARCH.Click += new System.EventHandler(this.btnSEARCH_Click);
            // 
            // Manage_Car_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 622);
            this.Controls.Add(this.btnSEARCH);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBillID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CaOrders);
            this.Controls.Add(this.label4);
            this.Name = "Manage_Car_Orders";
            this.Text = "Manage_Car_Orders";
            this.Load += new System.EventHandler(this.Manage_Car_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBillDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Car_Rental_ServiceDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CaOrders;
        private ABC_Car_Rental_ServiceDataSet5 aBC_Car_Rental_ServiceDataSet5;
        private System.Windows.Forms.BindingSource carBillDetailsBindingSource;
        private ABC_Car_Rental_ServiceDataSet5TableAdapters.Car_Bill_DetailsTableAdapter car_Bill_DetailsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSEARCH;
    }
}