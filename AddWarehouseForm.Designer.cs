﻿
namespace VPMidterm
{
    partial class AddWarehouseForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.txtWarehouseAddress = new System.Windows.Forms.TextBox();
            this.cmbboxFactoryName = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBackNavigationForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(171, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADDING WAREHOUSE FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Factory Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Warehouse Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(116, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Warehouse Address";
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(392, 204);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(145, 20);
            this.txtWarehouseName.TabIndex = 7;
            // 
            // txtWarehouseAddress
            // 
            this.txtWarehouseAddress.Location = new System.Drawing.Point(392, 270);
            this.txtWarehouseAddress.Name = "txtWarehouseAddress";
            this.txtWarehouseAddress.Size = new System.Drawing.Size(145, 20);
            this.txtWarehouseAddress.TabIndex = 8;
            // 
            // cmbboxFactoryName
            // 
            this.cmbboxFactoryName.FormattingEnabled = true;
            this.cmbboxFactoryName.Location = new System.Drawing.Point(392, 139);
            this.cmbboxFactoryName.Name = "cmbboxFactoryName";
            this.cmbboxFactoryName.Size = new System.Drawing.Size(145, 21);
            this.cmbboxFactoryName.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(461, 332);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBackNavigationForm
            // 
            this.btnBackNavigationForm.Location = new System.Drawing.Point(602, 323);
            this.btnBackNavigationForm.Name = "btnBackNavigationForm";
            this.btnBackNavigationForm.Size = new System.Drawing.Size(102, 41);
            this.btnBackNavigationForm.TabIndex = 11;
            this.btnBackNavigationForm.Text = "Back to Navigation Form";
            this.btnBackNavigationForm.UseVisualStyleBackColor = true;
            // 
            // AddWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackNavigationForm);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbboxFactoryName);
            this.Controls.Add(this.txtWarehouseAddress);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddWarehouseForm";
            this.Text = "AddWarehouseForm";
            this.Load += new System.EventHandler(this.AddWarehouseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.TextBox txtWarehouseAddress;
        private System.Windows.Forms.ComboBox cmbboxFactoryName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBackNavigationForm;
    }
}