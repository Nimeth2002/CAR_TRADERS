
namespace ABC_CAR_RENTAL_SERVICE_
{
    partial class Customer_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Login));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsernameC = new System.Windows.Forms.MaskedTextBox();
            this.txtPasswordC = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(184, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 20);
            this.label4.TabIndex = 123;
            this.label4.Text = "C U S T O M E R   L O G I N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(111, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 124;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(111, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 125;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // txtUsernameC
            // 
            this.txtUsernameC.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUsernameC.Location = new System.Drawing.Point(214, 174);
            this.txtUsernameC.Name = "txtUsernameC";
            this.txtUsernameC.Size = new System.Drawing.Size(211, 26);
            this.txtUsernameC.TabIndex = 128;
            // 
            // txtPasswordC
            // 
            this.txtPasswordC.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPasswordC.Location = new System.Drawing.Point(214, 267);
            this.txtPasswordC.Name = "txtPasswordC";
            this.txtPasswordC.Size = new System.Drawing.Size(211, 26);
            this.txtPasswordC.TabIndex = 129;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(116, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 90);
            this.button1.TabIndex = 130;
            this.button1.Text = "Login ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Register.Location = new System.Drawing.Point(184, 311);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(153, 20);
            this.Register.TabIndex = 131;
            this.Register.Text = "** R E G I S T E R **";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Customer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(551, 462);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPasswordC);
            this.Controls.Add(this.txtUsernameC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "Customer_Login";
            this.Text = "Customer_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtUsernameC;
        private System.Windows.Forms.MaskedTextBox txtPasswordC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Register;
    }
}