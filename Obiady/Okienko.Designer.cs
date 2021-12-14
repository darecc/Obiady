namespace Obiady
{
    partial class Okienko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okienko));
            this.Linia2 = new System.Windows.Forms.TextBox();
            this.Linia1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Linia2
            // 
            this.Linia2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Linia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.29412F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Linia2.Location = new System.Drawing.Point(10, 63);
            this.Linia2.Margin = new System.Windows.Forms.Padding(5);
            this.Linia2.Name = "Linia2";
            this.Linia2.Size = new System.Drawing.Size(500, 18);
            this.Linia2.TabIndex = 4;
            // 
            // Linia1
            // 
            this.Linia1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Linia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.29412F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Linia1.Location = new System.Drawing.Point(10, 32);
            this.Linia1.Margin = new System.Windows.Forms.Padding(5);
            this.Linia1.Name = "Linia1";
            this.Linia1.Size = new System.Drawing.Size(500, 18);
            this.Linia1.TabIndex = 3;
            // 
            // Okienko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 103);
            this.ControlBox = false;
            this.Controls.Add(this.Linia2);
            this.Controls.Add(this.Linia1);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Calibri", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Okienko";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Okienko_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Linia2;
        private System.Windows.Forms.TextBox Linia1;
    }
}