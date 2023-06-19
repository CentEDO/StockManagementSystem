
namespace VPMidterm
{
    partial class CargoDeliveryForm
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
            this.lvCargoDelivery = new System.Windows.Forms.ListView();
            this.btnNavigationPage = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(194, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "CARGO DELIVERY FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lvCargoDelivery
            // 
            this.lvCargoDelivery.HideSelection = false;
            this.lvCargoDelivery.Location = new System.Drawing.Point(67, 104);
            this.lvCargoDelivery.Name = "lvCargoDelivery";
            this.lvCargoDelivery.Size = new System.Drawing.Size(655, 283);
            this.lvCargoDelivery.TabIndex = 12;
            this.lvCargoDelivery.UseCompatibleStateImageBehavior = false;
            // 
            // btnNavigationPage
            // 
            this.btnNavigationPage.Location = new System.Drawing.Point(625, 393);
            this.btnNavigationPage.Name = "btnNavigationPage";
            this.btnNavigationPage.Size = new System.Drawing.Size(75, 45);
            this.btnNavigationPage.TabIndex = 13;
            this.btnNavigationPage.Text = "Navigation Page";
            this.btnNavigationPage.UseVisualStyleBackColor = true;
            this.btnNavigationPage.Click += new System.EventHandler(this.btnNavigationPage_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(106, 70);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 14;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // CargoDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnNavigationPage);
            this.Controls.Add(this.lvCargoDelivery);
            this.Controls.Add(this.label2);
            this.Name = "CargoDeliveryForm";
            this.Text = "CargoDeliveryForm";
            this.Load += new System.EventHandler(this.CargoDeliveryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvCargoDelivery;
        private System.Windows.Forms.Button btnNavigationPage;
        private System.Windows.Forms.TextBox txtFilter;
    }
}