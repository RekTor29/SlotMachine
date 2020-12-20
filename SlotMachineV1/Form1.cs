using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace SlotMachineV1
{
    public partial class frmMain : Form
    {
        //Volevo confrontare le immagini dentro le pct per verificare un ipotetico jackpot
        //Utilizzando un ipotetico If(pctbox1.Image == pctbox2.Image), tuttavia non mi è riuscito..
        //Quindi ho dichiarato 3 Int che conterranno i random per i 3 diversi rulli
        //Così da confrontarli alla fine dell'ultimo while e verificare se è uscito il Jackpot
        int NumRullo1 = 0;
        int NumRullo2 = 0;
        int NumRullo3 = 0;
        Random rnd = new Random();
        int numpartite = 0;
        int numvittorie = 0;
        Stopwatch tempopartita = new Stopwatch();
       
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnStart.Text = "Start";
            btnStop.Text = "Stop";
            btnRisultati.Text = "Statistiche";
            this.BackColor = System.Drawing.Color.Black;
            pctTitolo.Image = Properties.Resources.MagicSlot;

            btnStart.ForeColor = System.Drawing.Color.FromArgb(178, 0, 77);
            btnStop.ForeColor = System.Drawing.Color.FromArgb(178, 0, 77);
            btnRisultati.ForeColor = System.Drawing.Color.FromArgb(178, 0, 77);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            tempopartita.Start();         

            bgwRullo1.RunWorkerAsync();
            bgwRullo2.RunWorkerAsync();
            bgwRullo3.RunWorkerAsync();          
        }

        private void bgwRullo1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            Thread.Sleep(500);
            while (bgwRullo1.CancellationPending == false)
            {
                lock (rnd)
                {
                    NumRullo1 = rnd.Next(1, 5);
                }

                if (NumRullo1 == 1)
                {
                    pctRullo1.Image = Properties.Resources.Ciliegia;                    
                }
                else if (NumRullo1 == 2)
                {
                    pctRullo1.Image = Properties.Resources.Diamante;
                }
                else if (NumRullo1 == 3)
                {
                    pctRullo1.Image = Properties.Resources.Sette;
                }
                else if (NumRullo1 == 4)
                {
                    pctRullo1.Image = Properties.Resources.Uva;
                }
                Thread.Sleep(2000);
                pctRullo1.Image = null;
                Thread.Sleep(1000);
            }
        }

        private void bgwRullo2_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            while(bgwRullo2.CancellationPending == false)
            {
                lock (rnd)
                {
                    NumRullo2 = rnd.Next(1, 5);
                }

                if (NumRullo2 == 1)
                {
                    pctRullo2.Image = Properties.Resources.Ciliegia;
                }
                else if (NumRullo2 == 2)
                {
                    pctRullo2.Image = Properties.Resources.Diamante;
                }
                else if (NumRullo2 == 3)
                {
                    pctRullo2.Image = Properties.Resources.Sette;
                }
                else if (NumRullo2 == 4)
                {
                    pctRullo2.Image = Properties.Resources.Uva;
                }
                Thread.Sleep(2000);
                pctRullo2.Image = null;
                Thread.Sleep(1000);
            }
        }


        private void bgwRullo3_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1500);
            while (bgwRullo3.CancellationPending == false)
            {
                lock (rnd)
                {
                   NumRullo3 = rnd.Next(1, 5);
                }

                if (NumRullo3 == 1)
                {
                    pctRullo3.Image = Properties.Resources.Ciliegia;
                }
                else if (NumRullo3 == 2)
                {
                    pctRullo3.Image = Properties.Resources.Diamante;
                }
                else if (NumRullo3 == 3)
                {
                    pctRullo3.Image = Properties.Resources.Sette;
                }
                else if (NumRullo3 == 4)
                {
                    pctRullo3.Image = Properties.Resources.Uva;
                }

                //IF CHE VOLEVO USARE PER VERIFICARE IL JACKPOT:
                //if ((pctRullo1.Image == pctRullo2.Image) && (pctRullo1.Image == pctRullo3.Image))
                //{
                //    pctTitolo.Image = null;
                //    pctTitolo.Image = Properties.Resources.JACKPOT;
                //}
                if((NumRullo1 == NumRullo2)  && (NumRullo1 == NumRullo3))
                {
                    pctTitolo.Image = null;
                    pctTitolo.Image = Properties.Resources.JACKPOT;
                    
                    numvittorie++;
                }
                Thread.Sleep(2000);
                pctTitolo.Image = null;
                pctTitolo.Image = Properties.Resources.MagicSlot;
                pctRullo3.Image = null;
                Thread.Sleep(1000);
                numpartite++;
                
                
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {            
            tempopartita.Stop();
            bgwRullo1.CancelAsync();
            bgwRullo2.CancelAsync();
            bgwRullo3.CancelAsync();

            //Faccio aspettare al bottone 3 secondi per far finire il lavoro ai bgw
            //E per evitare errori
            Thread.Sleep(3000);
            btnStart.Enabled = true;
        }
        private void btnRisultati_Click(object sender, EventArgs e)
        {
            string messaggiomsgbox = "Numero Partite: " + numpartite + "\nPartite Vinte: " + numvittorie +"\nTempo di gioco:" + tempopartita.Elapsed.TotalSeconds + " Secondi";
            string titolomsgbox = "Statistiche";

            MessageBox.Show(messaggiomsgbox, titolomsgbox);
        }
    }
}
