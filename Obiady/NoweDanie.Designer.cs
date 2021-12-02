
namespace Obiady
{
    partial class NoweDanie
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nazwa = new System.Windows.Forms.TextBox();
            this.priorytet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.kategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priorytet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(630, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OK);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(561, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Cancel);
            // 
            // nazwa
            // 
            this.nazwa.Location = new System.Drawing.Point(24, 13);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(549, 25);
            this.nazwa.TabIndex = 2;
            // 
            // priorytet
            // 
            this.priorytet.Location = new System.Drawing.Point(644, 12);
            this.priorytet.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.priorytet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priorytet.Name = "priorytet";
            this.priorytet.Size = new System.Drawing.Size(44, 25);
            this.priorytet.TabIndex = 2;
            this.priorytet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "priorytet";
            // 
            // kategoria
            // 
            this.kategoria.FormattingEnabled = true;
            this.kategoria.Items.AddRange(new object[] {
            "drób",
            "dziczyzna",
            "ryba",
            "warzywa",
            "wołowina",
            "zupa"});
            this.kategoria.Location = new System.Drawing.Point(90, 51);
            this.kategoria.Name = "kategoria";
            this.kategoria.Size = new System.Drawing.Size(121, 25);
            this.kategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "kategoria";
            // 
            this.label1.TabIndex = 4;
            this.label1.Text = "priorytet";
            // NoweDanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 110);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priorytet);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NoweDanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowe danie";
            this.Load += new System.EventHandler(this.NoweDanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priorytet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox nazwa;
        public System.Windows.Forms.NumericUpDown priorytet;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox kategoria;
    }
}