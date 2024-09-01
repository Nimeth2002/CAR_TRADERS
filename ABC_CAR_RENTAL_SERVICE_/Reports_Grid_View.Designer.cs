
namespace ABC_CAR_RENTAL_SERVICE_
{
    partial class Reports_Grid_View
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aBC_Car_Rental_ServiceDataSet11 = new ABC_CAR_RENTAL_SERVICE_.ABC_Car_Rental_ServiceDataSet11();
            this.reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsTableAdapter = new ABC_CAR_RENTAL_SERVICE_.ABC_Car_Rental_ServiceDataSet11TableAdapters.ReportsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelNameorPartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Car_Rental_ServiceDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.carModelNameorPartDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityAvailableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(807, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // aBC_Car_Rental_ServiceDataSet11
            // 
            this.aBC_Car_Rental_ServiceDataSet11.DataSetName = "ABC_Car_Rental_ServiceDataSet11";
            this.aBC_Car_Rental_ServiceDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportsBindingSource
            // 
            this.reportsBindingSource.DataMember = "Reports";
            this.reportsBindingSource.DataSource = this.aBC_Car_Rental_ServiceDataSet11;
            // 
            // reportsTableAdapter
            // 
            this.reportsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // carModelNameorPartDataGridViewTextBoxColumn
            // 
            this.carModelNameorPartDataGridViewTextBoxColumn.DataPropertyName = "CarModelNameorPart";
            this.carModelNameorPartDataGridViewTextBoxColumn.HeaderText = "CarModelNameorPart";
            this.carModelNameorPartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carModelNameorPartDataGridViewTextBoxColumn.Name = "carModelNameorPartDataGridViewTextBoxColumn";
            this.carModelNameorPartDataGridViewTextBoxColumn.Width = 150;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityAvailableDataGridViewTextBoxColumn
            // 
            this.quantityAvailableDataGridViewTextBoxColumn.DataPropertyName = "QuantityAvailable";
            this.quantityAvailableDataGridViewTextBoxColumn.HeaderText = "QuantityAvailable";
            this.quantityAvailableDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityAvailableDataGridViewTextBoxColumn.Name = "quantityAvailableDataGridViewTextBoxColumn";
            this.quantityAvailableDataGridViewTextBoxColumn.Width = 150;
            // 
            // Reports_Grid_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reports_Grid_View";
            this.Text = "Reports_Grid_View";
            this.Load += new System.EventHandler(this.Reports_Grid_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Car_Rental_ServiceDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ABC_Car_Rental_ServiceDataSet11 aBC_Car_Rental_ServiceDataSet11;
        private System.Windows.Forms.BindingSource reportsBindingSource;
        private ABC_Car_Rental_ServiceDataSet11TableAdapters.ReportsTableAdapter reportsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelNameorPartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityAvailableDataGridViewTextBoxColumn;
    }
}