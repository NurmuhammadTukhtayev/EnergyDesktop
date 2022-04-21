namespace Energy
{
    partial class TypeOfEnergy
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
            this.btnUnrecovery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(1263, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 0;
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
            this.btnRecovery.Location = new System.Drawing.Point(131, 127);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(306, 152);
            this.btnRecovery.TabIndex = 2;
            this.btnRecovery.Text = "Qayta tiklanuvchi";
            this.btnRecovery.UseVisualStyleBackColor = false;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // btnUnrecovery
            // 
            this.btnUnrecovery.BackColor = System.Drawing.Color.Transparent;
            this.btnUnrecovery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnrecovery.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter);
            this.btnUnrecovery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUnrecovery.Location = new System.Drawing.Point(915, 744);
            this.btnUnrecovery.Name = "btnUnrecovery";
            this.btnUnrecovery.Size = new System.Drawing.Size(354, 152);
            this.btnUnrecovery.TabIndex = 3;
            this.btnUnrecovery.Text = "Qayta tiklanmaydigan";
            this.btnUnrecovery.UseVisualStyleBackColor = false;
            this.btnUnrecovery.Click += new System.EventHandler(this.btnUnrecovery_Click);
            // 
            // TypeOfEnergy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Energy.Properties.Resources.ennandgee_0006_Layer_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 993);
            this.Controls.Add(this.btnUnrecovery);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TypeOfEnergy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeOfEnergy";
            this.Load += new System.EventHandler(this.TypeOfEnergy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.Button btnUnrecovery;
    }
}