namespace SlotMachineV1
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.bgwRullo1 = new System.ComponentModel.BackgroundWorker();
            this.bgwRullo2 = new System.ComponentModel.BackgroundWorker();
            this.bgwRullo3 = new System.ComponentModel.BackgroundWorker();
            this.pctTitolo = new System.Windows.Forms.PictureBox();
            this.pctRullo2 = new System.Windows.Forms.PictureBox();
            this.pctRullo3 = new System.Windows.Forms.PictureBox();
            this.pctRullo1 = new System.Windows.Forms.PictureBox();
            this.btnRisultati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRullo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRullo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRullo1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(249, 179);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(198, 51);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "button2";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 179);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(198, 51);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // bgwRullo1
            // 
            this.bgwRullo1.WorkerReportsProgress = true;
            this.bgwRullo1.WorkerSupportsCancellation = true;
            this.bgwRullo1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRullo1_DoWork);
            // 
            // bgwRullo2
            // 
            this.bgwRullo2.WorkerReportsProgress = true;
            this.bgwRullo2.WorkerSupportsCancellation = true;
            this.bgwRullo2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRullo2_DoWork);
            // 
            // bgwRullo3
            // 
            this.bgwRullo3.WorkerReportsProgress = true;
            this.bgwRullo3.WorkerSupportsCancellation = true;
            this.bgwRullo3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRullo3_DoWork);
            // 
            // pctTitolo
            // 
            this.pctTitolo.Location = new System.Drawing.Point(12, 4);
            this.pctTitolo.Name = "pctTitolo";
            this.pctTitolo.Size = new System.Drawing.Size(434, 63);
            this.pctTitolo.TabIndex = 17;
            this.pctTitolo.TabStop = false;
            // 
            // pctRullo2
            // 
            this.pctRullo2.Location = new System.Drawing.Point(159, 73);
            this.pctRullo2.Name = "pctRullo2";
            this.pctRullo2.Size = new System.Drawing.Size(141, 96);
            this.pctRullo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRullo2.TabIndex = 14;
            this.pctRullo2.TabStop = false;
            // 
            // pctRullo3
            // 
            this.pctRullo3.Location = new System.Drawing.Point(306, 73);
            this.pctRullo3.Name = "pctRullo3";
            this.pctRullo3.Size = new System.Drawing.Size(141, 96);
            this.pctRullo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRullo3.TabIndex = 13;
            this.pctRullo3.TabStop = false;
            // 
            // pctRullo1
            // 
            this.pctRullo1.Location = new System.Drawing.Point(12, 73);
            this.pctRullo1.Name = "pctRullo1";
            this.pctRullo1.Size = new System.Drawing.Size(141, 96);
            this.pctRullo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRullo1.TabIndex = 12;
            this.pctRullo1.TabStop = false;
            // 
            // btnRisultati
            // 
            this.btnRisultati.Font = new System.Drawing.Font("Ravie", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRisultati.Location = new System.Drawing.Point(348, 236);
            this.btnRisultati.Name = "btnRisultati";
            this.btnRisultati.Size = new System.Drawing.Size(99, 27);
            this.btnRisultati.TabIndex = 18;
            this.btnRisultati.Text = "button1";
            this.btnRisultati.UseVisualStyleBackColor = true;
            this.btnRisultati.Click += new System.EventHandler(this.btnRisultati_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 275);
            this.Controls.Add(this.btnRisultati);
            this.Controls.Add(this.pctTitolo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pctRullo2);
            this.Controls.Add(this.pctRullo3);
            this.Controls.Add(this.pctRullo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "$ Lucky Slot $";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctTitolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRullo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRullo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRullo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pctRullo2;
        private System.Windows.Forms.PictureBox pctRullo3;
        private System.Windows.Forms.PictureBox pctRullo1;
        private System.ComponentModel.BackgroundWorker bgwRullo1;
        private System.ComponentModel.BackgroundWorker bgwRullo2;
        private System.ComponentModel.BackgroundWorker bgwRullo3;
        private System.Windows.Forms.PictureBox pctTitolo;
        private System.Windows.Forms.Button btnRisultati;
    }
}

