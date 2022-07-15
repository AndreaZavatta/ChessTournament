
namespace WindowsFormApp
{
    partial class FormHomePage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTornei = new System.Windows.Forms.TabPage();
            this.tabStatistiche = new System.Windows.Forms.TabPage();
            this.btnCreaTorneo = new System.Windows.Forms.Button();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.dgvTornei = new System.Windows.Forms.DataGridView();
            this.Codice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumEdizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.Partecipa = new System.Windows.Forms.DataGridViewImageColumn();
            this.Elimina = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabTornei.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTornei)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTornei);
            this.tabControl1.Controls.Add(this.tabStatistiche);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 608);
            this.tabControl1.TabIndex = 7;
            // 
            // tabTornei
            // 
            this.tabTornei.Controls.Add(this.btnCreaTorneo);
            this.tabTornei.Controls.Add(this.dgvTornei);
            this.tabTornei.Controls.Add(this.lblTorneo);
            this.tabTornei.Controls.Add(this.cbTorneo);
            this.tabTornei.Location = new System.Drawing.Point(4, 29);
            this.tabTornei.Name = "tabTornei";
            this.tabTornei.Padding = new System.Windows.Forms.Padding(3);
            this.tabTornei.Size = new System.Drawing.Size(1088, 575);
            this.tabTornei.TabIndex = 0;
            this.tabTornei.Text = "Tornei";
            this.tabTornei.UseVisualStyleBackColor = true;
            // 
            // tabStatistiche
            // 
            this.tabStatistiche.Location = new System.Drawing.Point(4, 29);
            this.tabStatistiche.Name = "tabStatistiche";
            this.tabStatistiche.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistiche.Size = new System.Drawing.Size(1088, 575);
            this.tabStatistiche.TabIndex = 1;
            this.tabStatistiche.Text = "Statistiche";
            this.tabStatistiche.UseVisualStyleBackColor = true;
            // 
            // btnCreaTorneo
            // 
            this.btnCreaTorneo.Location = new System.Drawing.Point(569, 14);
            this.btnCreaTorneo.Name = "btnCreaTorneo";
            this.btnCreaTorneo.Size = new System.Drawing.Size(101, 29);
            this.btnCreaTorneo.TabIndex = 10;
            this.btnCreaTorneo.Text = "Crea torneo";
            this.btnCreaTorneo.UseVisualStyleBackColor = true;
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Location = new System.Drawing.Point(18, 18);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(55, 20);
            this.lblTorneo.TabIndex = 9;
            this.lblTorneo.Text = "Torneo";
            // 
            // cbTorneo
            // 
            this.cbTorneo.FormattingEnabled = true;
            this.cbTorneo.Location = new System.Drawing.Point(79, 15);
            this.cbTorneo.Name = "cbTorneo";
            this.cbTorneo.Size = new System.Drawing.Size(298, 28);
            this.cbTorneo.TabIndex = 8;
            // 
            // dgvTornei
            // 
            this.dgvTornei.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTornei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTornei.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codice,
            this.Descrizione,
            this.NumEdizione,
            this.DataInizio,
            this.DataFine,
            this.Details,
            this.Partecipa,
            this.Elimina});
            this.dgvTornei.Location = new System.Drawing.Point(18, 49);
            this.dgvTornei.Name = "dgvTornei";
            this.dgvTornei.RowHeadersWidth = 51;
            this.dgvTornei.RowTemplate.Height = 29;
            this.dgvTornei.Size = new System.Drawing.Size(1064, 520);
            this.dgvTornei.TabIndex = 7;
            // 
            // Codice
            // 
            this.Codice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Codice.DataPropertyName = "Codice";
            this.Codice.HeaderText = "Codice";
            this.Codice.MinimumWidth = 6;
            this.Codice.Name = "Codice";
            this.Codice.ReadOnly = true;
            this.Codice.Width = 84;
            // 
            // Descrizione
            // 
            this.Descrizione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descrizione.DataPropertyName = "Descrizione";
            this.Descrizione.HeaderText = "Descrizione";
            this.Descrizione.MinimumWidth = 6;
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.ReadOnly = true;
            // 
            // NumEdizione
            // 
            this.NumEdizione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NumEdizione.DataPropertyName = "NumEdizione";
            this.NumEdizione.HeaderText = "Numero edizione";
            this.NumEdizione.MinimumWidth = 6;
            this.NumEdizione.Name = "NumEdizione";
            this.NumEdizione.ReadOnly = true;
            this.NumEdizione.Width = 140;
            // 
            // DataInizio
            // 
            this.DataInizio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DataInizio.DataPropertyName = "DataInizio";
            this.DataInizio.HeaderText = "Data inizio";
            this.DataInizio.MinimumWidth = 6;
            this.DataInizio.Name = "DataInizio";
            this.DataInizio.ReadOnly = true;
            this.DataInizio.Width = 101;
            // 
            // DataFine
            // 
            this.DataFine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DataFine.DataPropertyName = "DataFine";
            this.DataFine.HeaderText = "Data fine";
            this.DataFine.MinimumWidth = 6;
            this.DataFine.Name = "DataFine";
            this.DataFine.ReadOnly = true;
            this.DataFine.Width = 92;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Details.DataPropertyName = "Details";
            this.Details.HeaderText = "";
            this.Details.Image = global::WindowsFormApp.Properties.Resources.icons8_info_24;
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 25;
            // 
            // Partecipa
            // 
            this.Partecipa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Partecipa.DataPropertyName = "Partecipa";
            this.Partecipa.HeaderText = "";
            this.Partecipa.Image = global::WindowsFormApp.Properties.Resources.icons8_join_24;
            this.Partecipa.MinimumWidth = 6;
            this.Partecipa.Name = "Partecipa";
            this.Partecipa.ReadOnly = true;
            this.Partecipa.Visible = false;
            this.Partecipa.Width = 25;
            // 
            // Elimina
            // 
            this.Elimina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Elimina.DataPropertyName = "Elimina";
            this.Elimina.HeaderText = "";
            this.Elimina.Image = global::WindowsFormApp.Properties.Resources.icons8_delete_24;
            this.Elimina.MinimumWidth = 6;
            this.Elimina.Name = "Elimina";
            this.Elimina.ReadOnly = true;
            this.Elimina.Visible = false;
            this.Elimina.Width = 25;
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 626);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormHomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTornei.ResumeLayout(false);
            this.tabTornei.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTornei)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTornei;
        private System.Windows.Forms.Button btnCreaTorneo;
        private System.Windows.Forms.DataGridView dgvTornei;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumEdizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFine;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.DataGridViewImageColumn Partecipa;
        private System.Windows.Forms.DataGridViewImageColumn Elimina;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.ComboBox cbTorneo;
        private System.Windows.Forms.TabPage tabStatistiche;
    }
}