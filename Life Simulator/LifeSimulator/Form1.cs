using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSimulator
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private GameEngine gameEngine;
        private int resolution;
        private static Assembly assembly = Assembly.GetExecutingAssembly();
        private static Stream resourseStream = assembly.GetManifestResourceStream(@"LifeSimulator.music.wav");
        private SoundPlayer soundPlayer = new SoundPlayer(resourseStream);
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (timer1.Enabled)
                return;

            numDensity.Enabled = false;
            numResolution.Enabled = false;
            resolution = (int)numResolution.Value;

            gameEngine = new GameEngine
            (
                rows: pictureBox1.Height / resolution,
                cols: pictureBox1.Width / resolution,
                density: (int)(numDensity.Minimum) + (int)(numDensity.Maximum) - (int)(numDensity.Value)
            );

            Text = $"Generation {gameEngine.CurrentGeneration}";

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }

        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);

            var field = gameEngine.GetCurrentGeneration();
            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x, y])
                    {
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                    }
                }
            }
            pictureBox1.Refresh();
            Text = $"generation {gameEngine.CurrentGeneration}";
            gameEngine.NextGeneration();
        }

        private void StopGame()
        {
            if (!timer1.Enabled)
                return;

            timer1.Stop();

            numDensity.Enabled = true;
            numResolution.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.AddCell(x, y);
            }

            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.RemoveCell(x, y);
            }
        }

        private void musicON_Click(object sender, EventArgs e)
        {
            soundPlayer.PlayLooping();
        }

        private void musicOFF_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }
    }
}
