namespace Energy
{
    partial class Unrecovery
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRecovery = new System.Windows.Forms.Button();
            this.btnCoal = new System.Windows.Forms.Button();
            this.btnGas = new System.Windows.Forms.Button();
            this.btnAES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(1263, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Orqaga";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.BackColor = System.Drawing.Color.Transparent;
            this.btnRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecovery.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter);
            this.btnRecovery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRecovery.Location = new System.Drawing.Point(55, 138);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(246, 70);
            this.btnRecovery.TabIndex = 4;
            this.btnRecovery.Text = "Neft";
            this.btnRecovery.UseVisualStyleBackColor = false;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // btnCoal
            // 
            this.btnCoal.BackColor = System.Drawing.Color.Transparent;
            this.btnCoal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCoal.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter);
            this.btnCoal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCoal.Location = new System.Drawing.Point(393, 138);
            this.btnCoal.Name = "btnCoal";
            this.btnCoal.Size = new System.Drawing.Size(246, 70);
            this.btnCoal.TabIndex = 5;
            this.btnCoal.Text = "Ko\'mir";
            this.btnCoal.UseVisualStyleBackColor = false;
            this.btnCoal.Click += new System.EventHandler(this.btnCoal_Click);
            // 
            // btnGas
            // 
            this.btnGas.BackColor = System.Drawing.Color.Transparent;
            this.btnGas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGas.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter);
            this.btnGas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGas.Location = new System.Drawing.Point(750, 138);
            this.btnGas.Name = "btnGas";
            this.btnGas.Size = new System.Drawing.Size(246, 70);
            this.btnGas.TabIndex = 6;
            this.btnGas.Text = "Gaz";
            this.btnGas.UseVisualStyleBackColor = false;
            this.btnGas.Click += new System.EventHandler(this.btnGas_Click);
            // 
            // btnAES
            // 
            this.btnAES.BackColor = System.Drawing.Color.Transparent;
            this.btnAES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAES.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter);
            this.btnAES.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAES.Location = new System.Drawing.Point(1080, 138);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(246, 70);
            this.btnAES.TabIndex = 7;
            this.btnAES.Text = "AES";
            this.btnAES.UseVisualStyleBackColor = false;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // Unrecovery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Energy.Properties.Resources._2aoyjcblcnyk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 993);
            this.Controls.Add(this.btnAES);
            this.Controls.Add(this.btnGas);
            this.Controls.Add(this.btnCoal);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Unrecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unrecovery";
            this.Load += new System.EventHandler(this.Unrecovery_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.Button btnCoal;
        private System.Windows.Forms.Button btnGas;
        private System.Windows.Forms.Button btnAES;
    }
}