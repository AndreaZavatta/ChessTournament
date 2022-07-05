
namespace WindowsFormApp
{
    partial class FormOrganizzatore
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
            this.btnCreaTorneo = new System.Windows.Forms.Button();
            this.btnVisualizzaTorneo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaTorneo
            // 
            this.btnCreaTorneo.Location = new System.Drawing.Point(172, 175);
            this.btnCreaTorneo.Name = "btnCreaTorneo";
            this.btnCreaTorneo.Size = new System.Drawing.Size(94, 29);
            this.btnCreaTorneo.TabIndex = 0;
            this.btnCreaTorneo.Text = "crea torneo";
            this.btnCreaTorneo.UseVisualStyleBackColor = true;
            this.btnCreaTorneo.Click += new System.EventHandler(this.btnCreaTorneo_Click);
            // 
            // btnVisualizzaTorneo
            // 
            this.btnVisualizzaTorneo.Location = new System.Drawing.Point(489, 175);
            this.btnVisualizzaTorneo.Name = "btnVisualizzaTorneo";
            this.btnVisualizzaTorneo.Size = new System.Drawing.Size(158, 29);
            this.btnVisualizzaTorneo.TabIndex = 1;
            this.btnVisualizzaTorneo.Text = "visualizza tornei";
            this.btnVisualizzaTorneo.UseVisualStyleBackColor = true;
            this.btnVisualizzaTorneo.Click += new System.EventHandler(this.btnVisualizzaTorneo_Click);
            // 
            // FormOrganizzatore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizzaTorneo);
            this.Controls.Add(this.btnCreaTorneo);
            this.Name = "FormOrganizzatore";
            this.Text = "FormOrganizzatore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreaTorneo;
        private System.Windows.Forms.Button btnVisualizzaTorneo;
    }
}