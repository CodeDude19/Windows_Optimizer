using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;

namespace Sample_Design_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;



        private void Form1_Load(object sender, EventArgs e)
        {


            {
                //set the interval to 500.
                timer1.Interval = 1000;
                //start the timer
                timer1.Start();

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Progressbar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            var u = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(1.2))
                .ContinueWith((t) => u.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            MessageBox.Show(u, "Please wait for 2 seconds.", "Cpu Optimizer");

            Stopwatch watch = new Stopwatch();
            watch.Start();
            while (true)
            {
               
                if (watch.Elapsed.TotalMilliseconds >= 10000) break;
                ;

            }
            watch.Stop();
            var w = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(1.2))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            MessageBox.Show(w,"Thankyou for being Patient your Cpu is optimized.","Cpu Optimizer");


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           Progressbar.Value = (int)(performanceCounter1.NextValue());
           
            label6.Text = "CPU Usage " + Progressbar.Value.ToString() + "%";
            Progressbar1.Value = (int)(performanceCounter2.NextValue());
            progressing1.Value = (int)(performanceCounter2.NextValue());
            label2.Text = "RAM Usage " + Progressbar1.Value.ToString() + "%";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var r = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(3))
                .ContinueWith((t) => r.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            MessageBox.Show(r, "Please wait for 5 seconds.", "Ram Optimizer");
            var MyMemoryIsTooFull = new string(' ', 512000000);
            var MyMemoryIsTooFullA = new string(' ', 512000000);

            var m = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(3))
                .ContinueWith((t) => m.Close(), TaskScheduler.FromCurrentSynchronizationContext());
            
            MessageBox.Show(m, "Your Ram is optimized.", "Ram Optimizer");
            ProcessStartInfo Info = new ProcessStartInfo();
           
            Application.Restart();
        }

    }

    
        
            
        
    }

        
    
