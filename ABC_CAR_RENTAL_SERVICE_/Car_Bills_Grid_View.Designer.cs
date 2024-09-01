
namespace ABC_CAR_RENTAL_SERVICE_
{
    partial class Car_Bills_Grid_View
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
            this.aBC_Car_Rental_ServiceDataSet6 = new ABC_CAR_RENTAL_SERVICE_.ABC_Car_Rental_ServiceDataSet6();
            this.carBillDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_Bill_DetailsTableAdapter = new ABC_CAR_RENTAL_SERVICE_.ABC_Car_Rental_ServiceDataSet6TableAdapters.Car_Bill_DetailsTableAdapter();
            this.billIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Car_Rental_ServiceDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBillDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.carModelNameDataGridViewTextBoxColumn,
            this.billDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBillDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(812, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // aBC_Car_Rental_ServiceDataSet6
            // 
            this.aBC_Car_Rental_ServiceDataSet6.DataSetName = "ABC_Car_Rental_ServiceDataSet6";
            this.aBC_Car_Rental_ServiceDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBillDetailsBindingSource
            // 
            this.carBillDetailsBindingSource.DataMember = "Car_Bill_Details";
            this.carBillDetailsBindingSource.DataSource = this.aBC_Car_Rental_ServiceDataSet6;
            // 
            // car_Bill_DetailsTableAdapter
            // 
            this.car_Bill_DetailsTableAdapter.ClearBeforeFill = true;
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
            // Car_Bills_Grid_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Car_Bills_Grid_View";
            this.Text = "Car_Bills_Grid_View";
            this.Load += new System.EventHandler(this.Car_Bills_Grid_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Car_Rental_ServiceDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBillDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ABC_Car_Rental_ServiceDataSet6 aBC_Car_Rental_ServiceDataSet6;
        private System.Windows.Forms.BindingSource carBillDetailsBindingSource;
        private ABC_Car_Rental_ServiceDataSet6TableAdapters.Car_Bill_DetailsTableAdapter car_Bill_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDateDataGridViewTextBoxColumn;
    }
}