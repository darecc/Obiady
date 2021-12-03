
namespace Obiady
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaDan = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaDodatkow = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDodatekStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaDaniaStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaDan
            // 
            this.listaDan.BackColor = System.Drawing.Color.GhostWhite;
            this.listaDan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3});
            this.listaDan.HideSelection = false;
            this.listaDan.Location = new System.Drawing.Point(12, 48);
            this.listaDan.Name = "listaDan";
            this.listaDan.Size = new System.Drawing.Size(987, 365);
            this.listaDan.TabIndex = 0;
            this.listaDan.UseCompatibleStateImageBehavior = false;
            this.listaDan.View = System.Windows.Forms.View.Details;
            this.listaDan.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnClickColumn);
            this.listaDan.DoubleClick += new System.EventHandler(this.ZwiekszIleRazy);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 710;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kategoria";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ile razy";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Priorytet";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obiad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dodatki";
            // 
            // listaDodatkow
            // 
            this.listaDodatkow.BackColor = System.Drawing.Color.FloralWhite;
            this.listaDodatkow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listaDodatkow.HideSelection = false;
            this.listaDodatkow.Location = new System.Drawing.Point(12, 436);
            this.listaDodatkow.Name = "listaDodatkow";
            this.listaDodatkow.Size = new System.Drawing.Size(987, 219);
            this.listaDodatkow.TabIndex = 3;
            this.listaDodatkow.UseCompatibleStateImageBehavior = false;
            this.listaDodatkow.View = System.Windows.Forms.View.Details;
            this.listaDodatkow.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnClickColumn2);
            this.listaDodatkow.DoubleClick += new System.EventHandler(this.ZwiekszIleRazy2);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nazwa";
            this.columnHeader4.Width = 800;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ile razy";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Priorytet";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.dodajDodatekStripMenuItem1,
            this.edycjaDaniaStripMenuItem1,
            this.koniecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.Zapisz);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.dodajToolStripMenuItem.Text = "Dodaj danie";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.DodajDanie);
            // 
            // dodajDodatekStripMenuItem1
            // 
            this.dodajDodatekStripMenuItem1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dodajDodatekStripMenuItem1.Name = "dodajDodatekStripMenuItem1";
            this.dodajDodatekStripMenuItem1.Size = new System.Drawing.Size(107, 21);
            this.dodajDodatekStripMenuItem1.Text = "Dodaj dodatek";
            this.dodajDodatekStripMenuItem1.Click += new System.EventHandler(this.DodajDodatek);
            // 
            // edycjaDaniaStripMenuItem1
            // 
            this.edycjaDaniaStripMenuItem1.Name = "edycjaDaniaStripMenuItem1";
            this.edycjaDaniaStripMenuItem1.Size = new System.Drawing.Size(91, 21);
            this.edycjaDaniaStripMenuItem1.Text = "Edytuj danie";
            this.edycjaDaniaStripMenuItem1.Click += new System.EventHandler(this.EdycjaDania);
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.Koniec);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 659);
            this.Controls.Add(this.listaDodatkow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaDan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Zdrowe obiady";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaDan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listaDodatkow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem dodajDodatekStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem edycjaDaniaStripMenuItem1;
    }
}

