
using System;

namespace WindowsFormApp
{
    partial class FormRegistrazione
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
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbTipologia = new System.Windows.Forms.ComboBox();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNascita = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.lblTipologia = new System.Windows.Forms.Label();
            this.lblGenere = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtFederazione = new System.Windows.Forms.TextBox();
            this.lblFederazione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 121);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(312, 27);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(125, 147);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.PlaceholderText = "Cognome";
            this.txtCognome.Size = new System.Drawing.Size(312, 27);
            this.txtCognome.TabIndex = 3;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(17, 154);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(74, 20);
            this.lblCognome.TabIndex = 2;
            this.lblCognome.Text = "Cognome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(312, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 187);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // cmbTipologia
            // 
            this.cmbTipologia.FormattingEnabled = true;
            this.cmbTipologia.Items.AddRange(new object[] {
            "Organizzatore",
            "Giocatore",
            "Allenatore"});
            this.cmbTipologia.Location = new System.Drawing.Point(125, 65);
            this.cmbTipologia.Name = "cmbTipologia";
            this.cmbTipologia.Size = new System.Drawing.Size(312, 28);
            this.cmbTipologia.TabIndex = 6;
            this.cmbTipologia.Text = "Tipologia";
            this.cmbTipologia.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbGenere
            // 
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Items.AddRange(new object[] {
            "Maschio",
            "Femmina"});
            this.cmbGenere.Location = new System.Drawing.Point(125, 246);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(312, 28);
            this.cmbGenere.TabIndex = 7;
            this.cmbGenere.Text = "Genere";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(125, 213);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Telefono";
            this.txtTelefono.Size = new System.Drawing.Size(312, 27);
            this.txtTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(17, 220);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 20);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNascita
            // 
            this.lblNascita.AutoSize = true;
            this.lblNascita.Location = new System.Drawing.Point(17, 287);
            this.lblNascita.Name = "lblNascita";
            this.lblNascita.Size = new System.Drawing.Size(94, 20);
            this.lblNascita.TabIndex = 10;
            this.lblNascita.Text = "Data Nascita";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 27);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 313);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(312, 27);
            this.txtPassword.TabIndex = 14;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 320);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(125, 430);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(94, 29);
            this.btnSalva.TabIndex = 15;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // lblTipologia
            // 
            this.lblTipologia.AutoSize = true;
            this.lblTipologia.Location = new System.Drawing.Point(17, 68);
            this.lblTipologia.Name = "lblTipologia";
            this.lblTipologia.Size = new System.Drawing.Size(73, 20);
            this.lblTipologia.TabIndex = 16;
            this.lblTipologia.Text = "Tipologia";
            // 
            // lblGenere
            // 
            this.lblGenere.AutoSize = true;
            this.lblGenere.Location = new System.Drawing.Point(17, 254);
            this.lblGenere.Name = "lblGenere";
            this.lblGenere.Size = new System.Drawing.Size(56, 20);
            this.lblGenere.TabIndex = 17;
            this.lblGenere.Text = "Genere";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(125, 379);
            this.txtRating.Name = "txtRating";
            this.txtRating.PlaceholderText = "Rating";
            this.txtRating.Size = new System.Drawing.Size(312, 27);
            this.txtRating.TabIndex = 21;
            this.txtRating.UseWaitCursor = true;
            this.txtRating.Visible = false;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(17, 386);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(52, 20);
            this.lblRating.TabIndex = 20;
            this.lblRating.Text = "Rating";
            this.lblRating.UseWaitCursor = true;
            this.lblRating.Visible = false;
            // 
            // txtFederazione
            // 
            this.txtFederazione.Location = new System.Drawing.Point(125, 346);
            this.txtFederazione.Name = "txtFederazione";
            this.txtFederazione.PlaceholderText = "Federazione";
            this.txtFederazione.Size = new System.Drawing.Size(312, 27);
            this.txtFederazione.TabIndex = 19;
            this.txtFederazione.UseWaitCursor = true;
            this.txtFederazione.Visible = false;
            // 
            // lblFederazione
            // 
            this.lblFederazione.AutoSize = true;
            this.lblFederazione.Location = new System.Drawing.Point(17, 353);
            this.lblFederazione.Name = "lblFederazione";
            this.lblFederazione.Size = new System.Drawing.Size(90, 20);
            this.lblFederazione.TabIndex = 18;
            this.lblFederazione.Text = "Federazione";
            this.lblFederazione.Visible = false;
            // 
            // FormRegistrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 601);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.txtFederazione);
            this.Controls.Add(this.lblFederazione);
            this.Controls.Add(this.lblGenere);
            this.Controls.Add(this.lblTipologia);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblNascita);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.cmbGenere);
            this.Controls.Add(this.cmbTipologia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FormRegistrazione";
            this.Text = "Registrazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbTipologia;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNascita;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label lblTipologia;
        private System.Windows.Forms.Label lblGenere;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtFederazione;
        private System.Windows.Forms.Label lblFederazione;
    }
}