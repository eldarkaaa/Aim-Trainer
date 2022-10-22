using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aim_Trainer
{

    public partial class Form1 : Form
    {
        public Random rand = new Random();
        private void TrueSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\eldar\source\repos\Aim Trainer\sound\hit.wav"); //Звук попадания
            simpleSound.Play();
        }
        int _score = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void roundButton1_Click(object sender, EventArgs e)
        {
            roundButton1.Location = new Point(rand.Next(0, 650), rand.Next(0, 450));
            AddScore(10);
            TrueSound();

        }
        private void AddScore(int a)
        {
            _score += a;
            score.Text = Convert.ToString("Score:" + _score);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            AddScore(-5);
        }
    }
}
