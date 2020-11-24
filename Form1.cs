using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio2_BGW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BackgroundWorker bgw, bgw1;

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            //dichiarazione variabili
            BackgroundWorker worker = sender as BackgroundWorker;
            Random rnd = new Random();
            string[] info = new string[2];
            int somma = 0;
            bool check = true;

            //assegnazione informazioni da trasmettere - colore e movimento
            info[0] = (string)e.Argument;

            while (somma <= 350 && check == true)
            {
                Thread.Sleep(30); // aspetta 30 ms

                //random velocità
                info[1] = rnd.Next(0, 5).ToString();
                somma += int.Parse(info[1]);

                //invio values
                worker.ReportProgress(0, info);
                e.Result = info[0];

                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    check = false;
                }
            }
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //ottenimento dati dal bgw
            string[] info = (string[])e.UserState;

            //perform steps
            if (info[0] == "black")
            {
                pic_black.Left += int.Parse(info[1]);
            }
            else if(info[0] == "red")
            {
                pic_red.Left += int.Parse(info[1]);
            }
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //annullato
            }
            else if ((string)e.Result == "black")
            {
                //se vince la nera ferma la rossa
                bgw1.CancelAsync();
                MessageBox.Show("winner : black");

            }
            else if ((string)e.Result == "red")
            {
                //se vince la rossa ferma la nera
                bgw.CancelAsync();
                MessageBox.Show("winner : red");
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            
            bgw = new BackgroundWorker();
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.DoWork += bgw_DoWork;
            bgw.ProgressChanged += bgw_ProgressChanged;
            bgw.RunWorkerCompleted += bgw_RunWorkerCompleted;

            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += bgw_DoWork;
            bgw1.ProgressChanged += bgw_ProgressChanged;
            bgw1.RunWorkerCompleted += bgw_RunWorkerCompleted;

            //prima macchina parte
            bgw.RunWorkerAsync("black");

            //aspetta 100ms per problema ai 2 generatori random
            Thread.Sleep(100);

            bgw1.RunWorkerAsync("red");

        }
    }
}
