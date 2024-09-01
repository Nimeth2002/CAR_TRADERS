
namespace ABC_CAR_RENTAL_SERVICE_
{
    partial class Car_parts_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_parts_Orders));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarPart = new System.Windows.Forms.MaskedTextBox();
            this.btnOrderCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPHONENUMBER = new System.Windows.Forms.MaskedTextBox();
            this.txtEMAIL = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDATE = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(133, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 20);
            this.label4.TabIndex = 142;
            this.label4.Text = "O R D E R    C A R    P A R T S \r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(68, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 145;
            this.label3.Text = "Part Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCarPart
            // 
            this.txtCarPart.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCarPart.Location = new System.Drawing.Point(208, 265);
            this.txtCarPart.Name = "txtCarPart";
            this.txtCarPart.Size = new System.Drawing.Size(225, 26);
            this.txtCarPart.TabIndex = 148;
            // 
            // btnOrderCar
            // 
            this.btnOrderCar.BackColor = System.Drawing.Color.DimGray;
            this.btnOrderCar.Location = new System.Drawing.Point(106, 411);
            this.btnOrderCar.Name = "btnOrderCar";
            this.btnOrderCar.Size = new System.Drawing.Size(309, 90);
            this.btnOrderCar.TabIndex = 149;
            this.btnOrderCar.Text = "Order";
            this.btnOrderCar.UseVisualStyleBackColor = false;
            this.btnOrderCar.Click += new System.EventHandler(this.btnOrderCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(68, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 150;
            this.label1.Text = "Phone Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(68, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 151;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPHONENUMBER
            // 
            this.txtPHONENUMBER.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPHONENUMBER.Location = new System.Drawing.Point(208, 187);
            this.txtPHONENUMBER.Name = "txtPHONENUMBER";
            this.txtPHONENUMBER.Size = new System.Drawing.Size(225, 26);
            this.txtPHONENUMBER.TabIndex = 152;
            this.txtPHONENUMBER.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEMAIL.Location = new System.Drawing.Point(208, 121);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(225, 26);
            this.txtEMAIL.TabIndex = 153;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(68, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 154;
            this.label5.Text = "Order Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // txtDATE
            // 
            this.txtDATE.Location = new System.Drawing.Point(208, 347);
            this.txtDATE.Name = "txtDATE";
            this.txtDATE.Size = new System.Drawing.Size(200, 26);
            this.txtDATE.TabIndex = 155;
            // 
            // Car_parts_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(522, 525);
            this.Controls.Add(this.txtDATE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtPHONENUMBER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrderCar);
            this.Controls.Add(this.txtCarPart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Car_parts_Orders";
            this.Text = "Car_parts_Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCarPart;
        private System.Windows.Forms.Button btnOrderCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPHONENUMBER;
        private System.Windows.Forms.MaskedTextBox txtEMAIL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtDATE;
    }
}