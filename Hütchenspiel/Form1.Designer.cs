namespace Hütchenspiel
{
    partial class frmHütchenspiel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKontostand = new System.Windows.Forms.Label();
            this.picBecher1 = new System.Windows.Forms.PictureBox();
            this.picBecher2 = new System.Windows.Forms.PictureBox();
            this.picBecher3 = new System.Windows.Forms.PictureBox();
            this.lblAusgang = new System.Windows.Forms.Label();
            this.lblZeit = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBecher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBecher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBecher3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kontostand:";
            // 
            // lblKontostand
            // 
            this.lblKontostand.AutoSize = true;
            this.lblKontostand.BackColor = System.Drawing.Color.Cyan;
            this.lblKontostand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontostand.Location = new System.Drawing.Point(631, 11);
            this.lblKontostand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKontostand.Name = "lblKontostand";
            this.lblKontostand.Size = new System.Drawing.Size(27, 29);
            this.lblKontostand.TabIndex = 1;
            this.lblKontostand.Text = "0";
            // 
            // picBecher1
            // 
            this.picBecher1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBecher1.BackColor = System.Drawing.Color.MidnightBlue;
            this.picBecher1.Location = new System.Drawing.Point(110, 185);
            this.picBecher1.Margin = new System.Windows.Forms.Padding(4);
            this.picBecher1.Name = "picBecher1";
            this.picBecher1.Size = new System.Drawing.Size(221, 152);
            this.picBecher1.TabIndex = 2;
            this.picBecher1.TabStop = false;
            this.picBecher1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picBecher1.MouseEnter += new System.EventHandler(this.picBecher1_MouseEnter);
            this.picBecher1.MouseLeave += new System.EventHandler(this.picBecher1_MouseLeave);
            // 
            // picBecher2
            // 
            this.picBecher2.Location = new System.Drawing.Point(450, 185);
            this.picBecher2.Margin = new System.Windows.Forms.Padding(4);
            this.picBecher2.Name = "picBecher2";
            this.picBecher2.Size = new System.Drawing.Size(200, 162);
            this.picBecher2.TabIndex = 3;
            this.picBecher2.TabStop = false;
            this.picBecher2.Click += new System.EventHandler(this.picBecher2_Click);
            this.picBecher2.MouseEnter += new System.EventHandler(this.picBecher2_MouseEnter);
            this.picBecher2.MouseLeave += new System.EventHandler(this.picBecher2_MouseLeave);
            // 
            // picBecher3
            // 
            this.picBecher3.Location = new System.Drawing.Point(764, 185);
            this.picBecher3.Margin = new System.Windows.Forms.Padding(4);
            this.picBecher3.Name = "picBecher3";
            this.picBecher3.Size = new System.Drawing.Size(192, 162);
            this.picBecher3.TabIndex = 4;
            this.picBecher3.TabStop = false;
            this.picBecher3.Click += new System.EventHandler(this.picBecher3_Click);
            this.picBecher3.MouseEnter += new System.EventHandler(this.picBecher3_MouseEnter);
            this.picBecher3.MouseLeave += new System.EventHandler(this.picBecher3_MouseLeave);
            // 
            // lblAusgang
            // 
            this.lblAusgang.AutoSize = true;
            this.lblAusgang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAusgang.Location = new System.Drawing.Point(384, 383);
            this.lblAusgang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAusgang.Name = "lblAusgang";
            this.lblAusgang.Size = new System.Drawing.Size(0, 29);
            this.lblAusgang.TabIndex = 5;
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeit.Location = new System.Drawing.Point(463, 438);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(0, 58);
            this.lblZeit.TabIndex = 7;
            this.lblZeit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHütchenspiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 552);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.lblAusgang);
            this.Controls.Add(this.picBecher3);
            this.Controls.Add(this.picBecher2);
            this.Controls.Add(this.picBecher1);
            this.Controls.Add(this.lblKontostand);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHütchenspiel";
            this.Text = "Hütchenspiel";

            ((System.ComponentModel.ISupportInitialize)(this.picBecher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBecher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBecher3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKontostand;
        private System.Windows.Forms.PictureBox picBecher1;
        private System.Windows.Forms.PictureBox picBecher2;
        private System.Windows.Forms.PictureBox picBecher3;
        private System.Windows.Forms.Label lblAusgang;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Timer tmr1;
    }
}

