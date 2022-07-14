
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
            this.lblTorneo = new System.Windows.Forms.Label();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.dgvTornei = new System.Windows.Forms.DataGridView();
            this.btnCreaTorneo = new System.Windows.Forms.Button();
            this.Codice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumEdizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTornei)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Location = new System.Drawing.Point(13, 15);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(55, 20);
            this.lblTorneo.TabIndex = 5;
            this.lblTorneo.Text = "Torneo";
            // 
            // cbTorneo
            // 
            this.cbTorneo.FormattingEnabled = true;
            this.cbTorneo.Location = new System.Drawing.Point(74, 12);
            this.cbTorneo.Name = "cbTorneo";
            this.cbTorneo.Size = new System.Drawing.Size(298, 28);
            this.cbTorneo.TabIndex = 4;
            this.cbTorneo.SelectedIndexChanged += new System.EventHandler(this.cbTorneo_SelectedIndexChanged);
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
            this.Details});
            this.dgvTornei.Location = new System.Drawing.Point(12, 46);
            this.dgvTornei.Name = "dgvTornei";
            this.dgvTornei.RowHeadersWidth = 51;
            this.dgvTornei.RowTemplate.Height = 29;
            this.dgvTornei.Size = new System.Drawing.Size(776, 392);
            this.dgvTornei.TabIndex = 3;
            this.dgvTornei.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTornei_CellClick);
            // 
            // btnCreaTorneo
            // 
            this.btnCreaTorneo.Location = new System.Drawing.Point(564, 11);
            this.btnCreaTorneo.Name = "btnCreaTorneo";
            this.btnCreaTorneo.Size = new System.Drawing.Size(101, 29);
            this.btnCreaTorneo.TabIndex = 6;
            this.btnCreaTorneo.Text = "Crea torneo";
            this.btnCreaTorneo.UseVisualStyleBackColor = true;
            this.btnCreaTorneo.Click += new System.EventHandler(this.btnCreaTorneo_Click);
            // 
            // Codice
            // 
            this.Codice.DataPropertyName = "Codice";
            this.Codice.HeaderText = "Codice";
            this.Codice.MinimumWidth = 6;
            this.Codice.Name = "Codice";
            this.Codice.ReadOnly = true;
            this.Codice.Width = 125;
            // 
            // Descrizione
            // 
            this.Descrizione.DataPropertyName = "Descrizione";
            this.Descrizione.HeaderText = "Descrizione";
            this.Descrizione.MinimumWidth = 6;
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.ReadOnly = true;
            this.Descrizione.Width = 200;
            // 
            // NumEdizione
            // 
            this.NumEdizione.DataPropertyName = "NumEdizione";
            this.NumEdizione.HeaderText = "Numero edizione";
            this.NumEdizione.MinimumWidth = 6;
            this.NumEdizione.Name = "NumEdizione";
            this.NumEdizione.ReadOnly = true;
            this.NumEdizione.Width = 125;
            // 
            // DataInizio
            // 
            this.DataInizio.DataPropertyName = "DataInizio";
            this.DataInizio.HeaderText = "Data inizio";
            this.DataInizio.MinimumWidth = 6;
            this.DataInizio.Name = "DataInizio";
            this.DataInizio.ReadOnly = true;
            this.DataInizio.Width = 80;
            // 
            // DataFine
            // 
            this.DataFine.DataPropertyName = "DataFine";
            this.DataFine.HeaderText = "Data fine";
            this.DataFine.MinimumWidth = 6;
            this.DataFine.Name = "DataFine";
            this.DataFine.ReadOnly = true;
            this.DataFine.Width = 80;
            // 
            // Details
            // 
            this.Details.HeaderText = "";
            this.Details.Image = global::WindowsFormApp.Properties.Resources.icons8_info_24;
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 25;
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreaTorneo);
            this.Controls.Add(this.lblTorneo);
            this.Controls.Add(this.cbTorneo);
            this.Controls.Add(this.dgvTornei);
            this.Name = "FormHomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTornei)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.ComboBox cbTorneo;
        private System.Windows.Forms.DataGridView dgvTornei;
        private System.Windows.Forms.Button btnCreaTorneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumEdizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFine;
        private System.Windows.Forms.DataGridViewImageColumn Details;
    }
}