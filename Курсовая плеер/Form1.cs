using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using WMPLib;
namespace Курсовая_плеер
{
    public partial class Form1 : Form
    {
        
        private Audio audio;
        public string[] songs;
        public string[] paths;
        private string folderpath = @"C:\Users\boris\Music\iTunes\";
        string s=string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        static int PlayPause = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        private void button2_Click(object sender, EventArgs e)
        {
            //progressBar1.PerformStep(); 
            

                this.Text = WMP.versionInfo;
            
            
            WMP.controls.play();
            
            
            
            


        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            

        }
        OpenFileDialog o = new OpenFileDialog()
        {
            Filter = "MP3|*.mp3"
        };
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (o.ShowDialog() == DialogResult.OK)
                s = o.FileName;
            
              Плейлист.Items.Add(s);

        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            WMP.controls.pause();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                WMP.URL = paths[Плейлист.SelectedIndex];
                WMP.controls.play();
                textBox1.Text = $"Сейчас играет{paths[Плейлист.SelectedIndex]}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
                OpenFileDialog o = new OpenFileDialog();
            o.Filter = "MP3|*.mp3";
            o.Multiselect = true;
            if (o.ShowDialog() ==System.Windows.Forms.DialogResult.OK)
            {
                songs = o.FileNames;
                paths = o.FileNames;
                for (int i = 0; i < songs.Length; i++)
                {
                    Плейлист.Items.Add(songs[i]);
                }
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Плейлист.SelectedIndex < Плейлист.Items.Count-1)
                Плейлист.SelectedIndex = Плейлист.SelectedIndex + 1;
            else
                MessageBox.Show("Конец плейлиста");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Плейлист.SelectedIndex>0)
                Плейлист.SelectedIndex = Плейлист.SelectedIndex - 1;
            else
            {
                MessageBox.Show("Вы в самом начале плейлиста");
            }
        }

        private void buttonplay_MouseDown(object sender, MouseEventArgs e)
        {
            buttonplay.BackColor = Color.Khaki;
        }

        private void buttonplay_MouseUp(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.DarkKhaki;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.Khaki;
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.DarkKhaki;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Khaki;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.DarkKhaki;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Khaki;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.DarkKhaki;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Khaki;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.DarkKhaki;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
            
}

