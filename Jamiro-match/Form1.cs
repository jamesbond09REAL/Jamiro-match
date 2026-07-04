using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jamiro_match
{
    public partial class Form1 : Form
    {
        private SoundPlayer sound1;

        public Form1()
        {
            InitializeComponent();
            sound1 = new SoundPlayer("ALR.wav");
        }
        public int orange = 0;
        public int peaky = 0;
        public int gang = 0;
        public int guy = 0;
        public int snail = 0;
        public int tuff = 0;
        
        

        private void ocover1_Click(object sender, EventArgs e)
        {
            ocover1.Visible= false;
            if(orange <= 0)
            {
                orange = 1;
            }
            else if(orange == 1)
            {
                orangebackj1.Visible = false;
                orangebackj2.Visible = false;
                orange = 9999;
                sound1.Play(); // Play sound on match
            }
            
            
            peaky--;
            gang--;
            guy--;
            snail--;
            tuff --;
            
        }

        private void ocover2_Click(object sender, EventArgs e)
        {
            ocover2.Visible = false;
            if (orange <= 0)
            {
                orange = 1;
            }
            else if (orange == 1)
            {
                orangebackj1.Visible = false;
                orangebackj2.Visible = false;
                orange = 9999;
                sound1.Play();

            }


            peaky--;
            gang--;
            guy--;
            snail--;
            tuff--;

        }

        private void peakycover1_Click(object sender, EventArgs e)
        {
            peakycover1.Visible = false;
            if (peaky <= 0)
            {
                peaky = 1;
            }
            else if (peaky == 1)
            {
                peakyj1.Visible = false;
                peakyj2.Visible = false;
                peaky = 9999;
                sound1.Play();
            }


            orange--;
            gang--;
            guy--;
            snail--;
            tuff--;

        }
        

        private void peakycover2_Click(object sender, EventArgs e)
        {
            peakycover2.Visible = false;
            if (peaky <= 0)
            {
                peaky = 1;
            }
            else if (peaky == 1)
            {
                peakyj1.Visible = false;
                peakyj2.Visible = false;
                peaky = 9999;
                sound1.Play();
            }


            orange--;
            gang--;
            guy--;
            snail--;
            tuff--;
        }

        private void gangcover1_Click(object sender, EventArgs e)
        {
            gangcover1.Visible = false;
            if (gang <= 0)
            {
                gang = 1;
            }
            else if (gang == 1)
            {
                thegang1.Visible = false;
                thegang2.Visible = false;
                gang = 9999;
                sound1.Play();
            }


            orange--;
            peaky--;
            guy--;
            snail--;
            tuff--;
        }

        private void gangcover2_Click(object sender, EventArgs e)
        {
            gangcover2.Visible = false;
            if (gang <= 0)
            {
                gang = 1;
            }
            else if (gang == 1)
            {
                thegang1.Visible = false;
                thegang2.Visible = false;
                gang = 9999;
                sound1.Play();
            }


            orange--;
            peaky--;
            guy--;
            snail--;
            tuff--;
        }

        private void guycover1_Click(object sender, EventArgs e)
        {
            guycover1.Visible = false;
            if (guy <= 0)
            {
                guy = 1;
            }
            else if (guy == 1)
            {
                manwearing1.Visible = false;
                manwearing2.Visible = false;
                guy = 9999;
                sound1.Play();
            }


            orange--;
            peaky--;
            gang--;
            snail--;
            tuff--;
        }

        private void guycover2_Click(object sender, EventArgs e)
        {
            guycover2.Visible = false;
            if (guy <= 0)
            {
                guy = 1;
            }
            else if (guy == 1)
            {
                manwearing1.Visible = false;
                manwearing2.Visible = false;
                guy = 9999;
                sound1.Play();
            }


            orange--;
            peaky--;
            gang--;
            snail--;
            tuff--;
        }

        private void snail1_Click(object sender, EventArgs e)
        {
            snailcover1.Visible = false;
            if (snail <= 0)
            {
                snail = 1;
            }
            else if (snail == 1)
            {
                snailmail1.Visible = false;
                snailmail2.Visible = false;
                snail = 9999;
                sound1.Play();
            }
            orange--;
            peaky--;
            gang--;
            guy--;
            tuff--;
        }

        private void snail2_Click(object sender, EventArgs e)
        {
            snailcover2.Visible = false;
            if (snail <= 0)
            {
                snail = 1;
            }
            else if (snail == 1)
            {
                snailmail1.Visible = false;
                snailmail2.Visible = false;
                snail = 9999;
                sound1.Play();
            }
            orange--;
            peaky--;
            gang--;
            guy--;
            tuff--;
        }

        private void tuff1_Click(object sender, EventArgs e)
        {
            tuffcover1.Visible = false;
            if (tuff <= 0)
            {
                tuff = 1;
            }
            else if (tuff == 1)
            {
                tuffaura1.Visible = false;
                tuffaura2.Visible = false;
                tuff = 9999;
                sound1.Play();
            }
            orange--;
            peaky--;
            gang--;
            guy--;
            snail--;
        }

        private void tuff2_Click(object sender, EventArgs e)
        {
            tuffcover2.Visible = false;
            
            if (tuff <= 0)
            {
                tuff = 1;
            }
            else if (tuff == 1)
            {
                tuffaura1.Visible = false;
                tuffaura2.Visible = false;
                tuff = 9999;
                sound1.Play();
            }
            orange--;
            peaky--;
            gang--;
            guy--;
            snail--;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (orange <= 0)
            {
                ocover1.Visible = true;
                ocover2.Visible = true;
            }
            if (peaky <= 0)
            {
                peakycover1.Visible = true;
                peakycover2.Visible = true;
            }
            if (gang <= 0)
            {
                gangcover1.Visible = true;
                gangcover2.Visible = true;
            }
            if (guy <= 0)
            {
                guycover1.Visible = true;
                guycover2.Visible = true;
            }
            if (snail <= 0)
            {
                snailcover1.Visible = true;
                snailcover2.Visible = true;
            }
            if (tuff <= 0)
            {
                tuffcover1.Visible = true;
                tuffcover2.Visible = true;
            }
        }

        private void shuffle_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            List<Point> coordinates = new List<Point>
            {
                new Point(346, 100),
                new Point(411, 100),
                new Point(476, 100),
                new Point(541, 100),
                new Point(346, 250),
                new Point(411, 250),
                new Point(476, 250),
                new Point(541, 250),
                new Point(346, 400),
                new Point(411, 400),
                new Point(476, 400),
                new Point(541, 400)
            };
            
            Point randomCoordinate = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate);
            ocover1.Location = randomCoordinate;
            orangebackj1.Location = randomCoordinate;
            Point randomCoordinate2 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate2);
            ocover2.Location = randomCoordinate2;
            orangebackj2.Location = randomCoordinate2;
            Point randomCoordinate3 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate3);
            peakycover1.Location = randomCoordinate3;
            peakyj1.Location = randomCoordinate3;
            Point randomCoordinate4 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate4);
            peakycover2.Location = randomCoordinate4;
            peakyj2.Location = randomCoordinate4;
            Point randomCoordinate5 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate5);
            gangcover1.Location = randomCoordinate5;
            thegang1.Location = randomCoordinate5;
            Point randomCoordinate6 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate6);
            gangcover2.Location = randomCoordinate6;
            thegang2.Location = randomCoordinate6;
            Point randomCoordinate7 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate7);
            guycover1.Location = randomCoordinate7;
            manwearing1.Location = randomCoordinate7;
            Point randomCoordinate8 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate8);
            guycover2.Location = randomCoordinate8;
            manwearing2.Location = randomCoordinate8;
            Point randomCoordinate9 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate9);
            snailcover1.Location = randomCoordinate9;
            snailmail1.Location = randomCoordinate9;
            Point randomCoordinate10 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate10);
            snailcover2.Location = randomCoordinate10;
            snailmail2.Location = randomCoordinate10;
            Point randomCoordinate11 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate11);
            tuffcover1.Location = randomCoordinate11;
            tuffaura1.Location = randomCoordinate11;
            Point randomCoordinate12 = coordinates[random.Next(coordinates.Count)];
            coordinates.Remove(randomCoordinate12);
            tuffcover2.Location = randomCoordinate12;
            tuffaura2.Location = randomCoordinate12;
            ocover1.Enabled = true;
            ocover2.Enabled = true;
            peakycover1.Enabled = true;
            peakycover2.Enabled = true;
            gangcover1.Enabled = true;
            gangcover2.Enabled = true;
            guycover1.Enabled = true;
            guycover2.Enabled = true;
            snailcover1.Enabled = true;
            snailcover2.Enabled = true;
            tuffcover1.Enabled = true;
            tuffcover2.Enabled = true;
            shuffle.Visible = false;








        }
    }
}
