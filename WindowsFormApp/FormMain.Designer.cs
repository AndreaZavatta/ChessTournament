
using System;
using System.Windows.Forms;

namespace WindowsFormApp
{
    partial class FormMain : Form
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
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.btnAllenatore = new System.Windows.Forms.Button();
            this.btnOrganizzatore = new System.Windows.Forms.Button();
            this.btnGiocatore = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabRegistrazione = new System.Windows.Forms.TabPage();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtFederazione = new System.Windows.Forms.TextBox();
            this.lblFederazione = new System.Windows.Forms.Label();
            this.lblGenere = new System.Windows.Forms.Label();
            this.lblTipologia = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtPasswordReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblNascita = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.cmbTipologia = new System.Windows.Forms.ComboBox();
            this.txtEmailReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegistrazione.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabRegistrazione);
            this.tabControl1.Location = new System.Drawing.Point(15, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 461);
            this.tabControl1.TabIndex = 2;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.btnAllenatore);
            this.tabLogin.Controls.Add(this.btnOrganizzatore);
            this.tabLogin.Controls.Add(this.btnGiocatore);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.txtEmail);
            this.tabLogin.Controls.Add(this.lblPassword);
            this.tabLogin.Controls.Add(this.lblEmail);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 29);
            this.tabLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabLogin.Size = new System.Drawing.Size(781, 428);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnAllenatore
            // 
            this.btnAllenatore.Location = new System.Drawing.Point(552, 369);
            this.btnAllenatore.Name = "btnAllenatore";
            this.btnAllenatore.Size = new System.Drawing.Size(94, 29);
            this.btnAllenatore.TabIndex = 13;
            this.btnAllenatore.Text = "Allenatore";
            this.btnAllenatore.UseVisualStyleBackColor = true;
            this.btnAllenatore.Click += new System.EventHandler(this.btnAllenatore_Click);
            // 
            // btnOrganizzatore
            // 
            this.btnOrganizzatore.Location = new System.Drawing.Point(325, 369);
            this.btnOrganizzatore.Name = "btnOrganizzatore";
            this.btnOrganizzatore.Size = new System.Drawing.Size(94, 29);
            this.btnOrganizzatore.TabIndex = 12;
            this.btnOrganizzatore.Text = "Organizzatore";
            this.btnOrganizzatore.UseVisualStyleBackColor = true;
            this.btnOrganizzatore.Click += new System.EventHandler(this.btnOrganizzatore_Click);
            // 
            // btnGiocatore
            // 
            this.btnGiocatore.Location = new System.Drawing.Point(89, 369);
            this.btnGiocatore.Name = "btnGiocatore";
            this.btnGiocatore.Size = new System.Drawing.Size(94, 29);
            this.btnGiocatore.TabIndex = 11;
            this.btnGiocatore.Text = "Giocatore";
            this.btnGiocatore.UseVisualStyleBackColor = true;
            this.btnGiocatore.Click += new System.EventHandler(this.btnGiocatore_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(238, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(214, 27);
            this.txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(238, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(214, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(161, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(161, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(238, 251);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabRegistrazione
            // 
            this.tabRegistrazione.Controls.Add(this.txtRating);
            this.tabRegistrazione.Controls.Add(this.lblRating);
            this.tabRegistrazione.Controls.Add(this.txtFederazione);
            this.tabRegistrazione.Controls.Add(this.lblFederazione);
            this.tabRegistrazione.Controls.Add(this.lblGenere);
            this.tabRegistrazione.Controls.Add(this.lblTipologia);
            this.tabRegistrazione.Controls.Add(this.btnSalva);
            this.tabRegistrazione.Controls.Add(this.txtPasswordReg);
            this.tabRegistrazione.Controls.Add(this.label1);
            this.tabRegistrazione.Controls.Add(this.dateTimePicker1);
            this.tabRegistrazione.Controls.Add(this.lblNascita);
            this.tabRegistrazione.Controls.Add(this.txtTelefono);
            this.tabRegistrazione.Controls.Add(this.lblTelefono);
            this.tabRegistrazione.Controls.Add(this.cmbGenere);
            this.tabRegistrazione.Controls.Add(this.cmbTipologia);
            this.tabRegistrazione.Controls.Add(this.txtEmailReg);
            this.tabRegistrazione.Controls.Add(this.label2);
            this.tabRegistrazione.Controls.Add(this.txtCognome);
            this.tabRegistrazione.Controls.Add(this.lblCognome);
            this.tabRegistrazione.Controls.Add(this.txtNome);
            this.tabRegistrazione.Controls.Add(this.lblNome);
            this.tabRegistrazione.Location = new System.Drawing.Point(4, 29);
            this.tabRegistrazione.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRegistrazione.Name = "tabRegistrazione";
            this.tabRegistrazione.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRegistrazione.Size = new System.Drawing.Size(781, 428);
            this.tabRegistrazione.TabIndex = 1;
            this.tabRegistrazione.Text = "Registrazione";
            this.tabRegistrazione.UseVisualStyleBackColor = true;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(291, 333);
            this.txtRating.Name = "txtRating";
            this.txtRating.PlaceholderText = "Rating";
            this.txtRating.Size = new System.Drawing.Size(313, 27);
            this.txtRating.TabIndex = 108;
            this.txtRating.UseWaitCursor = true;
            this.txtRating.Visible = false;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(184, 341);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(52, 20);
            this.lblRating.TabIndex = 41;
            this.lblRating.Text = "Rating";
            this.lblRating.UseWaitCursor = true;
            this.lblRating.Visible = false;
            // 
            // txtFederazione
            // 
            this.txtFederazione.Location = new System.Drawing.Point(291, 301);
            this.txtFederazione.Name = "txtFederazione";
            this.txtFederazione.PlaceholderText = "Federazione";
            this.txtFederazione.Size = new System.Drawing.Size(313, 27);
            this.txtFederazione.TabIndex = 107;
            this.txtFederazione.UseWaitCursor = true;
            this.txtFederazione.Visible = false;
            // 
            // lblFederazione
            // 
            this.lblFederazione.AutoSize = true;
            this.lblFederazione.Location = new System.Drawing.Point(184, 308);
            this.lblFederazione.Name = "lblFederazione";
            this.lblFederazione.Size = new System.Drawing.Size(90, 20);
            this.lblFederazione.TabIndex = 39;
            this.lblFederazione.Text = "Federazione";
            this.lblFederazione.Visible = false;
            // 
            // lblGenere
            // 
            this.lblGenere.AutoSize = true;
            this.lblGenere.Location = new System.Drawing.Point(184, 208);
            this.lblGenere.Name = "lblGenere";
            this.lblGenere.Size = new System.Drawing.Size(56, 20);
            this.lblGenere.TabIndex = 38;
            this.lblGenere.Text = "Genere";
            // 
            // lblTipologia
            // 
            this.lblTipologia.AutoSize = true;
            this.lblTipologia.Location = new System.Drawing.Point(184, 23);
            this.lblTipologia.Name = "lblTipologia";
            this.lblTipologia.Size = new System.Drawing.Size(73, 20);
            this.lblTipologia.TabIndex = 37;
            this.lblTipologia.Text = "Tipologia";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(291, 384);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(94, 29);
            this.btnSalva.TabIndex = 120;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtPasswordReg
            // 
            this.txtPasswordReg.Location = new System.Drawing.Point(291, 268);
            this.txtPasswordReg.Name = "txtPasswordReg";
            this.txtPasswordReg.PasswordChar = '*';
            this.txtPasswordReg.PlaceholderText = "Password";
            this.txtPasswordReg.Size = new System.Drawing.Size(313, 27);
            this.txtPasswordReg.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Password";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 27);
            this.dateTimePicker1.TabIndex = 106;
            // 
            // lblNascita
            // 
            this.lblNascita.AutoSize = true;
            this.lblNascita.Location = new System.Drawing.Point(184, 241);
            this.lblNascita.Name = "lblNascita";
            this.lblNascita.Size = new System.Drawing.Size(94, 20);
            this.lblNascita.TabIndex = 32;
            this.lblNascita.Text = "Data Nascita";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(291, 168);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Telefono";
            this.txtTelefono.Size = new System.Drawing.Size(313, 27);
            this.txtTelefono.TabIndex = 104;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(184, 175);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 20);
            this.lblTelefono.TabIndex = 30;
            this.lblTelefono.Text = "Telefono";
            // 
            // cmbGenere
            // 
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Items.AddRange(new object[] {
            "Maschio",
            "Femmina"});
            this.cmbGenere.Location = new System.Drawing.Point(291, 200);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(313, 28);
            this.cmbGenere.TabIndex = 105;
            this.cmbGenere.Text = "Genere";
            // 
            // cmbTipologia
            // 
            this.cmbTipologia.FormattingEnabled = true;
            this.cmbTipologia.Items.AddRange(new object[] {
            "Organizzatore",
            "Giocatore",
            "Allenatore"});
            this.cmbTipologia.Location = new System.Drawing.Point(291, 20);
            this.cmbTipologia.Name = "cmbTipologia";
            this.cmbTipologia.Size = new System.Drawing.Size(313, 28);
            this.cmbTipologia.TabIndex = 100;
            this.cmbTipologia.Text = "Tipologia";
            this.cmbTipologia.SelectedIndexChanged += new System.EventHandler(this.cmbTipologia_SelectedIndexChanged);
            // 
            // txtEmailReg
            // 
            this.txtEmailReg.Location = new System.Drawing.Point(291, 135);
            this.txtEmailReg.Name = "txtEmailReg";
            this.txtEmailReg.PlaceholderText = "Email";
            this.txtEmailReg.Size = new System.Drawing.Size(313, 27);
            this.txtEmailReg.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Email";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(291, 101);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.PlaceholderText = "Cognome";
            this.txtCognome.Size = new System.Drawing.Size(313, 27);
            this.txtCognome.TabIndex = 102;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(184, 109);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(74, 20);
            this.lblCognome.TabIndex = 24;
            this.lblCognome.Text = "Cognome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(291, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(313, 27);
            this.txtNome.TabIndex = 101;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(184, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 20);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegistrazione.ResumeLayout(false);
            this.tabRegistrazione.PerformLayout();
            this.ResumeLayout(false);

        }





        #endregion
        private TabControl tabControl1;
        private TabPage tabLogin;
        private TabPage tabRegistrazione;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Button btnLogin;
        private TextBox txtRating;
        private Label lblRating;
        private TextBox txtFederazione;
        private Label lblFederazione;
        private Label lblGenere;
        private Label lblTipologia;
        private Button btnSalva;
        private TextBox txtPasswordReg;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label lblNascita;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private ComboBox cmbGenere;
        private ComboBox cmbTipologia;
        private TextBox txtEmailReg;
        private Label label2;
        private TextBox txtCognome;
        private Label lblCognome;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnAllenatore;
        private Button btnOrganizzatore;
        private Button btnGiocatore;
    }
}