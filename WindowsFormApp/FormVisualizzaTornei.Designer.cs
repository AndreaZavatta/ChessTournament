
namespace WindowsFormApp
{
    partial class FormVisualizzaTornei
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
            this.dgvTornei = new System.Windows.Forms.DataGridView();
            this.Descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTornei)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTornei
            // 
            this.dgvTornei.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTornei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTornei.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descrizione,
            this.DataInizio,
            this.DataFine});
            this.dgvTornei.Location = new System.Drawing.Point(12, 46);
            this.dgvTornei.Name = "dgvTornei";
            this.dgvTornei.RowHeadersWidth = 51;
            this.dgvTornei.RowTemplate.Height = 29;
            this.dgvTornei.Size = new System.Drawing.Size(776, 392);
            this.dgvTornei.TabIndex = 0;
            // 
            // Descrizione
            // 
            this.Descrizione.DataPropertyName = "Descrizione";
            this.Descrizione.HeaderText = "Descrizione";
            this.Descrizione.MinimumWidth = 6;
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.Width = 300;
            // 
            // DataInizio
            // 
            this.DataInizio.DataPropertyName = "DataInizio";
            this.DataInizio.HeaderText = "DataInizio";
            this.DataInizio.MinimumWidth = 6;
            this.DataInizio.Name = "DataInizio";
            this.DataInizio.Width = 125;
            // 
            // DataFine
            // 
            this.DataFine.DataPropertyName = "DataFine";
            this.DataFine.HeaderText = "DataFine";
            this.DataFine.MinimumWidth = 6;
            this.DataFine.Name = "DataFine";
            this.DataFine.Width = 125;
            // 
            // cbTorneo
            // 
            this.cbTorneo.FormattingEnabled = true;
            this.cbTorneo.Location = new System.Drawing.Point(318, 12);
            this.cbTorneo.Name = "cbTorneo";
            this.cbTorneo.Size = new System.Drawing.Size(298, 28);
            this.cbTorneo.TabIndex = 1;
            this.cbTorneo.SelectedIndexChanged += new System.EventHandler(this.cbTorneo_SelectedIndexChanged);
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Location = new System.Drawing.Point(257, 15);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(55, 20);
            this.lblTorneo.TabIndex = 2;
            this.lblTorneo.Text = "Torneo";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 29);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormVisualizzaTornei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTorneo);
            this.Controls.Add(this.cbTorneo);
            this.Controls.Add(this.dgvTornei);
            this.Name = "FormVisualizzaTornei";
            this.Text = "FormVisualizzaTornei";
            this.Load += new System.EventHandler(this.FormVisualizzaTornei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTornei)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTornei;
        private System.Windows.Forms.ComboBox cbTorneo;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFine;
        private System.Windows.Forms.Button btnBack;
    }
}