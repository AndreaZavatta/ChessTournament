
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
            this.tabClassifica = new System.Windows.Forms.TabPage();
            this.tbClassifica = new System.Windows.Forms.TextBox();
            this.dgvClassifica = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStatistica3 = new System.Windows.Forms.TabPage();
            this.lblStatistica3 = new System.Windows.Forms.Label();
            this.cbAllenatore = new System.Windows.Forms.ComboBox();
            this.tbStatistica3 = new System.Windows.Forms.TextBox();
            this.dgvStatistica3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStatistica2 = new System.Windows.Forms.TabPage();
            this.lblGiocatore = new System.Windows.Forms.Label();
            this.cbGiocatore = new System.Windows.Forms.ComboBox();
            this.tbStatistica2 = new System.Windows.Forms.TextBox();
            this.dgvStatistica2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStatistica1 = new System.Windows.Forms.TabPage();
            this.tbStatistica1 = new System.Windows.Forms.TextBox();
            this.dgvStats1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partecipazioni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTornei = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClassifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassifica)).BeginInit();
            this.tabStatistica3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistica3)).BeginInit();
            this.tabStatistica2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistica2)).BeginInit();
            this.tabStatistica1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats1)).BeginInit();
            this.tabTornei.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTornei)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabClassifica
            // 
            this.tabClassifica.Controls.Add(this.tbClassifica);
            this.tabClassifica.Controls.Add(this.dgvClassifica);
            this.tabClassifica.Location = new System.Drawing.Point(4, 29);
            this.tabClassifica.Name = "tabClassifica";
            this.tabClassifica.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassifica.Size = new System.Drawing.Size(1107, 572);
            this.tabClassifica.TabIndex = 4;
            this.tabClassifica.Text = "Classifica";
            this.tabClassifica.UseVisualStyleBackColor = true;
            // 
            // tbClassifica
            // 
            this.tbClassifica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClassifica.BackColor = System.Drawing.Color.White;
            this.tbClassifica.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbClassifica.Location = new System.Drawing.Point(6, 3);
            this.tbClassifica.Multiline = true;
            this.tbClassifica.Name = "tbClassifica";
            this.tbClassifica.ReadOnly = true;
            this.tbClassifica.Size = new System.Drawing.Size(1095, 93);
            this.tbClassifica.TabIndex = 45;
            this.tbClassifica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvClassifica
            // 
            this.dgvClassifica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassifica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Rating});
            this.dgvClassifica.Location = new System.Drawing.Point(6, 103);
            this.dgvClassifica.Name = "dgvClassifica";
            this.dgvClassifica.RowHeadersWidth = 51;
            this.dgvClassifica.RowTemplate.Height = 29;
            this.dgvClassifica.Size = new System.Drawing.Size(1098, 468);
            this.dgvClassifica.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cognome";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cognome";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.Width = 125;
            // 
            // tabStatistica3
            // 
            this.tabStatistica3.Controls.Add(this.lblStatistica3);
            this.tabStatistica3.Controls.Add(this.cbAllenatore);
            this.tabStatistica3.Controls.Add(this.tbStatistica3);
            this.tabStatistica3.Controls.Add(this.dgvStatistica3);
            this.tabStatistica3.Location = new System.Drawing.Point(4, 29);
            this.tabStatistica3.Name = "tabStatistica3";
            this.tabStatistica3.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistica3.Size = new System.Drawing.Size(1107, 572);
            this.tabStatistica3.TabIndex = 3;
            this.tabStatistica3.Text = "Statistica 3";
            this.tabStatistica3.UseVisualStyleBackColor = true;
            // 
            // lblStatistica3
            // 
            this.lblStatistica3.AutoSize = true;
            this.lblStatistica3.Location = new System.Drawing.Point(62, 103);
            this.lblStatistica3.Name = "lblStatistica3";
            this.lblStatistica3.Size = new System.Drawing.Size(78, 20);
            this.lblStatistica3.TabIndex = 39;
            this.lblStatistica3.Text = "Allenatore";
            // 
            // cbAllenatore
            // 
            this.cbAllenatore.FormattingEnabled = true;
            this.cbAllenatore.Location = new System.Drawing.Point(169, 100);
            this.cbAllenatore.Name = "cbAllenatore";
            this.cbAllenatore.Size = new System.Drawing.Size(321, 28);
            this.cbAllenatore.TabIndex = 38;
            this.cbAllenatore.SelectedIndexChanged += new System.EventHandler(this.cbStatistica3_SelectedIndexChanged);
            // 
            // tbStatistica3
            // 
            this.tbStatistica3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatistica3.BackColor = System.Drawing.Color.White;
            this.tbStatistica3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStatistica3.Location = new System.Drawing.Point(6, 1);
            this.tbStatistica3.Multiline = true;
            this.tbStatistica3.Name = "tbStatistica3";
            this.tbStatistica3.ReadOnly = true;
            this.tbStatistica3.Size = new System.Drawing.Size(1098, 93);
            this.tbStatistica3.TabIndex = 37;
            this.tbStatistica3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvStatistica3
            // 
            this.dgvStatistica3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatistica3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistica3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvStatistica3.Location = new System.Drawing.Point(6, 157);
            this.dgvStatistica3.Name = "dgvStatistica3";
            this.dgvStatistica3.RowHeadersWidth = 51;
            this.dgvStatistica3.RowTemplate.Height = 29;
            this.dgvStatistica3.Size = new System.Drawing.Size(1095, 403);
            this.dgvStatistica3.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cognome";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cognome";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tabStatistica2
            // 
            this.tabStatistica2.Controls.Add(this.lblGiocatore);
            this.tabStatistica2.Controls.Add(this.cbGiocatore);
            this.tabStatistica2.Controls.Add(this.tbStatistica2);
            this.tabStatistica2.Controls.Add(this.dgvStatistica2);
            this.tabStatistica2.Location = new System.Drawing.Point(4, 29);
            this.tabStatistica2.Name = "tabStatistica2";
            this.tabStatistica2.Size = new System.Drawing.Size(1107, 572);
            this.tabStatistica2.TabIndex = 2;
            this.tabStatistica2.Text = "Statistica 2";
            this.tabStatistica2.UseVisualStyleBackColor = true;
            // 
            // lblGiocatore
            // 
            this.lblGiocatore.AutoSize = true;
            this.lblGiocatore.Location = new System.Drawing.Point(54, 105);
            this.lblGiocatore.Name = "lblGiocatore";
            this.lblGiocatore.Size = new System.Drawing.Size(74, 20);
            this.lblGiocatore.TabIndex = 35;
            this.lblGiocatore.Text = "Giocatore";
            // 
            // cbGiocatore
            // 
            this.cbGiocatore.FormattingEnabled = true;
            this.cbGiocatore.Location = new System.Drawing.Point(161, 101);
            this.cbGiocatore.Name = "cbGiocatore";
            this.cbGiocatore.Size = new System.Drawing.Size(321, 28);
            this.cbGiocatore.TabIndex = 34;
            this.cbGiocatore.SelectedIndexChanged += new System.EventHandler(this.cbGiocatore_SelectedIndexChanged);
            // 
            // tbStatistica2
            // 
            this.tbStatistica2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatistica2.BackColor = System.Drawing.Color.White;
            this.tbStatistica2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStatistica2.Location = new System.Drawing.Point(6, 3);
            this.tbStatistica2.Multiline = true;
            this.tbStatistica2.Name = "tbStatistica2";
            this.tbStatistica2.ReadOnly = true;
            this.tbStatistica2.Size = new System.Drawing.Size(1098, 93);
            this.tbStatistica2.TabIndex = 3;
            this.tbStatistica2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvStatistica2
            // 
            this.dgvStatistica2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistica2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvStatistica2.Location = new System.Drawing.Point(6, 155);
            this.dgvStatistica2.Name = "dgvStatistica2";
            this.dgvStatistica2.RowHeadersWidth = 51;
            this.dgvStatistica2.RowTemplate.Height = 29;
            this.dgvStatistica2.Size = new System.Drawing.Size(1098, 420);
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
            // tabStatistica1
            // 
            this.tabStatistica1.Controls.Add(this.tbStatistica1);
            this.tabStatistica1.Controls.Add(this.dgvStats1);
            this.tabStatistica1.Location = new System.Drawing.Point(4, 29);
            this.tabStatistica1.Name = "tabStatistica1";
            this.tabStatistica1.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistica1.Size = new System.Drawing.Size(1107, 572);
            this.tabStatistica1.TabIndex = 1;
            this.tabStatistica1.Text = "Statistica 1";
            this.tabStatistica1.UseVisualStyleBackColor = true;
            // 
            // tbStatistica1
            // 
            this.tbStatistica1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatistica1.BackColor = System.Drawing.Color.White;
            this.tbStatistica1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStatistica1.Location = new System.Drawing.Point(6, 6);
            this.tbStatistica1.Multiline = true;
            this.tbStatistica1.Name = "tbStatistica1";
            this.tbStatistica1.ReadOnly = true;
            this.tbStatistica1.Size = new System.Drawing.Size(1095, 90);
            this.tbStatistica1.TabIndex = 1;
            this.tbStatistica1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvStats1
            // 
            this.dgvStats1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStats1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Cognome,
            this.Partecipazioni});
            this.dgvStats1.Location = new System.Drawing.Point(6, 120);
            this.dgvStats1.Name = "dgvStats1";
            this.dgvStats1.RowHeadersWidth = 51;
            this.dgvStats1.RowTemplate.Height = 29;
            this.dgvStats1.Size = new System.Drawing.Size(1095, 446);
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
            // tabTornei
            // 
            this.tabTornei.Controls.Add(this.btnLogout);
            this.tabTornei.Controls.Add(this.btnCreaTorneo);
            this.tabTornei.Controls.Add(this.dgvTornei);
            this.tabTornei.Controls.Add(this.lblTorneo);
            this.tabTornei.Controls.Add(this.cbTorneo);
            this.tabTornei.Location = new System.Drawing.Point(4, 29);
            this.tabTornei.Name = "tabTornei";
            this.tabTornei.Padding = new System.Windows.Forms.Padding(3);
            this.tabTornei.Size = new System.Drawing.Size(1107, 572);
            this.tabTornei.TabIndex = 0;
            this.tabTornei.Text = "Tornei";
            this.tabTornei.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1028, 8);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(71, 31);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreaTorneo
            // 
            this.btnCreaTorneo.Location = new System.Drawing.Point(569, 13);
            this.btnCreaTorneo.Name = "btnCreaTorneo";
            this.btnCreaTorneo.Size = new System.Drawing.Size(101, 29);
            this.btnCreaTorneo.TabIndex = 10;
            this.btnCreaTorneo.Text = "Crea torneo";
            this.btnCreaTorneo.UseVisualStyleBackColor = true;
            this.btnCreaTorneo.Click += new System.EventHandler(this.btnCreaTorneo_Click);
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
            this.dgvTornei.Location = new System.Drawing.Point(7, 51);
            this.dgvTornei.Name = "dgvTornei";
            this.dgvTornei.RowHeadersWidth = 51;
            this.dgvTornei.RowTemplate.Height = 29;
            this.dgvTornei.Size = new System.Drawing.Size(1095, 512);
            this.dgvTornei.TabIndex = 7;
            this.dgvTornei.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTornei_CellContentClick);
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
            this.lblTorneo.Location = new System.Drawing.Point(18, 19);
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
            this.cbTorneo.SelectedIndexChanged += new System.EventHandler(this.cbTorneo_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTornei);
            this.tabControl1.Controls.Add(this.tabClassifica);
            this.tabControl1.Controls.Add(this.tabStatistica1);
            this.tabControl1.Controls.Add(this.tabStatistica2);
            this.tabControl1.Controls.Add(this.tabStatistica3);
            this.tabControl1.Location = new System.Drawing.Point(11, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 605);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 627);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(805, 663);
            this.Name = "FormHomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            this.tabClassifica.ResumeLayout(false);
            this.tabClassifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassifica)).EndInit();
            this.tabStatistica3.ResumeLayout(false);
            this.tabStatistica3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistica3)).EndInit();
            this.tabStatistica2.ResumeLayout(false);
            this.tabStatistica2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistica2)).EndInit();
            this.tabStatistica1.ResumeLayout(false);
            this.tabStatistica1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats1)).EndInit();
            this.tabTornei.ResumeLayout(false);
            this.tabTornei.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTornei)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabClassifica;
        private System.Windows.Forms.TextBox tbClassifica;
        private System.Windows.Forms.DataGridView dgvClassifica;
        private System.Windows.Forms.TabPage tabStatistica3;
        private System.Windows.Forms.Label lblStatistica3;
        private System.Windows.Forms.ComboBox cbAllenatore;
        private System.Windows.Forms.TextBox tbStatistica3;
        private System.Windows.Forms.DataGridView dgvStatistica3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage tabStatistica2;
        private System.Windows.Forms.Label lblGiocatore;
        private System.Windows.Forms.ComboBox cbGiocatore;
        private System.Windows.Forms.TextBox tbStatistica2;
        private System.Windows.Forms.DataGridView dgvStatistica2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabStatistica1;
        private System.Windows.Forms.TextBox tbStatistica1;
        private System.Windows.Forms.DataGridView dgvStats1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partecipazioni;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.Button btnLogout;
    }
}