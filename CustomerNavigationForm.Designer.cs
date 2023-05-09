namespace VPMidterm
{
    partial class CustomerNavigationForm
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
            this.btnManufacturerList = new System.Windows.Forms.Button();
            this.btnGoOrderList = new System.Windows.Forms.Button();
            this.btnGoOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManufacturerList
            // 
            this.btnManufacturerList.Location = new System.Drawing.Point(54, 121);
            this.btnManufacturerList.Margin = new System.Windows.Forms.Padding(2);
            this.btnManufacturerList.Name = "btnManufacturerList";
            this.btnManufacturerList.Size = new System.Drawing.Size(142, 53);
            this.btnManufacturerList.TabIndex = 0;
            this.btnManufacturerList.Text = "&Manufacturer Factories List";
            this.btnManufacturerList.UseVisualStyleBackColor = true;
            this.btnManufacturerList.Click += new System.EventHandler(this.btnManufacturerList_Click);
            // 
            // btnGoOrderList
            // 
            this.btnGoOrderList.Location = new System.Drawing.Point(54, 228);
            this.btnGoOrderList.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoOrderList.Name = "btnGoOrderList";
            this.btnGoOrderList.Size = new System.Drawing.Size(142, 37);
            this.btnGoOrderList.TabIndex = 1;
            this.btnGoOrderList.Text = "&See Order List";
            this.btnGoOrderList.UseVisualStyleBackColor = true;
            this.btnGoOrderList.Click += new System.EventHandler(this.btnGoOrderList_Click);
            // 
            // btnGoOrder
            // 
            this.btnGoOrder.Location = new System.Drawing.Point(54, 320);
            this.btnGoOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoOrder.Name = "btnGoOrder";
            this.btnGoOrder.Size = new System.Drawing.Size(142, 36);
            this.btnGoOrder.TabIndex = 8;
            this.btnGoOrder.Text = "&Order ";
            this.btnGoOrder.UseVisualStyleBackColor = true;
            this.btnGoOrder.Click += new System.EventHandler(this.btnGoOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "NAVIGATION FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "If you want to see all manufacturer factories :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "If you want to see all Orders:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "If you want to Order";
            // 
            // CustomerNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(802, 451);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoOrder);
            this.Controls.Add(this.btnGoOrderList);
            this.Controls.Add(this.btnManufacturerList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerNavigationForm";
            this.Text = "LandingPageCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManufacturerList;
        private System.Windows.Forms.Button btnGoOrderList;
        private System.Windows.Forms.Button btnGoOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}