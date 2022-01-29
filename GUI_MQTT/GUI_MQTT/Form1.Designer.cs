
namespace GUI_MQTT
{
    partial class btt_Lichtaus
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Temp = new System.Windows.Forms.TextBox();
            this.pgr_Licht = new System.Windows.Forms.ProgressBar();
            this.Licht = new System.Windows.Forms.Label();
            this.btt_start = new System.Windows.Forms.Button();
            this.btt_Licht_aus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temp:";
            // 
            // txt_Temp
            // 
            this.txt_Temp.Location = new System.Drawing.Point(52, 60);
            this.txt_Temp.Name = "txt_Temp";
            this.txt_Temp.Size = new System.Drawing.Size(100, 20);
            this.txt_Temp.TabIndex = 1;
            // 
            // pgr_Licht
            // 
            this.pgr_Licht.Location = new System.Drawing.Point(197, 60);
            this.pgr_Licht.Maximum = 1;
            this.pgr_Licht.Name = "pgr_Licht";
            this.pgr_Licht.Size = new System.Drawing.Size(100, 23);
            this.pgr_Licht.TabIndex = 2;
            // 
            // Licht
            // 
            this.Licht.AutoSize = true;
            this.Licht.Location = new System.Drawing.Point(197, 41);
            this.Licht.Name = "Licht";
            this.Licht.Size = new System.Drawing.Size(30, 13);
            this.Licht.TabIndex = 3;
            this.Licht.Text = "Licht";
            // 
            // btt_start
            // 
            this.btt_start.Location = new System.Drawing.Point(378, 56);
            this.btt_start.Name = "btt_start";
            this.btt_start.Size = new System.Drawing.Size(75, 23);
            this.btt_start.TabIndex = 4;
            this.btt_start.Text = "Licht an";
            this.btt_start.UseVisualStyleBackColor = true;
            this.btt_start.Click += new System.EventHandler(this.btt_start_Click);
            // 
            // btt_Licht_aus
            // 
            this.btt_Licht_aus.Location = new System.Drawing.Point(492, 56);
            this.btt_Licht_aus.Name = "btt_Licht_aus";
            this.btt_Licht_aus.Size = new System.Drawing.Size(75, 23);
            this.btt_Licht_aus.TabIndex = 5;
            this.btt_Licht_aus.Text = "Licht aus";
            this.btt_Licht_aus.UseVisualStyleBackColor = true;
            this.btt_Licht_aus.Click += new System.EventHandler(this.btt_Licht_aus_Click);
            // 
            // btt_Lichtaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btt_Licht_aus);
            this.Controls.Add(this.btt_start);
            this.Controls.Add(this.Licht);
            this.Controls.Add(this.pgr_Licht);
            this.Controls.Add(this.txt_Temp);
            this.Controls.Add(this.label1);
            this.Name = "btt_Lichtaus";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Temp;
        private System.Windows.Forms.ProgressBar pgr_Licht;
        private System.Windows.Forms.Label Licht;
        private System.Windows.Forms.Button btt_start;
        private System.Windows.Forms.Button btt_Licht_aus;
    }
}

