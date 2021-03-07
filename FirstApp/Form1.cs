using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FirstApp
{
    public partial class Form1 : Form
    {
        #region Simple Event with Timer
        Timer Timer = new Timer();
        //public Form1()
        //{
        //    InitializeComponent();
        //    //Timer.Tick += Timer_Tick;
        //    //Timer.Interval = 500;
        //    //Timer.Start();


        //}

      

        private void Timer_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //string message = String.Empty;

            ////message = $"X : {e.X}    Y : {e.Y}";
            //if (e.Button == MouseButtons.Right)
            //{
            //    message = "You have clicked the right mouse button .";
            //}
            //else if (e.Button == MouseButtons.Left)
            //{
            //    message = "You have clicked the left mouse button .";
            //}

            //message += $"X : {e.X}    Y : {e.Y}"; ;
            //MessageBox.Show(message);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Task 1 Moveolanda 4 denelik hissenin her birinde ferqli reng olsun
            //ve coordinatlar Title a yazilsin
            //string message = $"X : {e.X}   Y : {e.Y}";
            //this.Text = message;
            //Task 2 her defe double click olanda ekran arxa rengi random olaraq deyishsin RGB
            //if (e.X <= 200 )
            //{
            //    this.BackColor = Color.Yellow;
            //}
            //else if (e.X >200 && e.X <= 400)
            //{
            //    this.BackColor = Color.Red;
            //}
            //else if (e.X > 400 && e.X <= 600)
            //{
            //    this.BackColor = Color.SpringGreen;
            //}
            //else if (e.X > 600 && e.X <= 800)
            //{
            //    this.BackColor = Color.DeepSkyBlue;
            //}
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("Mouse Entered");
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            //MessageBox.Show("Mouse Left");

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        // MessageBox.Show("Mouse Down");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Mouse Up");
        }
        #endregion



        #region Controls
        public Form1()
        {
            InitializeComponent();
            Start();



        }
        public void Start()
        {
            timeLbl.Text = $"Date : {DateTime.Now.ToShortDateString()}";

            //dynamic controls added
            Label labelT = new Label();
            labelT.AutoSize = true;
            labelT.Location = new Point(10, 20);
            labelT.BackColor = Color.Red;
            labelT.Text= $"Time : {DateTime.Now.ToShortTimeString()}";
            labelT.Font = new Font("Comic Sans MS", 30, FontStyle.Italic);

            //this.Controls.Add(labelT);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
           if(sender is Button bt)
            {
                bt.Dispose();

                Button button = new Button();
                button.Size = new Size(140, 50);
                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height- 100);
                button.Location = new Point(randomX, randomY);
                button.Text = "CLICK ME";
                button.Click += button1_Click;
                this.Controls.Add(button);

            } 
         //   MessageBox.Show("You clicked button");
        }
    }
}
