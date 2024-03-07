using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private PictureBox[] cars;
        private Thread[] threads;
        private int[] suret;
        private const int yolUzunlugu = 1400;
        private int[] bitmeSirasi;

        public Form1()
        {
            InitializeComponent();
            InitializeCars();
            bitmeSirasi = new int[cars.Length];
        }
        private void InitializeCars()
        {
            cars = new PictureBox[] {bluecar, redcar, blCKCAR };
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            Start();
        }
        private void Start()
        {
            
            suret = new int[cars.Length];
            for (int i = 0; i < cars.Length; i++)
            {
                suret[i] = random.Next(1, 100); 
            }

            threads = new Thread[cars.Length];

            
            for (int i = 0; i < cars.Length; i++)
            {
                int mashinIndeksi = i;
                threads[i] = new Thread(() => HereketEt(mashinIndeksi));
                threads[i].IsBackground = true;

                
                int priorityValue = random.Next(0, 3);
                threads[i].Priority = (ThreadPriority)priorityValue;

                threads[i].Start();
            }
        }

        private void HereketEt(int mIndeksi)
        {
            while (cars[mIndeksi].Left < yolUzunlugu)
            {
               
                this.Invoke((MethodInvoker)delegate {
                    cars[mIndeksi].Left += suret[mIndeksi];
                });

              
                Thread.Sleep(random.Next(200, 550)); 
                suret[mIndeksi] += random.Next(-1, 2); 
                suret[mIndeksi] = Math.Max(1, suret[mIndeksi]);
            }

            QalibiTap(mIndeksi);
        }

      
private void QalibiTap(int qalibIndeksi)
        {
            int position = Array.IndexOf(bitmeSirasi, 0); 
            bitmeSirasi[position] = qalibIndeksi + 1; 

            
            MessageBox.Show($"{qalibIndeksi + 1}.Maşın  {position + 1}ci oldu.", "Nəticə");

            
        }



    }
}
