using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
