
namespace VPMidterm
{
    partial class CargoDetailsCustomerForm
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
            this.lvCargoDetails = new System.Windows.Forms.ListView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNavigationPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(204, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "CARGO DETAILS FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lvCargoDetails
            // 
            this.lvCargoDetails.HideSelection = false;
            this.lvCargoDetails.Location = new System.Drawing.Point(91, 97);
            this.lvCargoDetails.Name = "lvCargoDetails";
            this.lvCargoDetails.Size = new System.Drawing.Size(599, 277);
            this.lvCargoDetails.TabIndex = 11;
            this.lvCargoDetails.UseCompatibleStateImageBehavior = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(588, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNavigationPage
            // 
            this.btnNavigationPage.Location = new System.Drawing.Point(695, 386);
            this.btnNavigationPage.Name = "btnNavigationPage";
            this.btnNavigationPage.Size = new System.Drawing.Size(75, 37);
            this.btnNavigationPage.TabIndex = 13;
            this.btnNavigationPage.Text = "Navigation Page";
            this.btnNavigationPage.UseVisualStyleBackColor = true;
            this.btnNavigationPage.Click += new System.EventHandler(this.btnNavigationPage_Click);
            // 
            // CargoDetailsCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNavigationPage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lvCargoDetails);
            this.Controls.Add(this.label2);
            this.Name = "CargoDetailsCustomerForm";
            this.Text = "CargoDetailsCustomerForm";
            this.Load += new System.EventHandler(this.CargoDetailsCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvCargoDetails;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNavigationPage;
    }
}