
namespace VPMidterm
{
    partial class ManufacturerFactoriesList
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
            this.btnBackNavForm = new System.Windows.Forms.Button();
            this.gvManufacturerFactories = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvManufacturerFactories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackNavForm
            // 
            this.btnBackNavForm.Location = new System.Drawing.Point(624, 383);
            this.btnBackNavForm.Name = "btnBackNavForm";
            this.btnBackNavForm.Size = new System.Drawing.Size(115, 42);
            this.btnBackNavForm.TabIndex = 13;
            this.btnBackNavForm.Text = "Back to Navigation Form";
            this.btnBackNavForm.UseVisualStyleBackColor = true;
            this.btnBackNavForm.Click += new System.EventHandler(this.btnBackNavForm_Click);
            // 
            // gvManufacturerFactories
            // 
            this.gvManufacturerFactories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvManufacturerFactories.Location = new System.Drawing.Point(62, 83);
            this.gvManufacturerFactories.Name = "gvManufacturerFactories";
            this.gvManufacturerFactories.Size = new System.Drawing.Size(677, 294);
            this.gvManufacturerFactories.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(95, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(591, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "MANUFACTURER FACTORIES FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManufacturerFactoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackNavForm);
            this.Controls.Add(this.gvManufacturerFactories);
            this.Controls.Add(this.label2);
            this.Name = "ManufacturerFactoriesList";
            this.Text = "ManufacturerFactoriesList";
            this.Load += new System.EventHandler(this.ManufacturerFactoriesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvManufacturerFactories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackNavForm;
        private System.Windows.Forms.DataGridView gvManufacturerFactories;
        private System.Windows.Forms.Label label2;
    }
}