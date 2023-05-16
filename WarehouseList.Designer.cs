
namespace VPMidterm
{
    partial class WarehouseList
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
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.btnBackNavForm = new System.Windows.Forms.Button();
            this.gvWarehouses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvWarehouses)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(276, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "WAREHOUSES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(93, 65);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(160, 20);
            this.txtWarehouseName.TabIndex = 14;
            // 
            // btnBackNavForm
            // 
            this.btnBackNavForm.Location = new System.Drawing.Point(617, 391);
            this.btnBackNavForm.Name = "btnBackNavForm";
            this.btnBackNavForm.Size = new System.Drawing.Size(115, 42);
            this.btnBackNavForm.TabIndex = 13;
            this.btnBackNavForm.Text = "Back to Navigation Form";
            this.btnBackNavForm.UseVisualStyleBackColor = true;
            this.btnBackNavForm.Click += new System.EventHandler(this.btnBackNavForm_Click);
            // 
            // gvWarehouses
            // 
            this.gvWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWarehouses.Location = new System.Drawing.Point(55, 91);
            this.gvWarehouses.Name = "gvWarehouses";
            this.gvWarehouses.Size = new System.Drawing.Size(677, 294);
            this.gvWarehouses.TabIndex = 12;
            // 
            // WarehouseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.btnBackNavForm);
            this.Controls.Add(this.gvWarehouses);
            this.Controls.Add(this.label2);
            this.Name = "WarehouseList";
            this.Text = "WarehouseList";
            this.Load += new System.EventHandler(this.WarehouseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvWarehouses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Button btnBackNavForm;
        private System.Windows.Forms.DataGridView gvWarehouses;
    }
}