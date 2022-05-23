
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
            this.bt_Salva = new System.Windows.Forms.Button();
            this.tx_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_Cognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_Email = new System.Windows.Forms.TextBox();
            this.tx_DataNascita = new System.Windows.Forms.DateTimePicker();
            this.btn_Elimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Salva
            // 
            this.bt_Salva.Location = new System.Drawing.Point(58, 222);
            this.bt_Salva.Name = "bt_Salva";
            this.bt_Salva.Size = new System.Drawing.Size(94, 29);
            this.bt_Salva.TabIndex = 0;
            this.bt_Salva.Text = "Salva";
            this.bt_Salva.UseVisualStyleBackColor = true;
            this.bt_Salva.Click += new System.EventHandler(this.button1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btn_Elimina);
            this.Controls.Add(this.tx_DataNascita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_Cognome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_Nome);
            this.Controls.Add(this.bt_Salva);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Salva;
        private System.Windows.Forms.TextBox tx_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_Cognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_Email;
        private System.Windows.Forms.DateTimePicker tx_DataNascita;
        private System.Windows.Forms.Button btn_Elimina;
    }
}

