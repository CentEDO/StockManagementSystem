
namespace VPMidterm
{
    partial class OrderProductForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbboxManufacturerCompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbboxWarehouse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbboxProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtbxQuantity = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBackNavForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(191, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "ORDER PRODUCT FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select the Manufacturer Factory";
            // 
            // cmbboxManufacturerCompany
            // 
            this.cmbboxManufacturerCompany.FormattingEnabled = true;
            this.cmbboxManufacturerCompany.Location = new System.Drawing.Point(404, 99);
            this.cmbboxManufacturerCompany.Name = "cmbboxManufacturerCompany";
            this.cmbboxManufacturerCompany.Size = new System.Drawing.Size(121, 21);
            this.cmbboxManufacturerCompany.TabIndex = 9;
            this.cmbboxManufacturerCompany.SelectedIndexChanged += new System.EventHandler(this.cmbboxManufacturerCompany_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select the Warehouse";
            // 
            // cmbboxWarehouse
            // 
            this.cmbboxWarehouse.FormattingEnabled = true;
            this.cmbboxWarehouse.Location = new System.Drawing.Point(404, 175);
            this.cmbboxWarehouse.Name = "cmbboxWarehouse";
            this.cmbboxWarehouse.Size = new System.Drawing.Size(121, 21);
            this.cmbboxWarehouse.TabIndex = 11;
            this.cmbboxWarehouse.SelectedIndexChanged += new System.EventHandler(this.cmbboxWarehouse_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select the Product";
            // 
            // cmbboxProduct
            // 
            this.cmbboxProduct.FormattingEnabled = true;
            this.cmbboxProduct.Location = new System.Drawing.Point(404, 248);
            this.cmbboxProduct.Name = "cmbboxProduct";
            this.cmbboxProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbboxProduct.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter the Quantity";
            // 
            // mtxtbxQuantity
            // 
            this.mtxtbxQuantity.Location = new System.Drawing.Point(404, 324);
            this.mtxtbxQuantity.Mask = "00000";
            this.mtxtbxQuantity.Name = "mtxtbxQuantity";
            this.mtxtbxQuantity.Size = new System.Drawing.Size(121, 20);
            this.mtxtbxQuantity.TabIndex = 15;
            this.mtxtbxQuantity.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(211, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "(max. 5 digits)";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(515, 366);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnBackNavForm
            // 
            this.btnBackNavForm.Location = new System.Drawing.Point(615, 359);
            this.btnBackNavForm.Name = "btnBackNavForm";
            this.btnBackNavForm.Size = new System.Drawing.Size(97, 37);
            this.btnBackNavForm.TabIndex = 18;
            this.btnBackNavForm.Text = "Back to Navigation Form";
            this.btnBackNavForm.UseVisualStyleBackColor = true;
            this.btnBackNavForm.Click += new System.EventHandler(this.btnBackNavForm_Click);
            // 
            // OrderProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackNavForm);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtbxQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbboxProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbboxWarehouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbboxManufacturerCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "OrderProductForm";
            this.Text = "OrderProductForm";
            this.Load += new System.EventHandler(this.OrderProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbboxManufacturerCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbboxWarehouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbboxProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtbxQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBackNavForm;
    }
}