using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX =5 , yerY =5, can=3 ;
        private void CarpmaOlayi ()
        {
            if (ball.Top <= label2.Bottom)  //LABEL2 ÇARPMASI 
                yerY = yerY * -1;

            if (ball.Top >= kontrol.Top && ball.Left >= kontrol.Left && ball.Right <= kontrol.Right)   // kontrol çarpma olayı
                yerY = yerY * -1;

            else if (ball.Right >= label5.Left) //sağ kenardan sekmesini sağlıyo
                yerX = yerX * -1;

            else if (ball.Left <= label1.Right) //sol kenardan sekmesini sağlıyor
                yerX = yerX * -1;
        }
        private void YanmaOlayi(object sender, EventArgs e)
        {
            if (ball.Top >= label5.Bottom)
            {
                if(can >0)
                {
                   timer1.Stop();
                    can--;
                    MessageBox.Show("Yandınız kalan can >=" + can.ToString());
                    
                }
                if(can==0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun Bitti!!", "", MessageBoxButtons.OK);

                }
            }
            label3.Text = can.ToString(); 
        }
        private void TopBasa ()
        {
            ball.Location = new Point(321, 136);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left =e.X;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load (object sender, EventArgs e)
        {
            TopBasa();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            CarpmaOlayi();
            YanmaOlayi(sender,e);
            ball.Location = new Point(ball.Location.X + yerX, ball.Location.Y + yerY);
        }
    }
}
