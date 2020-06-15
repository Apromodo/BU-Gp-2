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

namespace _30mayısv2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 400;
          //  progressBar1.Step = 1;

            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
        //    progressBar2.Step = 1;

            progressBar3.Minimum = 0;
            progressBar3.Maximum = 600;
        //    progressBar3.Step = 1;
        }

        private void baslatButon_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;

            Thread thread1 = new Thread(new ThreadStart(t1));
            Thread thread2 = new Thread(new ThreadStart(t2));
            Thread thread3 = new Thread(new ThreadStart(t3));

            //thread1.Priority = ThreadPriority.Highest;
            //thread2.Priority = ThreadPriority.Lowest;
            //thread3.Priority = ThreadPriority.Lowest;
            thread1.Start();
         //   thread1.Join(); //thread1 bitene kadar diğerleri bekler
            thread2.Start();
         //   thread2.Join(); //thread2 bitene kadar diğerleri bekler
            thread3.Start();

            

        }
        public void t1()
        {
            while (progressBar1.Value < 400)
            {
                progressBar1.Value += 1;
         //       Thread.Sleep(10);
            }
        }
        public void t2()
        {
            while (progressBar2.Value < 100)
            {
                progressBar2.Value += 1;
          //      Thread.Sleep(60);
            }
        }
        public void t3()
        {
            while (progressBar3.Value < 600)
            {
                progressBar3.Value += 1;
         //       Thread.Sleep(5);
            }
        }
    }
}
