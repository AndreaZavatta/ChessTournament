
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
            this.btnCreaTorneo = new System.Windows.Forms.Button();
            this.dgvTornei = new System.Windows.Forms.DataGridView();
            this.Codice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumEdizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.Partecipa = new System.Windows.Forms.DataGridViewImageColumn();
            this.Elimina = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.tabStatistica1 = new System.Windows.Forms.TabPage();
            this.tbStatistica1 = new System.Windows.Forms.TextBox();
            this.dgvStats1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partecipazioni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStatistica2 = new System.Windows.Forms.TabPage();
            this.tbStatistica2 = new System.Windows.Forms.TextBox();
            this.dgvStatistica2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabTornei.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTornei)).BeginInit();
            this.tabStatistica1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats1)).BeginInit();
            this.tabStatistica2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistica2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTornei);
            this.tabControl1.Controls.Add(this.tabStatistica1);
            this.tabControl1.Controls.Add(this.tabStatistica2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 608);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            // btnCreaTorneo
            // 
            this.btnCreaTorneo.Location = new System.Drawing.Point(569, 14);
            this.btnCreaTorneo.Name = "btnCreaTorneo";
            this.btnCreaTorneo.Size = new System.Drawing.Size(101, 29);
            this.btnCreaTorneo.TabIndex = 10;
            this.btnCreaTorneo.Text = "Crea torneo";
            this.btnCreaTorneo.UseVisualStyleBackColor = true;
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
            // tabStatistica1
            // 
            this.tabStatistica1.Controls.Add(this.tbStatistica1);
            this.tabStatistica1.Controls.Add(this.dgvStats1);
            this.tabStatistica1.Location = new System.Drawing.Point(4, 29);
            this.tabStatistica1.Name = "tabStatistica1";
            this.tabStatistica1.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistica1.Size = new System.Drawing.Size(1088, 575);
            this.tabStatistica1.TabIndex = 1;
            this.tabStatistica1.Text = "Statistica 1";
            this.tabStatistica1.UseVisualStyleBackColor = true;
            // 
            // tbStatistica1
            // 
            this.tbStatistica1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatistica1.BackColor = System.Drawing.Color.White;
            this.tbStatistica1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStatistica1.Location = new System.Drawing.Point(6, 3);
            this.tbStatistica1.Multiline = true;
            this.tbStatistica1.Name = "tbStatistica1";
            this.tbStatistica1.ReadOnly = true;
            this.tbStatistica1.Size = new System.Drawing.Size(1076, 93);
            this.tbStatistica1.TabIndex = 1;
            this.tbStatistica1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvStats1
            // 
            this.dgvStats1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Cognome,
            this.Partecipazioni});
            this.dgvStats1.Location = new System.Drawing.Point(6, 102);
            this.dgvStats1.Name = "dgvStats1";
            this.dgvStats1.RowHeadersWidth = 51;
            this.dgvStats1.RowTemplate.Height = 29;
            this.dgvStats1.Size = new System.Drawing.Size(1076, 469);
            this.dgvStats1.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 125;
            // 
            // Cognome
            // 
            this.Cognome.DataPropertyName = "Cognome";
            this.Cognome.HeaderText = "Cognome";
            this.Cognome.MinimumWidth = 6;
            this.Cognome.Name = "Cognome";
            this.Cognome.Width = 125;
            // 
            // Partecipazioni
            // 
            this.Partecipazioni.DataPropertyName = "Partecipazioni";
            this.Partecipazioni.HeaderText = "Partecipazioni";
            this.Partecipazioni.MinimumWidth = 6;
            this.Partecipazioni.Name = "Partecipazioni";
            this.Partecipazioni.Width = 125;
            // 
            // tabStatistica2
            // 
            this.tabStatistica2.Controls.Add(this.tbStatistica2);
            this.tabStatistica2.Controls.Add(this.dgvStatistica2);
            this.tabStatistica2.Location = new System.Drawing.Point(4, 29);
            this.tabStatistica2.Name = "tabStatistica2";
            this.tabStatistica2.Size = new System.Drawing.Size(1088, 575);
            this.tabStatistica2.TabIndex = 2;
            this.tabStatistica2.Text = "Statistica 2";
            this.tabStatistica2.UseVisualStyleBackColor = true;
            // 
            // tbStatistica2
            // 
            this.tbStatistica2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatistica2.BackColor = System.Drawing.Color.White;
            this.tbStatistica2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStatistica2.Location = new System.Drawing.Point(6, 3);
            this.tbStatistica2.Multiline = true;
            this.tbStatistica2.Name = "tbStatistica2";
            this.tbStatistica2.ReadOnly = true;
            this.tbStatistica2.Size = new System.Drawing.Size(1076, 93);
            this.tbStatistica2.TabIndex = 3;
            this.tbStatistica2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvStatistica2
            // 
            this.dgvStatistica2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistica2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvStatistica2.Location = new System.Drawing.Point(6, 102);
            this.dgvStatistica2.Name = "dgvStatistica2";
            this.dgvStatistica2.RowHeadersWidth = 51;
            this.dgvStatistica2.RowTemplate.Height = 29;
            this.dgvStatistica2.Size = new System.Drawing.Size(1076, 469);
            this.dgvStatistica2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Edizione";
            this.dataGridViewTextBoxColumn1.HeaderText = "Edizione";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vincitore";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vincitore";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
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
            this.tabStatistica1.ResumeLayout(false);
            this.tabStatistica1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats1)).EndInit();
            this.tabStatistica2.ResumeLayout(false);
            this.tabStatistica2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistica2)).EndInit();
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
        private System.Windows.Forms.TabPage tabStatistica1;
        private System.Windows.Forms.DataGridView dgvStats1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partecipazioni;
        private System.Windows.Forms.TabPage tabStatistica2;
        private System.Windows.Forms.TextBox tbStatistica1;
        private System.Windows.Forms.TextBox tbStatistica2;
        private System.Windows.Forms.DataGridView dgvStatistica2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}