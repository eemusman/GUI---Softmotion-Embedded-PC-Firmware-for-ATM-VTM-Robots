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

namespace GUIsf
{


    public partial class Form1 : Form
    {

        private BackgroundWorker bw;
        ECPlatform ecplatform = new ECPlatform();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Shown += new System.EventHandler(this.updateprogressbar);
            //Background worker
            bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_updateprogressbar);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_progresschanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_runworkercompleted);
            bw.WorkerReportsProgress = true;


        }



        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();

            if (!bw.IsBusy)
            {
                bw.RunWorkerAsync();
            }
           


        }
        private void bw_progresschanged(object sender, ProgressChangedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                
                this.ProgressBar2.Value = e.ProgressPercentage;
            });
            

        }

        private void bw_runworkercompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //this.progressBar1.Visible = false;
            
            MainGUI mainGUI = new MainGUI(this);
            mainGUI.Show();
            this.Hide(); 

        }

        private void bw_updateprogressbar(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            for (int i = 0; i < ECPlatform.parameterindices.Length; i++)
            {


                if (i < (ECPlatform.parameterindices.Length - 1))
                {
                    ecplatform.WriteSDO(0, ECPlatform.parameterindices[i], 0x00, ECPlatform.defaultparametervalues[i]);

                    
                    
                }
                
                worker.ReportProgress((i + 1) * (100 / ECPlatform.parameterindices.Length)+4 );
                Thread.Sleep(200);

            }
        }




        

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
