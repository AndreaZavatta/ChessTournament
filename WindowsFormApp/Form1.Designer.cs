﻿
namespace WindowsFormApp
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
            this.btn_Salva = new System.Windows.Forms.Button();
            this.tx_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_Cognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_Email = new System.Windows.Forms.TextBox();
            this.tx_DataNascita = new System.Windows.Forms.DateTimePicker();
            this.btn_Elimina = new System.Windows.Forms.Button();
            this.dg_Persone = new System.Windows.Forms.DataGridView();
            this.btn_Visualizza = new System.Windows.Forms.Button();
            this.IdPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Persone)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salva
            // 
            this.btn_Salva.Location = new System.Drawing.Point(58, 222);
            this.btn_Salva.Name = "btn_Salva";
            this.btn_Salva.Size = new System.Drawing.Size(94, 29);
            this.btn_Salva.TabIndex = 0;
            this.btn_Salva.Text = "Salva";
            this.btn_Salva.UseVisualStyleBackColor = true;
            this.btn_Salva.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_Nome
            // 
            this.tx_Nome.Location = new System.Drawing.Point(138, 57);
            this.tx_Nome.Name = "tx_Nome";
            this.tx_Nome.Size = new System.Drawing.Size(125, 27);
            this.tx_Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cognome";
            // 
            // tx_Cognome
            // 
            this.tx_Cognome.Location = new System.Drawing.Point(138, 90);
            this.tx_Cognome.Name = "tx_Cognome";
            this.tx_Cognome.Size = new System.Drawing.Size(125, 27);
            this.tx_Cognome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // tx_Email
            // 
            this.tx_Email.Location = new System.Drawing.Point(138, 156);
            this.tx_Email.Name = "tx_Email";
            this.tx_Email.Size = new System.Drawing.Size(125, 27);
            this.tx_Email.TabIndex = 7;
            // 
            // tx_DataNascita
            // 
            this.tx_DataNascita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tx_DataNascita.Location = new System.Drawing.Point(138, 123);
            this.tx_DataNascita.Name = "tx_DataNascita";
            this.tx_DataNascita.Size = new System.Drawing.Size(125, 27);
            this.tx_DataNascita.TabIndex = 9;
            // 
            // btn_Elimina
            // 
            this.btn_Elimina.Location = new System.Drawing.Point(201, 222);
            this.btn_Elimina.Name = "btn_Elimina";
            this.btn_Elimina.Size = new System.Drawing.Size(94, 29);
            this.btn_Elimina.TabIndex = 10;
            this.btn_Elimina.Text = "Elimina";
            this.btn_Elimina.UseVisualStyleBackColor = true;
            this.btn_Elimina.Click += new System.EventHandler(this.btn_Elimina_Click);
            // 
            // dg_Persone
            // 
            this.dg_Persone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Persone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPersona,
            this.Nome,
            this.Cognome,
            this.DataNascita,
            this.Email,
            this.Delete});
            this.dg_Persone.Location = new System.Drawing.Point(347, 57);
            this.dg_Persone.Name = "dg_Persone";
            this.dg_Persone.RowHeadersVisible = false;
            this.dg_Persone.RowHeadersWidth = 51;
            this.dg_Persone.RowTemplate.Height = 29;
            this.dg_Persone.Size = new System.Drawing.Size(564, 188);
            this.dg_Persone.TabIndex = 11;
            this.dg_Persone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Persone_CellContentClick);
            // 
            // btn_Visualizza
            // 
            this.btn_Visualizza.Location = new System.Drawing.Point(374, 267);
            this.btn_Visualizza.Name = "btn_Visualizza";
            this.btn_Visualizza.Size = new System.Drawing.Size(94, 29);
            this.btn_Visualizza.TabIndex = 12;
            this.btn_Visualizza.Text = "Visualizza";
            this.btn_Visualizza.UseVisualStyleBackColor = true;
            this.btn_Visualizza.Click += new System.EventHandler(this.btn_Visualizza_Click);
            // 
            // IdPersona
            // 
            this.IdPersona.DataPropertyName = "IdPersona";
            this.IdPersona.HeaderText = "Id";
            this.IdPersona.MinimumWidth = 6;
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.Visible = false;
            this.IdPersona.Width = 125;
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
            // DataNascita
            // 
            this.DataNascita.DataPropertyName = "DataNascita";
            this.DataNascita.HeaderText = "Data";
            this.DataNascita.MinimumWidth = 6;
            this.DataNascita.Name = "DataNascita";
            this.DataNascita.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btn_Visualizza);
            this.Controls.Add(this.dg_Persone);
            this.Controls.Add(this.btn_Elimina);
            this.Controls.Add(this.tx_DataNascita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_Cognome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_Nome);
            this.Controls.Add(this.btn_Salva);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Persone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salva;
        private System.Windows.Forms.TextBox tx_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_Cognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_Email;
        private System.Windows.Forms.DateTimePicker tx_DataNascita;
        private System.Windows.Forms.Button btn_Elimina;
        private System.Windows.Forms.DataGridView dg_Persone;
        private System.Windows.Forms.Button btn_Visualizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}

