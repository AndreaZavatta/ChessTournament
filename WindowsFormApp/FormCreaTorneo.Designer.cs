
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblRatingMax = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblRatingMinimo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMaxPartecipanti = new System.Windows.Forms.Label();
            this.lblDataInizio = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblPremio = new System.Windows.Forms.Label();
            this.dtpDataInizio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFine = new System.Windows.Forms.DateTimePicker();
            this.lblDataFine = new System.Windows.Forms.Label();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.lblAnno = new System.Windows.Forms.Label();
            this.txtNumeroEdizione = new System.Windows.Forms.TextBox();
            this.lblNumEdizione = new System.Windows.Forms.Label();
            this.cbVincitore = new System.Windows.Forms.ComboBox();
            this.cbLuogo = new System.Windows.Forms.ComboBox();
            this.cbOrganizzatore = new System.Windows.Forms.ComboBox();
            this.lblLuogo = new System.Windows.Forms.Label();
            this.lblOrganizzatore = new System.Windows.Forms.Label();
            this.lblVincitore = new System.Windows.Forms.Label();
            this.btnCreaTorneo = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(232, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(321, 27);
            this.txtNome.TabIndex = 1;
            // 
            // txtQuota
            // 
            this.txtQuota.Location = new System.Drawing.Point(232, 105);
            this.txtQuota.Name = "txtQuota";
            this.txtQuota.PlaceholderText = "Quota iscrizione";
            this.txtQuota.Size = new System.Drawing.Size(321, 27);
            this.txtQuota.TabIndex = 3;
            // 
            // lblQuota
            // 
            this.lblQuota.AutoSize = true;
            this.lblQuota.Location = new System.Drawing.Point(12, 105);
            this.lblQuota.Name = "lblQuota";
            this.lblQuota.Size = new System.Drawing.Size(116, 20);
            this.lblQuota.TabIndex = 2;
            this.lblQuota.Text = "Quota iscrizione";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(232, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Rating massimo";
            this.textBox3.Size = new System.Drawing.Size(321, 27);
            this.textBox3.TabIndex = 7;
            // 
            // lblRatingMax
            // 
            this.lblRatingMax.AutoSize = true;
            this.lblRatingMax.Location = new System.Drawing.Point(13, 174);
            this.lblRatingMax.Name = "lblRatingMax";
            this.lblRatingMax.Size = new System.Drawing.Size(115, 20);
            this.lblRatingMax.TabIndex = 6;
            this.lblRatingMax.Text = "Rating massimo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(232, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Rating minimo";
            this.textBox4.Size = new System.Drawing.Size(321, 27);
            this.textBox4.TabIndex = 5;
            // 
            // lblRatingMinimo
            // 
            this.lblRatingMinimo.AutoSize = true;
            this.lblRatingMinimo.Location = new System.Drawing.Point(13, 141);
            this.lblRatingMinimo.Name = "lblRatingMinimo";
            this.lblRatingMinimo.Size = new System.Drawing.Size(107, 20);
            this.lblRatingMinimo.TabIndex = 4;
            this.lblRatingMinimo.Text = "Rating minimo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Rating massimo";
            this.textBox1.Size = new System.Drawing.Size(321, 27);
            this.textBox1.TabIndex = 9;
            // 
            // lblMaxPartecipanti
            // 
            this.lblMaxPartecipanti.AutoSize = true;
            this.lblMaxPartecipanti.Location = new System.Drawing.Point(13, 207);
            this.lblMaxPartecipanti.Name = "lblMaxPartecipanti";
            this.lblMaxPartecipanti.Size = new System.Drawing.Size(210, 20);
            this.lblMaxPartecipanti.TabIndex = 8;
            this.lblMaxPartecipanti.Text = "Numero massimo partecipanti";
            // 
            // lblDataInizio
            // 
            this.lblDataInizio.AutoSize = true;
            this.lblDataInizio.Location = new System.Drawing.Point(13, 306);
            this.lblDataInizio.Name = "lblDataInizio";
            this.lblDataInizio.Size = new System.Drawing.Size(81, 20);
            this.lblDataInizio.TabIndex = 14;
            this.lblDataInizio.Text = "Data inizio";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(232, 270);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.PlaceholderText = "Descrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(321, 27);
            this.txtDescrizione.TabIndex = 13;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(13, 273);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(86, 20);
            this.lblDescrizione.TabIndex = 12;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(232, 237);
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Premio vincita";
            this.textBox6.Size = new System.Drawing.Size(321, 27);
            this.textBox6.TabIndex = 11;
            // 
            // lblPremio
            // 
            this.lblPremio.AutoSize = true;
            this.lblPremio.Location = new System.Drawing.Point(13, 240);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(103, 20);
            this.lblPremio.TabIndex = 10;
            this.lblPremio.Text = "Premio vincita";
            // 
            // dtpDataInizio
            // 
            this.dtpDataInizio.Location = new System.Drawing.Point(232, 303);
            this.dtpDataInizio.Name = "dtpDataInizio";
            this.dtpDataInizio.Size = new System.Drawing.Size(321, 27);
            this.dtpDataInizio.TabIndex = 16;
            // 
            // dtpDataFine
            // 
            this.dtpDataFine.Location = new System.Drawing.Point(232, 336);
            this.dtpDataFine.Name = "dtpDataFine";
            this.dtpDataFine.Size = new System.Drawing.Size(321, 27);
            this.dtpDataFine.TabIndex = 18;
            // 
            // lblDataFine
            // 
            this.lblDataFine.AutoSize = true;
            this.lblDataFine.Location = new System.Drawing.Point(13, 339);
            this.lblDataFine.Name = "lblDataFine";
            this.lblDataFine.Size = new System.Drawing.Size(72, 20);
            this.lblDataFine.TabIndex = 17;
            this.lblDataFine.Text = "Data Fine";
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(232, 402);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.PlaceholderText = "Anno";
            this.txtAnno.Size = new System.Drawing.Size(321, 27);
            this.txtAnno.TabIndex = 22;
            // 
            // lblAnno
            // 
            this.lblAnno.AutoSize = true;
            this.lblAnno.Location = new System.Drawing.Point(13, 405);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(44, 20);
            this.lblAnno.TabIndex = 21;
            this.lblAnno.Text = "Anno";
            // 
            // txtNumeroEdizione
            // 
            this.txtNumeroEdizione.Location = new System.Drawing.Point(232, 369);
            this.txtNumeroEdizione.Name = "txtNumeroEdizione";
            this.txtNumeroEdizione.PlaceholderText = "Numero edizione";
            this.txtNumeroEdizione.Size = new System.Drawing.Size(321, 27);
            this.txtNumeroEdizione.TabIndex = 20;
            // 
            // lblNumEdizione
            // 
            this.lblNumEdizione.AutoSize = true;
            this.lblNumEdizione.Location = new System.Drawing.Point(13, 372);
            this.lblNumEdizione.Name = "lblNumEdizione";
            this.lblNumEdizione.Size = new System.Drawing.Size(124, 20);
            this.lblNumEdizione.TabIndex = 19;
            this.lblNumEdizione.Text = "Numero edizione";
            // 
            // cbVincitore
            // 
            this.cbVincitore.FormattingEnabled = true;
            this.cbVincitore.Location = new System.Drawing.Point(232, 435);
            this.cbVincitore.Name = "cbVincitore";
            this.cbVincitore.Size = new System.Drawing.Size(321, 28);
            this.cbVincitore.TabIndex = 23;
            this.cbVincitore.Text = "Vincitore";
            // 
            // cbLuogo
            // 
            this.cbLuogo.FormattingEnabled = true;
            this.cbLuogo.Location = new System.Drawing.Point(232, 503);
            this.cbLuogo.Name = "cbLuogo";
            this.cbLuogo.Size = new System.Drawing.Size(321, 28);
            this.cbLuogo.TabIndex = 24;
            this.cbLuogo.Text = "Luogo";
            // 
            // cbOrganizzatore
            // 
            this.cbOrganizzatore.FormattingEnabled = true;
            this.cbOrganizzatore.Location = new System.Drawing.Point(232, 469);
            this.cbOrganizzatore.Name = "cbOrganizzatore";
            this.cbOrganizzatore.Size = new System.Drawing.Size(321, 28);
            this.cbOrganizzatore.TabIndex = 25;
            this.cbOrganizzatore.Text = "Organizzatore";
            // 
            // lblLuogo
            // 
            this.lblLuogo.AutoSize = true;
            this.lblLuogo.Location = new System.Drawing.Point(13, 509);
            this.lblLuogo.Name = "lblLuogo";
            this.lblLuogo.Size = new System.Drawing.Size(51, 20);
            this.lblLuogo.TabIndex = 28;
            this.lblLuogo.Text = "Luogo";
            // 
            // lblOrganizzatore
            // 
            this.lblOrganizzatore.AutoSize = true;
            this.lblOrganizzatore.Location = new System.Drawing.Point(13, 476);
            this.lblOrganizzatore.Name = "lblOrganizzatore";
            this.lblOrganizzatore.Size = new System.Drawing.Size(103, 20);
            this.lblOrganizzatore.TabIndex = 27;
            this.lblOrganizzatore.Text = "Organizzatore";
            // 
            // lblVincitore
            // 
            this.lblVincitore.AutoSize = true;
            this.lblVincitore.Location = new System.Drawing.Point(13, 443);
            this.lblVincitore.Name = "lblVincitore";
            this.lblVincitore.Size = new System.Drawing.Size(68, 20);
            this.lblVincitore.TabIndex = 26;
            this.lblVincitore.Text = "Vincitore";
            // 
            // btnCreaTorneo
            // 
            this.btnCreaTorneo.Location = new System.Drawing.Point(13, 568);
            this.btnCreaTorneo.Name = "btnCreaTorneo";
            this.btnCreaTorneo.Size = new System.Drawing.Size(115, 29);
            this.btnCreaTorneo.TabIndex = 29;
            this.btnCreaTorneo.Text = "Crea torneo";
            this.btnCreaTorneo.UseVisualStyleBackColor = true;
            this.btnCreaTorneo.Click += new System.EventHandler(this.btnCreaTorneo_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 29);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "<---";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormCreaTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 625);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreaTorneo);
            this.Controls.Add(this.lblLuogo);
            this.Controls.Add(this.lblOrganizzatore);
            this.Controls.Add(this.lblVincitore);
            this.Controls.Add(this.cbOrganizzatore);
            this.Controls.Add(this.cbLuogo);
            this.Controls.Add(this.cbVincitore);
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
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblPremio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMaxPartecipanti);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblRatingMax);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblRatingMinimo);
            this.Controls.Add(this.txtQuota);
            this.Controls.Add(this.lblQuota);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblRatingMax;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblRatingMinimo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMaxPartecipanti;
        private System.Windows.Forms.Label lblDataInizio;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.DateTimePicker dtpDataInizio;
        private System.Windows.Forms.DateTimePicker dtpDataFine;
        private System.Windows.Forms.Label lblDataFine;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.TextBox txtNumeroEdizione;
        private System.Windows.Forms.Label lblNumEdizione;
        private System.Windows.Forms.ComboBox cbVincitore;
        private System.Windows.Forms.ComboBox cbLuogo;
        private System.Windows.Forms.ComboBox cbOrganizzatore;
        private System.Windows.Forms.Label lblLuogo;
        private System.Windows.Forms.Label lblOrganizzatore;
        private System.Windows.Forms.Label lblVincitore;
        private System.Windows.Forms.Button btnCreaTorneo;
        private System.Windows.Forms.Button btnBack;
    }
}