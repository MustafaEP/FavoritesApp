using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HızlıErisim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startApp(String key)
        {
            Process process = new Process();
            process.StartInfo.FileName = @key;
            process.Start();
        }
        //location of the file
        private void mouseHover(PictureBox pictureBox)
        {
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }
        private void mouseLeave(PictureBox pictureBox)
        {
            pictureBox.BorderStyle = BorderStyle.None;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            startApp("C:/Program Files/Notepad++/notepad++.exe");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            mouseHover(pictureBox1);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            startApp("C:/Program Files/Notepad++/notepad++.exe");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            mouseHover(pictureBox2);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            startApp("C:/Program Files/Notepad++/notepad++.exe");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            mouseHover(pictureBox3);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            startApp("C:/Program Files/Notepad++/notepad++.exe");
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            mouseHover(pictureBox4);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            startApp("C:/Program Files/Notepad++/notepad++.exe");
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            mouseHover(pictureBox5);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            startApp("C:/Program Files/Notepad++/notepad++.exe");
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            mouseHover(pictureBox6);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave(pictureBox6);
        }

        
    }
}
