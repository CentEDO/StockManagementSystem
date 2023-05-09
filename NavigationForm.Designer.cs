
namespace VPMidterm
{
    partial class NavigationForm
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
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManufacturerFactory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCustomerFactories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarehouse.ForeColor = System.Drawing.Color.White;
            this.lblWarehouse.Location = new System.Drawing.Point(30, 81);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(300, 24);
            this.lblWarehouse.TabIndex = 0;
            this.lblWarehouse.Text = "If you want to see all warehouses : ";
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Location = new System.Drawing.Point(34, 108);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(102, 35);
            this.btnWarehouse.TabIndex = 1;
            this.btnWarehouse.Text = "&Warehouses";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(30, 155);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(270, 24);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "If you want to see all products : ";
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(34, 182);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(102, 36);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "&Products";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "If you want to see all manufacturer factories :";
            // 
            // btnManufacturerFactory
            // 
            this.btnManufacturerFactory.Location = new System.Drawing.Point(34, 258);
            this.btnManufacturerFactory.Name = "btnManufacturerFactory";
            this.btnManufacturerFactory.Size = new System.Drawing.Size(102, 34);
            this.btnManufacturerFactory.TabIndex = 5;
            this.btnManufacturerFactory.Text = "&Manufacturer Factories";
            this.btnManufacturerFactory.UseVisualStyleBackColor = true;
            this.btnManufacturerFactory.Click += new System.EventHandler(this.btnManufacturerFactory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(226, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "NAVIGATION FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "If you want to order product : ";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(34, 336);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(102, 39);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "&Order Product";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(404, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "If you want to see all Customer Factories :";
            // 
            // btnCustomerFactories
            // 
            this.btnCustomerFactories.Location = new System.Drawing.Point(408, 108);
            this.btnCustomerFactories.Name = "btnCustomerFactories";
            this.btnCustomerFactories.Size = new System.Drawing.Size(97, 38);
            this.btnCustomerFactories.TabIndex = 10;
            this.btnCustomerFactories.Text = "&Customer Factories";
            this.btnCustomerFactories.UseVisualStyleBackColor = true;
            this.btnCustomerFactories.Click += new System.EventHandler(this.btnCustomerFactories_Click);
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomerFactories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnManufacturerFactory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.lblWarehouse);
            this.Name = "NavigationForm";
            this.Text = "NavigationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManufacturerFactory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCustomerFactories;
    }
}