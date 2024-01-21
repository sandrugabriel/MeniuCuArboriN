using MeniuCuArboriN.ArboriN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MeniuCuArboriN.View.Panels
{
    public class PnlCard : Panel
    {

        public System.Windows.Forms.Label lblText;
        public System.Windows.Forms.Button btn;
        string text;
        public PnlCard(string text1)
        {
            text = text1;
            //PnlCard
            this.ClientSize = new System.Drawing.Size(215, 61);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlCard";

            this.lblText = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();

            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblText);
 
            // lblText
            this.lblText.AutoEllipsis = true;
            this.lblText.Location = new System.Drawing.Point(10, 12);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(150, 37);
            this.lblText.Text = text;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // btn
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Image = global::MeniuCuArboriN.Properties.Resources.chevron;
            this.btn.Location = new System.Drawing.Point(169, 12);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(32, 32);
            this.btn.TabIndex = 1;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
           
        }

        private void btn_Click(object sender, System.EventArgs e)
        {

            

        }

    }
}
