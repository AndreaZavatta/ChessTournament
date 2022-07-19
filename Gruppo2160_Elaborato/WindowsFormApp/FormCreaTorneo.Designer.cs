
namespace WindowsFormApp
{
    partial class FormCreaTorneo
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQuota = new System.Windows.Forms.TextBox();
            this.lblQuota = new System.Windows.Forms.Label();
            this.txtRatingMassimo = new System.Windows.Forms.TextBox();
            this.lblRatingMax = new System.Windows.Forms.Label();
            this.txtRatingMinimo = new System.Windows.Forms.TextBox();
            this.lblRatingMinimo = new System.Windows.Forms.Label();
            this.txtMaxPartecipanti = new System.Windows.Forms.TextBox();
            this.lblMaxPartecipanti = new System.Windows.Forms.Label();
            this.lblDataInizio = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.txtPremio = new System.Windows.Forms.TextBox();
            this.lblPremio = new System.Windows.Forms.Label();
            this.dtpDataInizio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFine = new System.Windows.Forms.DateTimePicker();
            this.lblDataFine = new System.Windows.Forms.Label();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.lblAnno = new System.Windows.Forms.Label();
            this.txtNumeroEdizione = new System.Windows.Forms.TextBox();
            this.lblNumEdizione = new System.Windows.Forms.Label();
            this.cbLuogo = new System.Windows.Forms.ComboBox();
            this.cbOrganizzatore = new System.Windows.Forms.ComboBox();
            this.lblLuogo = new System.Windows.Forms.Label();
            this.lblOrganizzatore = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 115);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(218, 112);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(281, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtQuota
            // 
            this.txtQuota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuota.Location = new System.Drawing.Point(218, 137);
            this.txtQuota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuota.Name = "txtQuota";
            this.txtQuota.PlaceholderText = "Quota iscrizione";
            this.txtQuota.Size = new System.Drawing.Size(281, 23);
            this.txtQuota.TabIndex = 3;
            // 
            // lblQuota
            // 
            this.lblQuota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuota.AutoSize = true;
            this.lblQuota.Location = new System.Drawing.Point(25, 137);
            this.lblQuota.Name = "lblQuota";
            this.lblQuota.Size = new System.Drawing.Size(92, 15);
            this.lblQuota.TabIndex = 2;
            this.lblQuota.Text = "Quota iscrizione";
            // 
            // txtRatingMassimo
            // 
            this.txtRatingMassimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRatingMassimo.Location = new System.Drawing.Point(218, 187);
            this.txtRatingMassimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRatingMassimo.Name = "txtRatingMassimo";
            this.txtRatingMassimo.PlaceholderText = "Rating massimo";
            this.txtRatingMassimo.Size = new System.Drawing.Size(281, 23);
            this.txtRatingMassimo.TabIndex = 7;
            // 
            // lblRatingMax
            // 
            this.lblRatingMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRatingMax.AutoSize = true;
            this.lblRatingMax.Location = new System.Drawing.Point(27, 188);
            this.lblRatingMax.Name = "lblRatingMax";
            this.lblRatingMax.Size = new System.Drawing.Size(92, 15);
            this.lblRatingMax.TabIndex = 6;
            this.lblRatingMax.Text = "Rating massimo";
            // 
            // txtRatingMinimo
            // 
            this.txtRatingMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRatingMinimo.Location = new System.Drawing.Point(218, 163);
            this.txtRatingMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRatingMinimo.Name = "txtRatingMinimo";
            this.txtRatingMinimo.PlaceholderText = "Rating minimo";
            this.txtRatingMinimo.Size = new System.Drawing.Size(281, 23);
            this.txtRatingMinimo.TabIndex = 5;
            // 
            // lblRatingMinimo
            // 
            this.lblRatingMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRatingMinimo.AutoSize = true;
            this.lblRatingMinimo.Location = new System.Drawing.Point(27, 164);
            this.lblRatingMinimo.Name = "lblRatingMinimo";
            this.lblRatingMinimo.Size = new System.Drawing.Size(86, 15);
            this.lblRatingMinimo.TabIndex = 4;
            this.lblRatingMinimo.Text = "Rating minimo";
            // 
            // txtMaxPartecipanti
            // 
            this.txtMaxPartecipanti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxPartecipanti.Location = new System.Drawing.Point(218, 212);
            this.txtMaxPartecipanti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxPartecipanti.Name = "txtMaxPartecipanti";
            this.txtMaxPartecipanti.PlaceholderText = "Rating massimo";
            this.txtMaxPartecipanti.Size = new System.Drawing.Size(281, 23);
            this.txtMaxPartecipanti.TabIndex = 9;
            // 
            // lblMaxPartecipanti
            // 
            this.lblMaxPartecipanti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxPartecipanti.AutoSize = true;
            this.lblMaxPartecipanti.Location = new System.Drawing.Point(27, 214);
            this.lblMaxPartecipanti.Name = "lblMaxPartecipanti";
            this.lblMaxPartecipanti.Size = new System.Drawing.Size(168, 15);
            this.lblMaxPartecipanti.TabIndex = 8;
            this.lblMaxPartecipanti.Text = "Numero massimo partecipanti";
            // 
            // lblDataInizio
            // 
            this.lblDataInizio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataInizio.AutoSize = true;
            this.lblDataInizio.Location = new System.Drawing.Point(577, 138);
            this.lblDataInizio.Name = "lblDataInizio";
            this.lblDataInizio.Size = new System.Drawing.Size(62, 15);
            this.lblDataInizio.TabIndex = 14;
            this.lblDataInizio.Text = "Data inizio";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescrizione.Location = new System.Drawing.Point(696, 110);
            this.txtDescrizione.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.PlaceholderText = "Descrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(281, 23);
            this.txtDescrizione.TabIndex = 13;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(577, 112);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(67, 15);
            this.lblDescrizione.TabIndex = 12;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // txtPremio
            // 
            this.txtPremio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPremio.Location = new System.Drawing.Point(696, 86);
            this.txtPremio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPremio.Name = "txtPremio";
            this.txtPremio.PlaceholderText = "Premio vincita";
            this.txtPremio.Size = new System.Drawing.Size(281, 23);
            this.txtPremio.TabIndex = 11;
            // 
            // lblPremio
            // 
            this.lblPremio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPremio.AutoSize = true;
            this.lblPremio.Location = new System.Drawing.Point(577, 88);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(83, 15);
            this.lblPremio.TabIndex = 10;
            this.lblPremio.Text = "Premio vincita";
            // 
            // dtpDataInizio
            // 
            this.dtpDataInizio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataInizio.Location = new System.Drawing.Point(696, 135);
            this.dtpDataInizio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataInizio.Name = "dtpDataInizio";
            this.dtpDataInizio.Size = new System.Drawing.Size(281, 23);
            this.dtpDataInizio.TabIndex = 16;
            // 
            // dtpDataFine
            // 
            this.dtpDataFine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataFine.Location = new System.Drawing.Point(696, 160);
            this.dtpDataFine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataFine.Name = "dtpDataFine";
            this.dtpDataFine.Size = new System.Drawing.Size(281, 23);
            this.dtpDataFine.TabIndex = 18;
            // 
            // lblDataFine
            // 
            this.lblDataFine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataFine.AutoSize = true;
            this.lblDataFine.Location = new System.Drawing.Point(577, 162);
            this.lblDataFine.Name = "lblDataFine";
            this.lblDataFine.Size = new System.Drawing.Size(56, 15);
            this.lblDataFine.TabIndex = 17;
            this.lblDataFine.Text = "Data Fine";
            // 
            // txtAnno
            // 
            this.txtAnno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnno.Location = new System.Drawing.Point(696, 210);
            this.txtAnno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.PlaceholderText = "Anno";
            this.txtAnno.Size = new System.Drawing.Size(281, 23);
            this.txtAnno.TabIndex = 22;
            // 
            // lblAnno
            // 
            this.lblAnno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnno.AutoSize = true;
            this.lblAnno.Location = new System.Drawing.Point(577, 212);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(36, 15);
            this.lblAnno.TabIndex = 21;
            this.lblAnno.Text = "Anno";
            // 
            // txtNumeroEdizione
            // 
            this.txtNumeroEdizione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroEdizione.Location = new System.Drawing.Point(696, 184);
            this.txtNumeroEdizione.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroEdizione.Name = "txtNumeroEdizione";
            this.txtNumeroEdizione.PlaceholderText = "Numero edizione";
            this.txtNumeroEdizione.Size = new System.Drawing.Size(281, 23);
            this.txtNumeroEdizione.TabIndex = 20;
            // 
            // lblNumEdizione
            // 
            this.lblNumEdizione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumEdizione.AutoSize = true;
            this.lblNumEdizione.Location = new System.Drawing.Point(577, 187);
            this.lblNumEdizione.Name = "lblNumEdizione";
            this.lblNumEdizione.Size = new System.Drawing.Size(98, 15);
            this.lblNumEdizione.TabIndex = 19;
            this.lblNumEdizione.Text = "Numero edizione";
            // 
            // cbLuogo
            // 
            this.cbLuogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLuogo.FormattingEnabled = true;
            this.cbLuogo.Location = new System.Drawing.Point(696, 260);
            this.cbLuogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLuogo.Name = "cbLuogo";
            this.cbLuogo.Size = new System.Drawing.Size(281, 23);
            this.cbLuogo.TabIndex = 24;
            this.cbLuogo.Text = "Luogo";
            // 
            // cbOrganizzatore
            // 
            this.cbOrganizzatore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOrganizzatore.FormattingEnabled = true;
            this.cbOrganizzatore.Location = new System.Drawing.Point(696, 235);
            this.cbOrganizzatore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrganizzatore.Name = "cbOrganizzatore";
            this.cbOrganizzatore.Size = new System.Drawing.Size(281, 23);
            this.cbOrganizzatore.TabIndex = 25;
            this.cbOrganizzatore.Text = "Organizzatore";
            // 
            // lblLuogo
            // 
            this.lblLuogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLuogo.AutoSize = true;
            this.lblLuogo.Location = new System.Drawing.Point(577, 265);
            this.lblLuogo.Name = "lblLuogo";
            this.lblLuogo.Size = new System.Drawing.Size(41, 15);
            this.lblLuogo.TabIndex = 28;
            this.lblLuogo.Text = "Luogo";
            // 
            // lblOrganizzatore
            // 
            this.lblOrganizzatore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrganizzatore.AutoSize = true;
            this.lblOrganizzatore.Location = new System.Drawing.Point(577, 240);
            this.lblOrganizzatore.Name = "lblOrganizzatore";
            this.lblOrganizzatore.Size = new System.Drawing.Size(80, 15);
            this.lblOrganizzatore.TabIndex = 27;
            this.lblOrganizzatore.Text = "Organizzatore";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(11, 426);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(101, 22);
            this.btnSalva.TabIndex = 29;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Torneo";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(696, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Edizione";
            // 
            // cbTorneo
            // 
            this.cbTorneo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTorneo.FormattingEnabled = true;
            this.cbTorneo.Location = new System.Drawing.Point(218, 86);
            this.cbTorneo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTorneo.Name = "cbTorneo";
            this.cbTorneo.Size = new System.Drawing.Size(281, 23);
            this.cbTorneo.TabIndex = 33;
            this.cbTorneo.SelectedIndexChanged += new System.EventHandler(this.cbTorneo_SelectedIndexChanged);
            // 
            // FormCreaTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 469);
            this.Controls.Add(this.cbTorneo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.lblLuogo);
            this.Controls.Add(this.lblOrganizzatore);
            this.Controls.Add(this.cbOrganizzatore);
            this.Controls.Add(this.cbLuogo);
            this.Controls.Add(this.txtAnno);
            this.Controls.Add(this.lblAnno);
            this.Controls.Add(this.txtNumeroEdizione);
            this.Controls.Add(this.lblNumEdizione);
            this.Controls.Add(this.dtpDataFine);
            this.Controls.Add(this.lblDataFine);
            this.Controls.Add(this.dtpDataInizio);
            this.Controls.Add(this.lblDataInizio);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.txtPremio);
            this.Controls.Add(this.lblPremio);
            this.Controls.Add(this.txtMaxPartecipanti);
            this.Controls.Add(this.lblMaxPartecipanti);
            this.Controls.Add(this.txtRatingMassimo);
            this.Controls.Add(this.lblRatingMax);
            this.Controls.Add(this.txtRatingMinimo);
            this.Controls.Add(this.lblRatingMinimo);
            this.Controls.Add(this.txtQuota);
            this.Controls.Add(this.lblQuota);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCreaTorneo";
            this.Text = "FormCreaTorneo";
            this.Load += new System.EventHandler(this.FormCreaTorneo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQuota;
        private System.Windows.Forms.Label lblQuota;
        private System.Windows.Forms.TextBox txtRatingMassimo;
        private System.Windows.Forms.Label lblRatingMax;
        private System.Windows.Forms.TextBox txtRatingMinimo;
        private System.Windows.Forms.Label lblRatingMinimo;
        private System.Windows.Forms.TextBox txtMaxPartecipanti;
        private System.Windows.Forms.Label lblMaxPartecipanti;
        private System.Windows.Forms.Label lblDataInizio;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.TextBox txtPremio;
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.DateTimePicker dtpDataInizio;
        private System.Windows.Forms.DateTimePicker dtpDataFine;
        private System.Windows.Forms.Label lblDataFine;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.TextBox txtNumeroEdizione;
        private System.Windows.Forms.Label lblNumEdizione;
        private System.Windows.Forms.ComboBox cbLuogo;
        private System.Windows.Forms.ComboBox cbOrganizzatore;
        private System.Windows.Forms.Label lblLuogo;
        private System.Windows.Forms.Label lblOrganizzatore;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTorneo;
    }
}