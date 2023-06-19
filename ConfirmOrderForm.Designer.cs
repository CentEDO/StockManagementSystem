
namespace VPMidterm
{
    partial class ConfirmOrderForm
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
            this.lvConfirmList = new System.Windows.Forms.ListView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(197, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "CONFIRM ORDER FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lvConfirmList
            // 
            this.lvConfirmList.HideSelection = false;
            this.lvConfirmList.Location = new System.Drawing.Point(86, 50);
            this.lvConfirmList.Name = "lvConfirmList";
            this.lvConfirmList.Size = new System.Drawing.Size(627, 318);
            this.lvConfirmList.TabIndex = 10;
            this.lvConfirmList.UseCompatibleStateImageBehavior = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(646, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ConfirmOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lvConfirmList);
            this.Controls.Add(this.label2);
            this.Name = "ConfirmOrderForm";
            this.Text = "ConfirmOrderForm";
            this.Load += new System.EventHandler(this.ConfirmOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvConfirmList;
        private System.Windows.Forms.Button btnUpdate;
    }
}