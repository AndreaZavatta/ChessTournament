
namespace WindowsFormApp
{
    partial class Main
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
            this.btnRegistrazione = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrazione
            // 
            this.btnRegistrazione.Location = new System.Drawing.Point(235, 139);
            this.btnRegistrazione.Name = "btnRegistrazione";
            this.btnRegistrazione.Size = new System.Drawing.Size(94, 29);
            this.btnRegistrazione.TabIndex = 0;
            this.btnRegistrazione.Text = "Registrati";
            this.btnRegistrazione.UseVisualStyleBackColor = true;
            this.btnRegistrazione.Click += new System.EventHandler(this.btnRegistrazione_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(480, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegistrazione);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrazione;
        private System.Windows.Forms.Button btnLogin;
    }
}