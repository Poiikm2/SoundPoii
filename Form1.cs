using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace SoundPoiiv2
{
    public partial class Form1 : Form
    {
        MediaPlayer player = new MediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            player.Open(new Uri(@"C:\Users\Poii\Desktop\SoundPoii\SoundFiles\emotionaldmg.mp3"));
            label2.Text = "Emotional Damage";
            player.Play();
            player.MediaEnded += (s, x) => label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Open(new Uri(@"C:\Users\Poii\Desktop\SoundPoii\SoundFiles\getshiton.mp3"));
            label2.Text = "Get Shit On!";
            player.Play();
            player.MediaEnded += (s, x) => label2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Open(new Uri(@"C:\Users\Poii\Desktop\SoundPoii\SoundFiles\deeznuts.mp3"));
            label2.Text = "Deez Nuts";
            player.Play();
            player.MediaEnded += (s, x) => label2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.Open(new Uri(@"C:\Users\Poii\Desktop\SoundPoii\SoundFiles\damn.mp3"));
            label2.Text = "Damnnnn";
            player.Play();
            player.MediaEnded += (s, x) => label2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.Open(new Uri(@"C:\Users\Poii\Desktop\SoundPoii\SoundFiles\fyalife.mp3"));
            label2.Text = "Big Bong";
            player.Play();
            player.MediaEnded += (s, x) => label2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.Open(new Uri(@"C:\Users\Poii\Desktop\SoundPoii\SoundFiles\hellothere.mp3"));
            label2.Text = "Hello There";
            player.Play();
            player.MediaEnded += (s, x) => label2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.Open(new Uri(@"C:\Users\Poii\Desktop\SoundPoii\SoundFiles\stepbro.mp3"));
            label2.Text = "Step Bro";
            player.Play();
            player.MediaEnded += (s, x) => label2.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            player.Open(new Uri(@"C:\Users\Poii\Desktop\SoundPoii\SoundFiles\nani.mp3"));
            label2.Text = "Nani";
            player.Play();
            player.MediaEnded += (s, x) => label2.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            player.Open(new Uri(@"C:\Users\Poii\Desktop\SoundPoii\SoundFiles\leroy.mp3"));
            label2.Text = "Leroy Jenkins";
            player.Play();
            player.MediaEnded += (s, x) => label2.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player.Stop();
            label2.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//mediaplayer function volume
//mediaplayer function close