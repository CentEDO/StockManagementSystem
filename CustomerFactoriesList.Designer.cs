
namespace VPMidterm
{
    partial class CustomerFactoriesList
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
            this.gvCustomerFactories = new System.Windows.Forms.DataGridView();
            this.btnBackNavForm = new System.Windows.Forms.Button();
            this.txtCustomerFactoryName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerFactories)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(154, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "CUSTOMER FACTORIES FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gvCustomerFactories
            // 
            this.gvCustomerFactories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomerFactories.Location = new System.Drawing.Point(48, 79);
            this.gvCustomerFactories.Name = "gvCustomerFactories";
            this.gvCustomerFactories.Size = new System.Drawing.Size(677, 294);
            this.gvCustomerFactories.TabIndex = 9;
            // 
            // btnBackNavForm
            // 
            this.btnBackNavForm.Location = new System.Drawing.Point(610, 379);
            this.btnBackNavForm.Name = "btnBackNavForm";
            this.btnBackNavForm.Size = new System.Drawing.Size(115, 42);
            this.btnBackNavForm.TabIndex = 10;
            this.btnBackNavForm.Text = "Back to Navigation Form";
            this.btnBackNavForm.UseVisualStyleBackColor = true;
            this.btnBackNavForm.Click += new System.EventHandler(this.btnBackNavForm_Click);
            // 
            // txtCustomerFactoryName
            // 
            this.txtCustomerFactoryName.Location = new System.Drawing.Point(86, 53);
            this.txtCustomerFactoryName.Name = "txtCustomerFactoryName";
            this.txtCustomerFactoryName.Size = new System.Drawing.Size(160, 20);
            this.txtCustomerFactoryName.TabIndex = 11;
            // 
            // CustomerFactoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCustomerFactoryName);
            this.Controls.Add(this.btnBackNavForm);
            this.Controls.Add(this.gvCustomerFactories);
            this.Controls.Add(this.label2);
            this.Name = "CustomerFactoriesList";
            this.Text = "CustomerFactoriesList";
            this.Load += new System.EventHandler(this.CustomerFactoriesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerFactories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvCustomerFactories;
        private System.Windows.Forms.Button btnBackNavForm;
        private System.Windows.Forms.TextBox txtCustomerFactoryName;
    }
}