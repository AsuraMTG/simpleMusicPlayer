using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Resources;

namespace simpleMusicPlayer
{
    
    public partial class Form1 : Form
    {
        public static void PlayMusic(string filepath, bool playorstop)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            if (playorstop == true)
            {
                musicPlayer.SoundLocation = filepath;
                musicPlayer.Play();
            }
            else
                musicPlayer.Stop();
        }
        public Form1()
        {
            InitializeComponent();
            listBox1.Hide();
            listBox2.Hide();
            listBox3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\Asura\Desktop\Programing\simpleMusicPlayer\simpleMusicPlayer\bin\Debug\play.png");
            PlayMusic("Vamp.wav", false);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Album1 = new List<string>()
            {
                "1.\t\"Green Room\"",
                "2.\t\"Jennifer\'s Body\"",
                "3.\t\"Fighting My Demons\"",
                "4.\t\"Singapore\"",
                "5.\t\"Lose It\"",
                "6.\t\"Hardcore\"",
                "7.\t\"Me N My Kup\"",
                "8.\t\"It's Over\"",
                "9.\t\"Succubus\"",
                "10.\t\"Paranoid\"",
                "11.\t\"Pots\"",
                "12.\t\"Like This\"",
                "13.\t\"Overtime\"",
                "14.\t\"Vampire Hour\"",
                "15.\t\"Nightcore\"",
                "16.\t\"Nightcore 2\"",
                "17.\t\"Rockstar Lifestyle\"",
                "18.\t\"I Need U\""
            };
            var Album1tsongs = new List<string>()
            {
                "GreenRoom.wav",
                "Jennifer'sBody.wav",
                "FightingMyDemons.wav",
                "4.\t\"Singapore\"",
                "5.\t\"Lose It\"",
                "6.\t\"Hardcore\"",
                "7.\t\"Me N My Kup\"",
                "8.\t\"It's Over\"",
                "9.\t\"Succubus\"",
                "10.\t\"Paranoid\"",
                "11.\t\"Pots\"",
                "12.\t\"Like This\"",
                "13.\t\"Overtime\"",
                "14.\t\"Vampire Hour\"",
                "15.\t\"Nightcore\"",
                "16.\t\"Nightcore 2\"",
                "17.\t\"Rockstar Lifestyle\"",
                "18.\t\"I Need U\""
            };

            for (int i = 0; i < listBox1.Items.Count; i++) 
            {
                if (listBox1.Text == Album1[i])
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\Asura\Desktop\Programing\simpleMusicPlayer\simpleMusicPlayer\bin\Debug\pause.png");
                    label1.Text = Album1[i];
                    PlayMusic(Album1tsongs[i], true);
                }
            }
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            listBox1.Show();
            listBox2.Hide();
            listBox3.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
            listBox2.Show();
            listBox3.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
            listBox2.Hide();
            listBox3.Show();
        }
    }
}
