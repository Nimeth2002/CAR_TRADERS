
namespace ABC_CAR_RENTAL_SERVICE_
{
    partial class Search_Car_Parts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Car_Parts));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCARPARTS = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchPart = new System.Windows.Forms.DataGridView();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBC_Car_Rental_ServiceDataSet4 = new ABC_CAR_RENTAL_SERVICE_.ABC_Car_Rental_ServiceDataSet4();
            this.carPartsTableAdapter = new ABC_CAR_RENTAL_SERVICE_.ABC_Car_Rental_ServiceDataSet4TableAdapters.CarPartsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Car_Rental_ServiceDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(154, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 138;
            this.label5.Text = "S E A R C H  C A R   P A R T S";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(215, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 139;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 140;
            this.label1.Text = "Part Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // txtCARPARTS
            // 
            this.txtCARPARTS.Location = new System.Drawing.Point(127, 151);
            this.txtCARPARTS.Name = "txtCARPARTS";
            this.txtCARPARTS.Size = new System.Drawing.Size(369, 26);
            this.txtCARPARTS.TabIndex = 159;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Location = new System.Drawing.Point(192, 213);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 65);
            this.btnSearch.TabIndex = 160;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchPart
            // 
            this.SearchPart.AutoGenerateColumns = false;
            this.SearchPart.BackgroundColor = System.Drawing.Color.Tomato;
            this.SearchPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.SearchPart.DataSource = this.carPartsBindingSource;
            this.SearchPart.Location = new System.Drawing.Point(-2, 296);
            this.SearchPart.Name = "SearchPart";
            this.SearchPart.RowHeadersWidth = 62;
            this.SearchPart.RowTemplate.Height = 28;
            this.SearchPart.Size = new System.Drawing.Size(513, 150);
            this.SearchPart.TabIndex = 161;
            this.SearchPart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            this.partIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.partIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "PartName";
            this.partNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // carPartsBindingSource
            // 
            this.carPartsBindingSource.DataMember = "CarParts";
            this.carPartsBindingSource.DataSource = this.aBC_Car_Rental_ServiceDataSet4;
            // 
            // aBC_Car_Rental_ServiceDataSet4
            // 
            this.aBC_Car_Rental_ServiceDataSet4.DataSetName = "ABC_Car_Rental_ServiceDataSet4";
            this.aBC_Car_Rental_ServiceDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carPartsTableAdapter
            // 
            this.carPartsTableAdapter.ClearBeforeFill = true;
            // 
            // Search_Car_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(509, 444);
            this.Controls.Add(this.SearchPart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCARPARTS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "Search_Car_Parts";
            this.Text = "Search_Car_Parts";
            this.Load += new System.EventHandler(this.Search_Car_Parts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_Car_Rental_ServiceDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCARPARTS;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView SearchPart;
        private ABC_Car_Rental_ServiceDataSet4 aBC_Car_Rental_ServiceDataSet4;
        private System.Windows.Forms.BindingSource carPartsBindingSource;
        private ABC_Car_Rental_ServiceDataSet4TableAdapters.CarPartsTableAdapter carPartsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}