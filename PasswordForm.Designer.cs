﻿namespace WindowsFormsApplication1
{
    partial class PasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter the password to continue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(43, 92);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(576, 40);
            this.tbPassword.TabIndex = 3;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Calibri Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(204, 167);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(230, 54);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // PasswordForm
            // 
            this.AcceptButton = this.btnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(162)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(664, 243);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label1);
            this.Name = "PasswordForm";
            this.Text = "Enter Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnContinue;
    }
}