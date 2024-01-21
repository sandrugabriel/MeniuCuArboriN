namespace MeniuCuArboriN.View.Mockups
{
    partial class MockupPnlCard
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
            this.lblText = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoEllipsis = true;
            this.lblText.Location = new System.Drawing.Point(10, 12);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(150, 37);
            this.lblText.TabIndex = 0;
            this.lblText.Tag = "sdas";
            this.lblText.Text = "label1dasdasdadasd";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn
            // 
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Image = global::MeniuCuArboriN.Properties.Resources.chevron;
            this.btn.Location = new System.Drawing.Point(169, 12);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(32, 32);
            this.btn.TabIndex = 1;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // MockupPnlCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(215, 61);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MockupPnlCard";
            this.Text = "MockupPnlCard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btn;
    }
}