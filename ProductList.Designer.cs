namespace VPMidterm
{
    partial class ProductList
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
            this.txtCustomerFactoryName = new System.Windows.Forms.TextBox();
            this.btnBackNavForm = new System.Windows.Forms.Button();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerFactoryName
            // 
            this.txtCustomerFactoryName.Location = new System.Drawing.Point(94, 85);
            this.txtCustomerFactoryName.Name = "txtCustomerFactoryName";
            this.txtCustomerFactoryName.Size = new System.Drawing.Size(160, 20);
            this.txtCustomerFactoryName.TabIndex = 15;
            // 
            // btnBackNavForm
            // 
            this.btnBackNavForm.ForeColor = System.Drawing.Color.Black;
            this.btnBackNavForm.Location = new System.Drawing.Point(618, 411);
            this.btnBackNavForm.Name = "btnBackNavForm";
            this.btnBackNavForm.Size = new System.Drawing.Size(115, 42);
            this.btnBackNavForm.TabIndex = 14;
            this.btnBackNavForm.Text = "Back to Navigation Form";
            this.btnBackNavForm.UseVisualStyleBackColor = true;
            this.btnBackNavForm.Click += new System.EventHandler(this.btnBackNavForm_Click);
            // 
            // gvProducts
            // 
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Location = new System.Drawing.Point(56, 111);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.Size = new System.Drawing.Size(677, 294);
            this.gvProducts.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(238, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "PRODUCTS FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(789, 494);
            this.Controls.Add(this.txtCustomerFactoryName);
            this.Controls.Add(this.btnBackNavForm);
            this.Controls.Add(this.gvProducts);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductList";
            this.Text = "ProductList";
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerFactoryName;
        private System.Windows.Forms.Button btnBackNavForm;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.Label label2;
    }

        #endregion
    }
}