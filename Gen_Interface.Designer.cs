﻿namespace BasicIdler
{
    partial class Gen_Interface
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.lblmultiplier = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.grpDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDescription
            // 
            this.grpDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDescription.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDescription.Controls.Add(this.lblSpeed);
            this.grpDescription.Controls.Add(this.lblCost);
            this.grpDescription.Controls.Add(this.lblAmount);
            this.grpDescription.Controls.Add(this.button2);
            this.grpDescription.Controls.Add(this.btnUpgrade);
            this.grpDescription.Controls.Add(this.lblmultiplier);
            this.grpDescription.Location = new System.Drawing.Point(4, 4);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(380, 111);
            this.grpDescription.TabIndex = 0;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "nothing";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(153, 22);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 17);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(6, 82);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(290, 23);
            this.btnUpgrade.TabIndex = 1;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // lblmultiplier
            // 
            this.lblmultiplier.AutoSize = true;
            this.lblmultiplier.Location = new System.Drawing.Point(7, 22);
            this.lblmultiplier.Name = "lblmultiplier";
            this.lblmultiplier.Size = new System.Drawing.Size(68, 17);
            this.lblmultiplier.TabIndex = 0;
            this.lblmultiplier.Text = "Multiplier:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(7, 39);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 17);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(153, 39);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(53, 17);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "Speed:";
            // 
            // Gen_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.grpDescription);
            this.Name = "Gen_Interface";
            this.Size = new System.Drawing.Size(387, 118);
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Label lblmultiplier;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblCost;
    }
}
