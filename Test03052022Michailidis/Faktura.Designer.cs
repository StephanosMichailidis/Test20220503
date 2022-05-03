namespace Test03052022Michailidis
{
    partial class Faktura
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cislo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odberatel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pocet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CenaZa1Polozku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CelkovaCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dph = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CenaSdph = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Datum,
            this.Cislo,
            this.Odberatel,
            this.Nazev,
            this.Pocet,
            this.CenaZa1Polozku,
            this.CelkovaCena,
            this.Dph,
            this.CenaSdph});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(789, 422);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            // 
            // Cislo
            // 
            this.Cislo.Text = "Cislo";
            // 
            // Odberatel
            // 
            this.Odberatel.Text = "Odberatel";
            // 
            // Nazev
            // 
            this.Nazev.Text = "Nazev";
            // 
            // Pocet
            // 
            this.Pocet.Text = "Pocet";
            // 
            // CenaZa1Polozku
            // 
            this.CenaZa1Polozku.Text = "CenaZa1Polozku";
            // 
            // CelkovaCena
            // 
            this.CelkovaCena.Text = "CelkovaCena";
            // 
            // Dph
            // 
            this.Dph.Text = "Dph";
            // 
            // CenaSdph
            // 
            this.CenaSdph.Text = "CenaSdph";
            this.CenaSdph.Width = 99;
            // 
            // Faktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "Faktura";
            this.Text = "Faktura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Cislo;
        private System.Windows.Forms.ColumnHeader Odberatel;
        private System.Windows.Forms.ColumnHeader Nazev;
        private System.Windows.Forms.ColumnHeader Pocet;
        private System.Windows.Forms.ColumnHeader CenaZa1Polozku;
        private System.Windows.Forms.ColumnHeader CelkovaCena;
        private System.Windows.Forms.ColumnHeader Dph;
        private System.Windows.Forms.ColumnHeader CenaSdph;
    }
}

