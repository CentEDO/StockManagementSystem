﻿
namespace VPMidterm
{
    partial class FactoryLogin
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msktxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtnCustomer = new System.Windows.Forms.RadioButton();
            this.rdbtnManufacturer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(350, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(152, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password";
            // 
            // msktxtEmail
            // 
            this.msktxtEmail.Location = new System.Drawing.Point(350, 158);
            this.msktxtEmail.Mask = "AAA@AAA.AAA";
            this.msktxtEmail.Name = "msktxtEmail";
            this.msktxtEmail.Size = new System.Drawing.Size(223, 20);
            this.msktxtEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(152, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(498, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(184, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "FACTORY LOGIN FORM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdbtnCustomer
            // 
            this.rdbtnCustomer.AutoSize = true;
            this.rdbtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnCustomer.ForeColor = System.Drawing.Color.White;
            this.rdbtnCustomer.Location = new System.Drawing.Point(489, 271);
            this.rdbtnCustomer.Name = "rdbtnCustomer";
            this.rdbtnCustomer.Size = new System.Drawing.Size(83, 20);
            this.rdbtnCustomer.TabIndex = 4;
            this.rdbtnCustomer.TabStop = true;
            this.rdbtnCustomer.Text = "Customer";
            this.rdbtnCustomer.UseVisualStyleBackColor = true;
            // 
            // rdbtnManufacturer
            // 
            this.rdbtnManufacturer.AutoSize = true;
            this.rdbtnManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnManufacturer.ForeColor = System.Drawing.Color.White;
            this.rdbtnManufacturer.Location = new System.Drawing.Point(349, 271);
            this.rdbtnManufacturer.Name = "rdbtnManufacturer";
            this.rdbtnManufacturer.Size = new System.Drawing.Size(103, 20);
            this.rdbtnManufacturer.TabIndex = 3;
            this.rdbtnManufacturer.TabStop = true;
            this.rdbtnManufacturer.Text = "Manufacturer";
            this.rdbtnManufacturer.UseVisualStyleBackColor = true;
            // 
            // FactoryLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbtnCustomer);
            this.Controls.Add(this.rdbtnManufacturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msktxtEmail);
            this.Controls.Add(this.label5);
            this.Name = "FactoryLogin";
            this.Text = "FactoryLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktxtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbtnCustomer;
        private System.Windows.Forms.RadioButton rdbtnManufacturer;
    }
}