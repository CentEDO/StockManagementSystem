
namespace VPMidterm
{
    partial class CustomerReportsListForm
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
            this.gvReports = new System.Windows.Forms.DataGridView();
            this.btnNavigationForm = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(219, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "REPORT LIST FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gvReports
            // 
            this.gvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReports.Location = new System.Drawing.Point(108, 81);
            this.gvReports.Name = "gvReports";
            this.gvReports.Size = new System.Drawing.Size(584, 307);
            this.gvReports.TabIndex = 11;
            // 
            // btnNavigationForm
            // 
            this.btnNavigationForm.Location = new System.Drawing.Point(683, 394);
            this.btnNavigationForm.Name = "btnNavigationForm";
            this.btnNavigationForm.Size = new System.Drawing.Size(84, 44);
            this.btnNavigationForm.TabIndex = 12;
            this.btnNavigationForm.Text = "Navigation Form";
            this.btnNavigationForm.UseVisualStyleBackColor = true;
            this.btnNavigationForm.Click += new System.EventHandler(this.btnNavigationForm_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(113, 55);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 13;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // CustomerReportsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnNavigationForm);
            this.Controls.Add(this.gvReports);
            this.Controls.Add(this.label2);
            this.Name = "CustomerReportsListForm";
            this.Text = "CustomerReportsListForm";
            this.Load += new System.EventHandler(this.CustomerReportsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvReports;
        private System.Windows.Forms.Button btnNavigationForm;
        private System.Windows.Forms.TextBox txtFilter;
    }
}